using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore_Application
{
    public partial class PadForm : Form
    {
        private int mouseX, mouseY, mouseInX, mouseInY;
        private bool mouseDown;
        private string email;

        private string printdoc;

        public List<List<string>> Basket_list { get; set; }


        DBConnection dbconn = new DBConnection("localhost", "bookstore_schema", "root", "root");
        DataTable dt;

        public PadForm(string email, List<List<string>> Basket_list)
        {
            InitializeComponent();
            this.email = email;

            emailPadLabel.Text = email + " Pad";
            coverComboBox.Text = "Hard";

            printPictureBox.Image = ((ToolStrip)(printPreviewDialog.Controls[1])).ImageList.Images[0];
            printPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            printPictureBox.Cursor = Cursors.Hand;

            ToolStripButton toolStrip = new ToolStripButton();
            toolStrip.Image = ((ToolStrip)(printPreviewDialog.Controls[1])).ImageList.Images[0];
            toolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStrip.Click += new System.EventHandler(printPreview_PrintClick);
            ((ToolStrip)printPreviewDialog.Controls[1]).Items.RemoveAt(0);
            ((ToolStrip)printPreviewDialog.Controls[1]).Items.Insert(0, toolStrip);

            this.Basket_list = Basket_list;

        }

        private void printPreview_PrintClick(object sender, EventArgs e)
        {
            try
            {
                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.PrinterSettings = printDialog.PrinterSettings;

                    printDocument.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ToString());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void priceTrackBar_Scroll(object sender, EventArgs e)
        {
            priceLabel.Text = "Price: " + priceTrackBar.Value + " €";
        }

        private void searchPadTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchPadButton_Click(object sender, EventArgs e)
        {
            searchResultsPadFlowLayoutPanel.Controls.Clear();

            string query = "SELECT t1.id AS BookId, title AS Title, author AS Author, edition AS Edition, price AS Price, DATE_FORMAT(`date`,'%Y-%m-%d') AS Date, `description` AS Description, cover AS Cover, critics AS Critics, quantity AS Quantity, rating_sum AS Rating_sum, rating_num AS Rating_num " +
                               "FROM bookstore_schema.books t1 INNER JOIN bookstore_schema.books_extra_info t2 ON t1.id = t2.id WHERE TRUE ";

            string search = string.Empty;
            string date = string.Empty;
            string price = string.Empty;
            string cover = string.Empty;
            string quantity = string.Empty;
            string rate = string.Empty;

            if (!searchPadTextBox.Text.Equals(string.Empty))
            {
                search = "AND (title LIKE '%" + searchPadTextBox.Text + "%' OR author LIKE '%" + searchPadTextBox.Text + "%' OR edition LIKE '%" + searchPadTextBox.Text + "%') ";
            }

            if (fromDateCheckBox.Checked == true)
            {
                date = "AND (date(`date`) = '" + fromDateTimePicker.Text + "') ";
            }

            if (priceCheckBox.Checked == true)
            {
                price = "AND (price <= " + priceTrackBar.Value + ") ";
            }

            if (coverCheckBox.Checked == true)
            {
                cover = "AND (cover = '" + coverComboBox.Text + "') ";
            }

            if (quantityCheckBox.Checked == true)
            {
                quantity = "AND (quantity >= " + quantityNumericUpDown.Value  + ") ";
            }

            if (ratingCheckBox.Checked == true)
            {
                rate = "AND (rating_sum / rating_num >= " + ratingNumericUpDown.Value + ")";
            }

            dt = dbconn.Select(query + search + date + price + cover + quantity + rate + ";");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Label label = new Label();
                label.Name = "bookInfoLabel" + i;
                label.Tag = i;
                label.AutoSize = true;
                label.Text = dt.Rows[i]["Title"].ToString() + ", " + dt.Rows[i]["Author"].ToString() + ", " + dt.Rows[i]["Edition"].ToString() + ", " + dt.Rows[i]["Price"].ToString();
                label.Cursor = Cursors.Hand;
                label.Font = new Font("Arial", 12, FontStyle.Underline);
                label.Margin = new Padding(8, 8, 8, 8);



                label.Click += (s, ev) =>
                {
                    int j = Convert.ToInt32(label.Tag);

                    bookIdValueLabel.Text = dt.Rows[j]["BookId"].ToString();
                    bookTitleValueLabel.Text = dt.Rows[j]["Title"].ToString();
                    bookAuthorValueLabel.Text = dt.Rows[j]["Author"].ToString();
                    bookEditionValueLabel.Text = dt.Rows[j]["Edition"].ToString();
                    bookReleaseDateValueLabel.Text = dt.Rows[j]["Date"].ToString();
                    bookCoverValueLabel.Text = dt.Rows[j]["Cover"].ToString();
                    bookPriceValueLabel.Text = dt.Rows[j]["Price"].ToString();
                    bookQuantityValueLabel.Text = dt.Rows[j]["Quantity"].ToString();
                    bookDescriptionRichTextBox.Text = dt.Rows[j]["Description"].ToString();
                    bookCriticsRichTextBox.Text = dt.Rows[j]["Critics"].ToString();

                    int rating_sum = int.Parse(dt.Rows[j]["Rating_sum"].ToString());
                    int rating_num = int.Parse(dt.Rows[j]["Rating_num"].ToString());

                    string rating;

                    try
                    {
                      rating = (rating_sum / rating_num).ToString();
                    }
                    catch(DivideByZeroException)
                    {
                        rating = "There is no rating for this book yet";
                    }

                    bookRatingValueLabel.Text = rating + "/5";

                    searchOptionsPasPanel.Visible = false;
                    searchResultsPadFlowLayoutPanel.Visible = false;
                    bookInfoPadPanel.Visible = true;
                    backPictureBox.Visible = true;
                };

                searchResultsPadFlowLayoutPanel.Controls.Add(label);
            }

            bookInfoPadPanel.Visible = false;
            searchOptionsPasPanel.Visible = true;
            searchResultsPadFlowLayoutPanel.Visible = true;
        }

        private void backPictureBox_Click(object sender, EventArgs e)
        {
            bookInfoPadPanel.Visible = false;
            searchOptionsPasPanel.Visible = true;
            searchResultsPadFlowLayoutPanel.Visible = true;
            backPictureBox.Visible = false;
            
        }

        private void padBorderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void printButton_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void printPictureBox_Click(object sender, EventArgs e)
        {

            printdoc = bookTitleLabel.Text + bookTitleValueLabel.Text + "\n\n\n" + bookAuthorLabel.Text + bookAuthorValueLabel.Text + "\n\n\n" +
                       bookEditionLabel.Text + bookEditionValueLabel.Text + "\n\n\n" + bookReleaseDateLabel.Text + bookReleaseDateValueLabel.Text + "\n\n\n" +
                       bookCoverLabel.Text + bookCoverValueLabel.Text + "\n\n\n" + bookPriceLabel.Text + bookPriceValueLabel.Text + "\n\n\n" +
                       bookQuantityLabel.Text + bookQuantityValueLabel.Text + "\n\n\n" + bookRatingLabel.Text + bookRatingValueLabel.Text + "\n\n\n" +
                       bookDescriptionLabel.Text + "\n" + bookDescriptionRichTextBox.Text + "\n\n\n" + bookCriticsLabel.Text + "\n" + bookCriticsRichTextBox.Text;

            printPreviewDialog.ShowDialog();                
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(printdoc, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 100));
        }

        private void addToBasketLabel_Click(object sender, EventArgs e)
        {
            int index = Basket_list.FindIndex(item => item[6] == bookIdValueLabel.Text); 
            if(index == -1)
            {

                List<string> bookList = new List<string>();

                bookList.Add(bookTitleValueLabel.Text);
                bookList.Add(bookAuthorValueLabel.Text);
                bookList.Add(bookEditionValueLabel.Text);
                bookList.Add(bookPriceValueLabel.Text);
                bookList.Add(bookQuantityValueLabel.Text);
                bookList.Add("1");
                bookList.Add(bookIdValueLabel.Text);

                Basket_list.Add(bookList);
            }
            else
            {
                Basket_list[index][5] = (int.Parse(Basket_list[index][5]) + 1).ToString();
            }

            MessageBox.Show(bookTitleValueLabel.Text + " added to basket!", "Item Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void bookTitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void padMovePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - mouseInX;
                mouseY = MousePosition.Y - mouseInY;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void padMovePanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void padMovePanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseInX = MousePosition.X - Bounds.X;
            mouseInY = MousePosition.Y - Bounds.Y;

            mouseDown = true;
        }
    }
}
