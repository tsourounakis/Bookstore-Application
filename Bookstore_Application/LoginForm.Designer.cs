namespace Bookstore_Application
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SignUpLoginLabel = new System.Windows.Forms.Label();
            this.EmailLoginTextbox = new System.Windows.Forms.TextBox();
            this.PasswordLoginTextbox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.PasswordLabelLogin = new System.Windows.Forms.Label();
            this.EmailLabelLogin = new System.Windows.Forms.Label();
            this.SignUpPanel = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.EmailSignUpLabel = new System.Windows.Forms.Label();
            this.PasswordConfirmSignUpLabel = new System.Windows.Forms.Label();
            this.PasswordSignUpLabel = new System.Windows.Forms.Label();
            this.SurnameSignUpLabel = new System.Windows.Forms.Label();
            this.NameSignUpLabel = new System.Windows.Forms.Label();
            this.emailSignUpTextBox = new System.Windows.Forms.TextBox();
            this.passwordConfirmSignUpTextbox = new System.Windows.Forms.TextBox();
            this.passwordSignUpTextBox = new System.Windows.Forms.TextBox();
            this.surnameSignUpTextBox = new System.Windows.Forms.TextBox();
            this.nameSignUpTextBox = new System.Windows.Forms.TextBox();
            this.SignUpLabelSignUp = new System.Windows.Forms.Label();
            this.Pictures = new System.Windows.Forms.PictureBox();
            this.LoginPanel.SuspendLayout();
            this.SignUpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pictures)).BeginInit();
            this.SuspendLayout();
            // 
            // SignUpLoginLabel
            // 
            this.SignUpLoginLabel.AutoSize = true;
            this.SignUpLoginLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpLoginLabel.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpLoginLabel.ForeColor = System.Drawing.Color.Azure;
            this.SignUpLoginLabel.Location = new System.Drawing.Point(153, 202);
            this.SignUpLoginLabel.Name = "SignUpLoginLabel";
            this.SignUpLoginLabel.Size = new System.Drawing.Size(58, 20);
            this.SignUpLoginLabel.TabIndex = 4;
            this.SignUpLoginLabel.Text = "sign up";
            this.SignUpLoginLabel.Click += new System.EventHandler(this.SignUpLoginLabel_Click);
            // 
            // EmailLoginTextbox
            // 
            this.EmailLoginTextbox.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLoginTextbox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.EmailLoginTextbox.Location = new System.Drawing.Point(16, 90);
            this.EmailLoginTextbox.Name = "EmailLoginTextbox";
            this.EmailLoginTextbox.Size = new System.Drawing.Size(245, 32);
            this.EmailLoginTextbox.TabIndex = 5;
            this.EmailLoginTextbox.Leave += new System.EventHandler(this.onTextBoxLeave);
            // 
            // PasswordLoginTextbox
            // 
            this.PasswordLoginTextbox.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLoginTextbox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.PasswordLoginTextbox.Location = new System.Drawing.Point(16, 148);
            this.PasswordLoginTextbox.Name = "PasswordLoginTextbox";
            this.PasswordLoginTextbox.PasswordChar = '*';
            this.PasswordLoginTextbox.Size = new System.Drawing.Size(245, 32);
            this.PasswordLoginTextbox.TabIndex = 6;
            this.PasswordLoginTextbox.Leave += new System.EventHandler(this.onTextBoxLeave);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginLabel.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.ForeColor = System.Drawing.Color.Azure;
            this.LoginLabel.Location = new System.Drawing.Point(13, 16);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(75, 31);
            this.LoginLabel.TabIndex = 7;
            this.LoginLabel.Text = "login";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginButton.Location = new System.Drawing.Point(16, 194);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(131, 33);
            this.LoginButton.TabIndex = 9;
            this.LoginButton.Text = "enter";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.Transparent;
            this.LoginPanel.Controls.Add(this.PasswordLabelLogin);
            this.LoginPanel.Controls.Add(this.EmailLabelLogin);
            this.LoginPanel.Controls.Add(this.EmailLoginTextbox);
            this.LoginPanel.Controls.Add(this.LoginButton);
            this.LoginPanel.Controls.Add(this.SignUpLoginLabel);
            this.LoginPanel.Controls.Add(this.LoginLabel);
            this.LoginPanel.Controls.Add(this.PasswordLoginTextbox);
            this.LoginPanel.Location = new System.Drawing.Point(98, 540);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(271, 238);
            this.LoginPanel.TabIndex = 10;
            // 
            // PasswordLabelLogin
            // 
            this.PasswordLabelLogin.AutoSize = true;
            this.PasswordLabelLogin.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabelLogin.ForeColor = System.Drawing.Color.Azure;
            this.PasswordLabelLogin.Location = new System.Drawing.Point(25, 125);
            this.PasswordLabelLogin.Name = "PasswordLabelLogin";
            this.PasswordLabelLogin.Size = new System.Drawing.Size(71, 20);
            this.PasswordLabelLogin.TabIndex = 11;
            this.PasswordLabelLogin.Text = "password";
            // 
            // EmailLabelLogin
            // 
            this.EmailLabelLogin.AutoSize = true;
            this.EmailLabelLogin.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabelLogin.ForeColor = System.Drawing.Color.Azure;
            this.EmailLabelLogin.Location = new System.Drawing.Point(25, 60);
            this.EmailLabelLogin.Name = "EmailLabelLogin";
            this.EmailLabelLogin.Size = new System.Drawing.Size(47, 20);
            this.EmailLabelLogin.TabIndex = 10;
            this.EmailLabelLogin.Text = "email";
            // 
            // SignUpPanel
            // 
            this.SignUpPanel.Controls.Add(this.BackButton);
            this.SignUpPanel.Controls.Add(this.SignUpButton);
            this.SignUpPanel.Controls.Add(this.EmailSignUpLabel);
            this.SignUpPanel.Controls.Add(this.PasswordConfirmSignUpLabel);
            this.SignUpPanel.Controls.Add(this.PasswordSignUpLabel);
            this.SignUpPanel.Controls.Add(this.SurnameSignUpLabel);
            this.SignUpPanel.Controls.Add(this.NameSignUpLabel);
            this.SignUpPanel.Controls.Add(this.emailSignUpTextBox);
            this.SignUpPanel.Controls.Add(this.passwordConfirmSignUpTextbox);
            this.SignUpPanel.Controls.Add(this.passwordSignUpTextBox);
            this.SignUpPanel.Controls.Add(this.surnameSignUpTextBox);
            this.SignUpPanel.Controls.Add(this.nameSignUpTextBox);
            this.SignUpPanel.Controls.Add(this.SignUpLabelSignUp);
            this.SignUpPanel.Location = new System.Drawing.Point(100, 295);
            this.SignUpPanel.Name = "SignUpPanel";
            this.SignUpPanel.Size = new System.Drawing.Size(271, 481);
            this.SignUpPanel.TabIndex = 11;
            this.SignUpPanel.Visible = false;
            this.SignUpPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SignUpPanel_Paint);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackButton.Location = new System.Drawing.Point(156, 435);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(78, 33);
            this.BackButton.TabIndex = 24;
            this.BackButton.Text = "back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.SignUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpButton.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SignUpButton.Location = new System.Drawing.Point(15, 435);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(131, 33);
            this.SignUpButton.TabIndex = 23;
            this.SignUpButton.Text = "sign";
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // EmailSignUpLabel
            // 
            this.EmailSignUpLabel.AutoSize = true;
            this.EmailSignUpLabel.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailSignUpLabel.ForeColor = System.Drawing.Color.Azure;
            this.EmailSignUpLabel.Location = new System.Drawing.Point(16, 360);
            this.EmailSignUpLabel.Name = "EmailSignUpLabel";
            this.EmailSignUpLabel.Size = new System.Drawing.Size(47, 20);
            this.EmailSignUpLabel.TabIndex = 22;
            this.EmailSignUpLabel.Text = "email";
            // 
            // PasswordConfirmSignUpLabel
            // 
            this.PasswordConfirmSignUpLabel.AutoSize = true;
            this.PasswordConfirmSignUpLabel.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordConfirmSignUpLabel.ForeColor = System.Drawing.Color.Azure;
            this.PasswordConfirmSignUpLabel.Location = new System.Drawing.Point(16, 286);
            this.PasswordConfirmSignUpLabel.Name = "PasswordConfirmSignUpLabel";
            this.PasswordConfirmSignUpLabel.Size = new System.Drawing.Size(131, 20);
            this.PasswordConfirmSignUpLabel.TabIndex = 21;
            this.PasswordConfirmSignUpLabel.Text = "confirm password";
            // 
            // PasswordSignUpLabel
            // 
            this.PasswordSignUpLabel.AutoSize = true;
            this.PasswordSignUpLabel.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordSignUpLabel.ForeColor = System.Drawing.Color.Azure;
            this.PasswordSignUpLabel.Location = new System.Drawing.Point(16, 213);
            this.PasswordSignUpLabel.Name = "PasswordSignUpLabel";
            this.PasswordSignUpLabel.Size = new System.Drawing.Size(71, 20);
            this.PasswordSignUpLabel.TabIndex = 20;
            this.PasswordSignUpLabel.Text = "password";
            // 
            // SurnameSignUpLabel
            // 
            this.SurnameSignUpLabel.AutoSize = true;
            this.SurnameSignUpLabel.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameSignUpLabel.ForeColor = System.Drawing.Color.Azure;
            this.SurnameSignUpLabel.Location = new System.Drawing.Point(23, 137);
            this.SurnameSignUpLabel.Name = "SurnameSignUpLabel";
            this.SurnameSignUpLabel.Size = new System.Drawing.Size(68, 20);
            this.SurnameSignUpLabel.TabIndex = 19;
            this.SurnameSignUpLabel.Text = "surname";
            // 
            // NameSignUpLabel
            // 
            this.NameSignUpLabel.AutoSize = true;
            this.NameSignUpLabel.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameSignUpLabel.ForeColor = System.Drawing.Color.Azure;
            this.NameSignUpLabel.Location = new System.Drawing.Point(22, 69);
            this.NameSignUpLabel.Name = "NameSignUpLabel";
            this.NameSignUpLabel.Size = new System.Drawing.Size(46, 20);
            this.NameSignUpLabel.TabIndex = 18;
            this.NameSignUpLabel.Text = "name";
            // 
            // emailSignUpTextBox
            // 
            this.emailSignUpTextBox.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailSignUpTextBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.emailSignUpTextBox.Location = new System.Drawing.Point(14, 383);
            this.emailSignUpTextBox.Name = "emailSignUpTextBox";
            this.emailSignUpTextBox.Size = new System.Drawing.Size(245, 32);
            this.emailSignUpTextBox.TabIndex = 17;
            this.emailSignUpTextBox.Leave += new System.EventHandler(this.onTextBoxLeave);
            // 
            // passwordConfirmSignUpTextbox
            // 
            this.passwordConfirmSignUpTextbox.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordConfirmSignUpTextbox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.passwordConfirmSignUpTextbox.Location = new System.Drawing.Point(14, 309);
            this.passwordConfirmSignUpTextbox.Name = "passwordConfirmSignUpTextbox";
            this.passwordConfirmSignUpTextbox.PasswordChar = '*';
            this.passwordConfirmSignUpTextbox.Size = new System.Drawing.Size(245, 32);
            this.passwordConfirmSignUpTextbox.TabIndex = 16;
            this.passwordConfirmSignUpTextbox.Leave += new System.EventHandler(this.onTextBoxLeave);
            // 
            // passwordSignUpTextBox
            // 
            this.passwordSignUpTextBox.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordSignUpTextBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.passwordSignUpTextBox.Location = new System.Drawing.Point(14, 236);
            this.passwordSignUpTextBox.Name = "passwordSignUpTextBox";
            this.passwordSignUpTextBox.PasswordChar = '*';
            this.passwordSignUpTextBox.Size = new System.Drawing.Size(245, 32);
            this.passwordSignUpTextBox.TabIndex = 15;
            this.passwordSignUpTextBox.Leave += new System.EventHandler(this.onTextBoxLeave);
            // 
            // surnameSignUpTextBox
            // 
            this.surnameSignUpTextBox.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameSignUpTextBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.surnameSignUpTextBox.Location = new System.Drawing.Point(14, 160);
            this.surnameSignUpTextBox.Name = "surnameSignUpTextBox";
            this.surnameSignUpTextBox.Size = new System.Drawing.Size(245, 32);
            this.surnameSignUpTextBox.TabIndex = 14;
            this.surnameSignUpTextBox.Leave += new System.EventHandler(this.onTextBoxLeave);
            // 
            // nameSignUpTextBox
            // 
            this.nameSignUpTextBox.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSignUpTextBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.nameSignUpTextBox.Location = new System.Drawing.Point(14, 92);
            this.nameSignUpTextBox.Name = "nameSignUpTextBox";
            this.nameSignUpTextBox.Size = new System.Drawing.Size(245, 32);
            this.nameSignUpTextBox.TabIndex = 13;
            this.nameSignUpTextBox.Leave += new System.EventHandler(this.onTextBoxLeave);
            // 
            // SignUpLabelSignUp
            // 
            this.SignUpLabelSignUp.AutoSize = true;
            this.SignUpLabelSignUp.BackColor = System.Drawing.Color.Transparent;
            this.SignUpLabelSignUp.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpLabelSignUp.ForeColor = System.Drawing.Color.Azure;
            this.SignUpLabelSignUp.Location = new System.Drawing.Point(23, 26);
            this.SignUpLabelSignUp.Name = "SignUpLabelSignUp";
            this.SignUpLabelSignUp.Size = new System.Drawing.Size(101, 31);
            this.SignUpLabelSignUp.TabIndex = 12;
            this.SignUpLabelSignUp.Text = "sign up";
            // 
            // Pictures
            // 
            this.Pictures.BackgroundImage = global::Bookstore_Application.Properties.Resources.Login;
            this.Pictures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pictures.Location = new System.Drawing.Point(0, 0);
            this.Pictures.Name = "Pictures";
            this.Pictures.Size = new System.Drawing.Size(1232, 803);
            this.Pictures.TabIndex = 0;
            this.Pictures.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 803);
            this.Controls.Add(this.SignUpPanel);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.Pictures);
            this.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.SignUpPanel.ResumeLayout(false);
            this.SignUpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pictures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pictures;
        private System.Windows.Forms.Label SignUpLoginLabel;
        private System.Windows.Forms.TextBox EmailLoginTextbox;
        private System.Windows.Forms.TextBox PasswordLoginTextbox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Label EmailLabelLogin;
        private System.Windows.Forms.Label PasswordLabelLogin;
        private System.Windows.Forms.Panel SignUpPanel;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Label EmailSignUpLabel;
        private System.Windows.Forms.Label PasswordConfirmSignUpLabel;
        private System.Windows.Forms.Label PasswordSignUpLabel;
        private System.Windows.Forms.Label SurnameSignUpLabel;
        private System.Windows.Forms.Label NameSignUpLabel;
        private System.Windows.Forms.TextBox emailSignUpTextBox;
        private System.Windows.Forms.TextBox passwordConfirmSignUpTextbox;
        private System.Windows.Forms.TextBox passwordSignUpTextBox;
        private System.Windows.Forms.TextBox surnameSignUpTextBox;
        private System.Windows.Forms.TextBox nameSignUpTextBox;
        private System.Windows.Forms.Label SignUpLabelSignUp;
        private System.Windows.Forms.Button BackButton;
    }
}

