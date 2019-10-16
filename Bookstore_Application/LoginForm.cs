using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore_Application
{
    public partial class LoginForm : Form
    {
        ToolTip toolTip = new ToolTip();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        DBConnection dbconn = new DBConnection("localhost", "bookstore_schema", "root", "root");
        EntryForm entryForm;

        string message;

        public LoginForm()
        {
            InitializeComponent();    

            toolTip.ShowAlways = true;
            toolTip.Active = false;
            toolTip.UseFading = true;
            toolTip.UseAnimation = true;
            toolTip.IsBalloon = true;
            toolTip.AutoPopDelay = 2000;
            toolTip.InitialDelay = 200;
            toolTip.ReshowDelay = 200;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {        
            LoginPanel.Parent = Pictures;
            LoginPanel.BackColor = Color.Transparent;

            SignUpPanel.Parent = Pictures;
            SignUpPanel.BackColor = Color.Transparent;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (EmailLoginTextbox.Text.Equals("") || PasswordLoginTextbox.Text.Equals(""))
            { 
                toolTip.Active = true;
                toolTip.SetToolTip(this.LoginButton, "Missing Inputs!");
                return;
            }

            if (!IsValidEmail(EmailLoginTextbox.Text))
            {
                toolTip.Active = true;
                toolTip.SetToolTip(this.LoginButton, "Invalid email format!");
                return;
            }

            dt = dbconn.Select("SELECT `users`.`name` AS name, `users`.`surname` AS surname, `users`.`email` AS email, `users`.`password` AS password FROM `bookstore_schema`.`users` WHERE email = '" + EmailLoginTextbox.Text + "' AND password = '" + PasswordLoginTextbox.Text + "';");

            if (dt.Rows.Count == 0)
            {
                toolTip.Active = true;
                toolTip.SetToolTip(this.LoginButton, "Wrong credentials!");
                return;
            }

            entryForm = new EntryForm(dt.Rows[0]["name"].ToString(), dt.Rows[0]["surname"].ToString(), dt.Rows[0]["email"].ToString());
            this.Hide();
            entryForm.Show();
            

        }

        private void onTextBoxLeave(object sender, EventArgs e)
        {
            toolTip.Active = false;
        }

        private void SignUpLoginLabel_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = false;
            SignUpPanel.Visible = true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = true;
            SignUpPanel.Visible = false;
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            foreach (TextBox c in SignUpPanel.Controls.OfType<TextBox>())
            {
                if (c.Text.Equals(""))
                {
                    toolTip.Active = true;
                    toolTip.SetToolTip(this.SignUpButton, "Missing Inputs!");
                    return;

                }
            }

            if (!IsValidEmail(emailSignUpTextBox.Text))
            {
                toolTip.Active = true;
                toolTip.SetToolTip(this.SignUpButton, "Invalid email format!");
                return;
            }

            dt = dbconn.Select("SELECT `users`.`email` AS email FROM `bookstore_schema`.`users` WHERE email = '" + EmailLoginTextbox.Text + "';");

            if (dt.Rows.Count != 0)
            {
                toolTip.Active = true;
                toolTip.SetToolTip(this.SignUpButton, "Email already exists!");
                return;
            }

            if (!passwordSignUpTextBox.Text.Equals(passwordConfirmSignUpTextbox.Text))
            {
                toolTip.Active = true;
                toolTip.SetToolTip(this.SignUpButton, "Wrong password confirmation!");
                return;
            }

            message = dbconn.ExecuteNonQuery("INSERT INTO `bookstore_schema`.`users` (`name`, `surname`, `password`, `email`, `type`) VALUES ('" + nameSignUpTextBox.Text + "', '" + surnameSignUpTextBox.Text + "', '" + passwordSignUpTextBox.Text + "', '" + emailSignUpTextBox.Text + "', 'user');");
            if (!message.Equals("OK"))
            {
                MessageBox.Show("Email already exists!", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            entryForm = new EntryForm(nameSignUpTextBox.Text, surnameSignUpTextBox.Text, emailSignUpTextBox.Text);
            this.Hide();
            entryForm.Show();
        }


        public bool IsValidEmail(string email)
        {
            var regex = new Regex(@"^\s*[\w\-\+_']+(\.[\w\-\+_']+)*\@[A-Za-z0-9]([\w\.-]*[A-Za-z0-9])?\.[A-Za-z][A-Za-z\.]*[A-Za-z]$", RegexOptions.Compiled);
            return regex.IsMatch(email);
        }

        private void SignUpPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
