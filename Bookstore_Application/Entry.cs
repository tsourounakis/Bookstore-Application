using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore_Application
{
    public partial class EntryForm : Form
    {
        LoginForm loginForm;
        OrdersForm ordersForm;
        PadForm padForm;
        BasketForm basketForm;
        TypewriterForm typewriterForm;
        helpHelpForm helpForm;

        string name = string.Empty;
        string surname = string.Empty;
        string email = string.Empty;
        string currentState = "Entry";
        string prevState = "Entry";

        bool play = false;

        public List<List<string>> Basket_list { get; set; }

        private int mouseX, mouseY, mouseInX, mouseInY;
        private bool mouseDown;

        public EntryForm(string name, string surname, string email)
        {
            InitializeComponent();
            this.name = name;
            this.surname = surname;
            this.email = email;

            nameLabel.Text = this.name + ' ' + this.surname;
            emailLabel.Text = this.email;

            Basket_list = new List<List<string>>();            
        }

        private void Entry_Load(object sender, EventArgs e)
        {

        }

        private void cartPicturebox_Click(object sender, EventArgs e)
        {
            basketForm = new BasketForm(Basket_list, name, email);

            basketForm.ShowDialog();

            Basket_list = basketForm.Basket_list;
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {
            accountFlowLayoutPanel.Visible = !accountFlowLayoutPanel.Visible;
        }

        private void logoutLabel_Click(object sender, EventArgs e)
        {
            loginForm = new LoginForm();
            this.Dispose();
            loginForm.Show();
        }

        private void ordersLabel_Click(object sender, EventArgs e)
        {
            ordersForm = new OrdersForm(email);

            ordersForm.ShowDialog(this);
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void padPictureBox_Click(object sender, EventArgs e)
        {
            padForm = new PadForm(email, Basket_list);

            padForm.ShowDialog(this);

            Basket_list = padForm.Basket_list;

        }

        private void leftPictureBox_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Bookstore_Application.Properties.Resources.Steps;
            leftPictureBox.Visible = false;
            downPictureBox.Visible = false;
            padPictureBox.Visible = false;
            rightPictureBox.Visible = true;

            currentState = "Steps";
            prevState = "Entry";
        }

        private void upPictureBox_Click(object sender, EventArgs e)
        {
            if (currentState.Equals("Steps"))
            {
                currentState = "Typewriter";
                prevState = "Steps";

                leftPictureBox.Visible = false;
                upPictureBox.Visible = false;
                downPictureBox.Visible = true;
                rightPictureBox.Visible = false;

                padPictureBox.Visible = true;

                this.BackgroundImage = Bookstore_Application.Properties.Resources.typewriter;
                this.Size = new Size(1024, 1100);
                typewriterPanel.Visible = true;
                panel1.Location = new Point(696, 40);
                movePanel.Size = new Size(696, 34);
                padPictureBox.Location = new Point(270, 670);
            }
            else if (currentState.Equals("Entry"))
            {
                currentState = "Piano";
                prevState = "Entry";

                leftPictureBox.Visible = false;
                upPictureBox.Visible = false;
                downPictureBox.Visible = true;
                rightPictureBox.Visible = false;

                padPictureBox.Visible = false;

                this.BackgroundImage = Bookstore_Application.Properties.Resources.piano;
                this.Size = new Size(960, 960);
                panel1.Location = new Point(610, 40);
                pianoPanel.Visible = true;
            }
        }

        private void movePanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseInX = MousePosition.X - Bounds.X;
            mouseInY = MousePosition.Y - Bounds.Y;

            mouseDown = true;
        }

        private void downPictureBox_Click(object sender, EventArgs e)
        {
            if (currentState.Equals("Typewriter"))
            {
                currentState = "Steps";
                prevState = "Typewriter";

                leftPictureBox.Visible = false;
                upPictureBox.Visible = true;
                rightPictureBox.Visible = true;
                downPictureBox.Visible = false;

                padPictureBox.Visible = false;

                this.BackgroundImage = Bookstore_Application.Properties.Resources.Steps;
                this.Size = new Size(1232, 803);
                panel1.Location = new Point(903, 40);

                typewriterPanel.Visible = false;
            }
            else if (currentState.Equals("Piano"))
            {
                currentState = "Entry";
                prevState = "TypeWriter";

                leftPictureBox.Visible = true;
                upPictureBox.Visible = true;
                rightPictureBox.Visible = false;
                downPictureBox.Visible = true;

                padPictureBox.Visible = true;

                this.BackgroundImage = Bookstore_Application.Properties.Resources.Entry;
                this.Size = new Size(1232, 803);
                panel1.Location = new Point(903, 40);
                pianoPanel.Visible = false;
            }
        }

        private void typewriterPanel_Click(object sender, EventArgs e)
        {
            typewriterForm = new TypewriterForm(email, name, surname);

            typewriterForm.ShowDialog();
        }

        private void typewriterPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void helpLabel_Click(object sender, EventArgs e)
        {
            helpForm = new helpHelpForm(name, surname);

            helpForm.ShowDialog();
        }

        private void pianoPanel_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Sound);
            if (play == false)
            {
                player.Play();
            }
            else
            {
                player.Stop();
            }

            play = !play;
        }

        private void rightPictureBox_Click(object sender, EventArgs e)
        {
            if (currentState.Equals("Steps"))
            {
                currentState = "Entry";
                prevState = "Steps";

                leftPictureBox.Visible = true;
                upPictureBox.Visible = true;
                rightPictureBox.Visible = false;
                downPictureBox.Visible = true;

                padPictureBox.Visible = true;
                padPictureBox.Location = new Point(1066, 259);

                this.BackgroundImage = Bookstore_Application.Properties.Resources.Entry;
                this.Size = new Size(1232, 803);
            }
        }

        private void movePanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void movePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - mouseInX;
                mouseY = MousePosition.Y - mouseInY;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }     
    }
}
