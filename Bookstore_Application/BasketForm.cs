using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore_Application
{

    public partial class BasketForm : Form
    {
        private int mouseX, mouseY, mouseInX, mouseInY;
        private bool mouseDown;

        string name;
        string email;
        string bookItems = "";
        float totalPrice = 0;

        public List<List<string>> Basket_list { get; set; }
        public List<List<Control>> ControlList { get; set; }

        private Regex cardRegex = new Regex(@"^(?:4[0-9]{12}(?:[0-9]{3})?|[25][1-7][0-9]{14}|6(?:011|5[0-9][0-9])[0-9]{12}|3[47][0-9]{13}|3(?:0[0-5]|[68][0-9])[0-9]{11}|(?:2131|1800|35\d{3})\d{11})$");
        private Match match;

        DBConnection dbconn = new DBConnection("localhost", "bookstore_schema", "root", "root");
        DataTable dt;



        public BasketForm(List<List<string>> Basket_list, string name , string email)
        {
            InitializeComponent();

            this.Basket_list = Basket_list;
            this.name = name;
            this.email = email;
            nameBasketLabel.Text = this.name + " Basket";

            initBasket();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            basketMainPanel.Visible = false;
            payPanel.Visible = true;
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            payPanel.Visible = false;
            basketMainPanel.Visible = true;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            creditCardNumberTextBox.Text = creditCardNumberTextBox.Text.Replace("-", "");

            if (creditCardComboBox.Text.Equals(string.Empty))
            {
                creditCardErrorLabel.Visible = true;
            }
            else
            {
                creditCardErrorLabel.Visible = false;
            }

            if (creditCardNumberTextBox.Text.Equals(string.Empty))
            {
                creditCardNumberErrorLabel.Text = "*Credit Card Number is required";
                creditCardNumberErrorLabel.Visible = true;
            }
            else
            {
                match = cardRegex.Match(creditCardNumberTextBox.Text);

                if (!match.Success)
                {
                    creditCardNumberErrorLabel.Text = "*Credit Card Number is not valid";
                    creditCardNumberErrorLabel.Visible = true;
                }
                else
                {
                    creditCardNumberErrorLabel.Visible = false;
                }
            }

            if (monthComboBox.Text.Equals(string.Empty))
            {
                expiredMonthErrorLabel.Visible = true;
            }
            else
            {
                expiredMonthErrorLabel.Visible = false;
            }

            if (yearComboBox.Text.Equals(string.Empty))
            {
                expiredYearErrorLabel.Visible = true;
            }
            else
            {
                expiredYearErrorLabel.Visible = false;
            }

            if (ccvTextBox.Text.Equals(string.Empty))
            {
                cvvErrorLabel.Visible = true;
            }
            else
            {
                cvvErrorLabel.Visible = false;
                int count = 0;
                foreach (char c in ccvTextBox.Text)
                {
                    count++;
                    if (!char.IsDigit(c) || count > 3)
                    {
                        cvvErrorLabel.Text = "*CVV code must contains 3 digits";
                        cvvErrorLabel.Visible = true;
                        break;
                    }
                }
            }

            if (creditCardErrorLabel.Visible || creditCardNumberErrorLabel.Visible || expiredMonthErrorLabel.Visible || expiredYearErrorLabel.Visible || cvvErrorLabel.Visible)
            {
                return;
            }

            string date = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

            dbconn.Select("INSERT INTO bookstore_schema.orders (order_email, order_items, order_price, order_date) VALUES ('" + email + "', '" + bookItems + "', " + totalPrice + ", '" + date + "');");

            dt = dbconn.Select("SELECT order_id as id FROM bookstore_schema.orders WHERE order_email = '" + email + "' AND order_date = '" + date + "' AND received_date IS NULL;");

            Thread.Sleep(2000);

            Thread completeOrder = new Thread(delegate ()
            {
                string orderID = dt.Rows[0]["id"].ToString();
                Thread.Sleep(10000);            

                dbconn.ExecuteNonQuery("UPDATE bookstore_schema.orders SET received_date = '" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "' WHERE order_id = " + orderID + ";");

            });
            completeOrder.Name = "CopleteOrder";
            completeOrder.IsBackground = true;
            completeOrder.Start();

            basketTableLayoutPanel.RowCount = 1;

            MessageBox.Show("Order confirmed!", "Confirmation", MessageBoxButtons.OK);

            Basket_list.Clear();

            this.Close();
        }

        private void moveBasketPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - mouseInX;
                mouseY = MousePosition.Y - mouseInY;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void moveBasketPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseInX = MousePosition.X - Bounds.X;
            mouseInY = MousePosition.Y - Bounds.Y;

            mouseDown = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void moveBasketPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void payPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void moveBasketPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void initBasket()
        {
            if (Basket_list.Count == 0)
            {
                noItemsLabel.Visible = true;
                confirmButton.Enabled = false;
                return;
            }

            confirmButton.Enabled = true;

            for (int i = 0; i < Basket_list.Count; i++)
            {
                Label infoBookLabel = new Label()
                {
                    Name = "bookInfoLabel" + i,
                    Font = new Font(new FontFamily("Arial"), 9, FontStyle.Regular),
                    Anchor = AnchorStyles.None,
                    AutoSize = true,
                    Text = Basket_list[i][0] + ", " + Basket_list[i][1] + ", " + Basket_list[i][2]
                };

                bookItems += infoBookLabel.Text + "  ";

                Label priceLabel = new Label()
                {
                    Name = "priceColLabel" + i,
                    Font = new Font(new FontFamily("Arial"), 9, FontStyle.Regular),
                    Anchor = AnchorStyles.None,
                    AutoSize = true,
                    Text = Basket_list[i][3]
                };

                NumericUpDown quantity = new NumericUpDown()
                {
                    Name = "quantityNumericUpDown" + i,
                    Maximum = 200,
                    Anchor = AnchorStyles.None,
                    Size = new Size(120, 22),
                    Value = int.Parse(Basket_list[i][5]),
                    Tag = i + 1
                };

                if(quantity.Value > int.Parse(Basket_list[i][4]))
                {
                    quantity.BackColor = Color.Red;
                }

                quantity.ValueChanged += new EventHandler(checkQuantity);

                PictureBox remove = new PictureBox()
                {
                    Name = "deletePictureBox" + i,
                    SizeMode = PictureBoxSizeMode.AutoSize,
                    Anchor = AnchorStyles.None,
                    Image = Bookstore_Application.Properties.Resources.delete,
                    Tag = i + 1
                };

                remove.Click += new EventHandler(DeleteRow);

                basketTableLayoutPanel.RowCount++;
                basketTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 52f));
                basketTableLayoutPanel.Controls.Add(infoBookLabel, 0, i + 1);
                basketTableLayoutPanel.Controls.Add(priceLabel, 1, i + 1);
                basketTableLayoutPanel.Controls.Add(quantity, 2, i + 1);
                basketTableLayoutPanel.Controls.Add(remove, 3, i + 1);
                totalPrice += float.Parse(Basket_list[i][3]) * int.Parse(Basket_list[i][5]);

            }

            totalPricelabel.Text += totalPrice + " €";       
            basketTableLayoutPanel.Visible = true;
        }

        private void DeleteRow(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            int rowIndex = Convert.ToInt32(pb.Tag);

            basketTableLayoutPanel.SuspendLayout();

            // delete all controls of row that we want to delete
            for (int i = 0; i < basketTableLayoutPanel.ColumnCount; i++)
            {
                var control = basketTableLayoutPanel.GetControlFromPosition(i, rowIndex);
                basketTableLayoutPanel.Controls.Remove(control);
            }

            // move up row controls that comes after row we want to remove
            for (int i = rowIndex + 1; i < basketTableLayoutPanel.RowCount; i++)
            {
                for (int j = 0; j < basketTableLayoutPanel.ColumnCount; j++)
                {
                    var control = basketTableLayoutPanel.GetControlFromPosition(j, i);
                    if (control != null)
                    {
                        basketTableLayoutPanel.SetRow(control, i - 1);

                        if (j > 1)
                        {
                            control.Tag = i - 1;
                        }
                    }
                }
            }

            var removeStyle = basketTableLayoutPanel.RowCount - 1;

            if (basketTableLayoutPanel.RowStyles.Count > removeStyle)
                basketTableLayoutPanel.RowStyles.RemoveAt(removeStyle);

            basketTableLayoutPanel.RowCount--;
            totalPrice = totalPrice - (float.Parse(Basket_list[rowIndex - 1][3]) * int.Parse(Basket_list[rowIndex - 1][5]));
            totalPricelabel.Text = "Total Price: " + totalPrice + " €";
            Basket_list.RemoveAt(rowIndex - 1);
           

            if (basketTableLayoutPanel.RowCount == 1)
            {
                basketTableLayoutPanel.Visible = false;
                noItemsLabel.Visible = true;
                totalPricelabel.Text = "Total Price: 0 €";
            }

            basketTableLayoutPanel.ResumeLayout();
        }

        private void checkQuantity(object sender, EventArgs e)
        {
            NumericUpDown quant = (NumericUpDown)sender;
            int row = Convert.ToInt32(quant.Tag);

            if (quant.Value > int.Parse(Basket_list[row - 1][4]))
            {
                basketTableLayoutPanel.GetControlFromPosition(2, row).BackColor = Color.Red;
            }
            else
            {
                basketTableLayoutPanel.GetControlFromPosition(2, row).BackColor = Color.White;
            } 

            if (Convert.ToInt32(quant.Value) == 0)
            {
                basketTableLayoutPanel.SuspendLayout();

                // delete all controls of row that we want to delete
                for (int i = 0; i < basketTableLayoutPanel.ColumnCount; i++)
                {
                    var control = basketTableLayoutPanel.GetControlFromPosition(i, row);
                    basketTableLayoutPanel.Controls.Remove(control);
                }

                // move up row controls that comes after row we want to remove
                for (int i = row + 1; i < basketTableLayoutPanel.RowCount; i++)
                {
                    for (int j = 0; j < basketTableLayoutPanel.ColumnCount; j++)
                    {
                        var control = basketTableLayoutPanel.GetControlFromPosition(j, i);
                        if (control != null)
                        {
                            basketTableLayoutPanel.SetRow(control, i - 1);

                            if (j > 1)
                            {
                                control.Tag = i - 1;
                            }
                        }
                    }
                }

                var removeStyle = basketTableLayoutPanel.RowCount - 1;

                if (basketTableLayoutPanel.RowStyles.Count > removeStyle)
                    basketTableLayoutPanel.RowStyles.RemoveAt(removeStyle);

                basketTableLayoutPanel.RowCount--;
                totalPrice = totalPrice - (float.Parse(Basket_list[row - 1][3]) * int.Parse(Basket_list[row - 1][5]));
                totalPricelabel.Text = "Total Price: " + totalPrice + " €";
                Basket_list.RemoveAt(row - 1);


                if (basketTableLayoutPanel.RowCount == 1)
                {
                    basketTableLayoutPanel.Visible = false;
                    noItemsLabel.Visible = true;
                    totalPricelabel.Text = "Total Price: 0 €";
                }

                basketTableLayoutPanel.ResumeLayout();
            }
            else if (quant.Value > int.Parse(Basket_list[row - 1][5]))
            {
                totalPrice += float.Parse(Basket_list[row - 1][3]);
                Basket_list[row - 1][5] = quant.Value.ToString();
                totalPricelabel.Text = "Total Price: " + totalPrice + " €";
            }
            else if(quant.Value < int.Parse(Basket_list[row - 1][5]))
            {
                totalPrice -= float.Parse(Basket_list[row - 1][3]);
                Basket_list[row - 1][5] = quant.Value.ToString();
                totalPricelabel.Text = "Total Price: " + totalPrice + " €";
            }
        }
    }
}
