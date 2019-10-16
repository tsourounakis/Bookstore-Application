namespace Bookstore_Application
{
    partial class TypewriterForm
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
            this.emailTypewriterLabel = new System.Windows.Forms.Label();
            this.serachTitleLabel = new System.Windows.Forms.Label();
            this.searchTitleButton = new System.Windows.Forms.Button();
            this.criticsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.criticsLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.ratingNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.authosSearchLabel = new System.Windows.Forms.Label();
            this.editionSearchLabel = new System.Windows.Forms.Label();
            this.searchTitleErrorLabel = new System.Windows.Forms.Label();
            this.searchAuthorErrorLabel = new System.Windows.Forms.Label();
            this.searchEditionErrorLabel = new System.Windows.Forms.Label();
            this.searchTitleComboBox = new System.Windows.Forms.ComboBox();
            this.searchAuthorComboBox = new System.Windows.Forms.ComboBox();
            this.searchEditionComboBox = new System.Windows.Forms.ComboBox();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ratingNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // emailTypewriterLabel
            // 
            this.emailTypewriterLabel.AutoSize = true;
            this.emailTypewriterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.emailTypewriterLabel.Location = new System.Drawing.Point(12, 9);
            this.emailTypewriterLabel.Name = "emailTypewriterLabel";
            this.emailTypewriterLabel.Size = new System.Drawing.Size(143, 20);
            this.emailTypewriterLabel.TabIndex = 2;
            this.emailTypewriterLabel.Text = "email typewriter";
            // 
            // serachTitleLabel
            // 
            this.serachTitleLabel.AutoSize = true;
            this.serachTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.serachTitleLabel.Location = new System.Drawing.Point(2, 68);
            this.serachTitleLabel.Name = "serachTitleLabel";
            this.serachTitleLabel.Size = new System.Drawing.Size(50, 18);
            this.serachTitleLabel.TabIndex = 3;
            this.serachTitleLabel.Text = "Title: ";
            // 
            // searchTitleButton
            // 
            this.searchTitleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchTitleButton.Location = new System.Drawing.Point(831, 57);
            this.searchTitleButton.Name = "searchTitleButton";
            this.searchTitleButton.Size = new System.Drawing.Size(113, 35);
            this.searchTitleButton.TabIndex = 4;
            this.searchTitleButton.Text = "Search";
            this.searchTitleButton.UseVisualStyleBackColor = true;
            this.searchTitleButton.Click += new System.EventHandler(this.searchTitleButton_Click);
            // 
            // criticsRichTextBox
            // 
            this.criticsRichTextBox.Location = new System.Drawing.Point(75, 97);
            this.criticsRichTextBox.Name = "criticsRichTextBox";
            this.criticsRichTextBox.Size = new System.Drawing.Size(869, 311);
            this.criticsRichTextBox.TabIndex = 5;
            this.criticsRichTextBox.Text = "";
            // 
            // criticsLabel
            // 
            this.criticsLabel.AutoSize = true;
            this.criticsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.criticsLabel.Location = new System.Drawing.Point(2, 98);
            this.criticsLabel.Name = "criticsLabel";
            this.criticsLabel.Size = new System.Drawing.Size(67, 18);
            this.criticsLabel.TabIndex = 6;
            this.criticsLabel.Text = "Critics: ";
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.confirmButton.Location = new System.Drawing.Point(746, 419);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(96, 35);
            this.confirmButton.TabIndex = 7;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // ratingNumericUpDown
            // 
            this.ratingNumericUpDown.Location = new System.Drawing.Point(75, 427);
            this.ratingNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ratingNumericUpDown.Name = "ratingNumericUpDown";
            this.ratingNumericUpDown.Size = new System.Drawing.Size(153, 22);
            this.ratingNumericUpDown.TabIndex = 8;
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ratingLabel.Location = new System.Drawing.Point(6, 429);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(65, 17);
            this.ratingLabel.TabIndex = 9;
            this.ratingLabel.Text = "Rating: ";
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cancelButton.Location = new System.Drawing.Point(848, 419);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(96, 35);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // authosSearchLabel
            // 
            this.authosSearchLabel.AutoSize = true;
            this.authosSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.authosSearchLabel.Location = new System.Drawing.Point(273, 68);
            this.authosSearchLabel.Name = "authosSearchLabel";
            this.authosSearchLabel.Size = new System.Drawing.Size(67, 18);
            this.authosSearchLabel.TabIndex = 13;
            this.authosSearchLabel.Text = "Author: ";
            // 
            // editionSearchLabel
            // 
            this.editionSearchLabel.AutoSize = true;
            this.editionSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.editionSearchLabel.Location = new System.Drawing.Point(552, 68);
            this.editionSearchLabel.Name = "editionSearchLabel";
            this.editionSearchLabel.Size = new System.Drawing.Size(70, 18);
            this.editionSearchLabel.TabIndex = 14;
            this.editionSearchLabel.Text = "Edition: ";
            // 
            // searchTitleErrorLabel
            // 
            this.searchTitleErrorLabel.AutoSize = true;
            this.searchTitleErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.searchTitleErrorLabel.Location = new System.Drawing.Point(85, 44);
            this.searchTitleErrorLabel.Name = "searchTitleErrorLabel";
            this.searchTitleErrorLabel.Size = new System.Drawing.Size(111, 17);
            this.searchTitleErrorLabel.TabIndex = 15;
            this.searchTitleErrorLabel.Text = "*Title is required";
            this.searchTitleErrorLabel.Visible = false;
            // 
            // searchAuthorErrorLabel
            // 
            this.searchAuthorErrorLabel.AutoSize = true;
            this.searchAuthorErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.searchAuthorErrorLabel.Location = new System.Drawing.Point(357, 44);
            this.searchAuthorErrorLabel.Name = "searchAuthorErrorLabel";
            this.searchAuthorErrorLabel.Size = new System.Drawing.Size(126, 17);
            this.searchAuthorErrorLabel.TabIndex = 16;
            this.searchAuthorErrorLabel.Text = "*Author is required";
            this.searchAuthorErrorLabel.Visible = false;
            // 
            // searchEditionErrorLabel
            // 
            this.searchEditionErrorLabel.AutoSize = true;
            this.searchEditionErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.searchEditionErrorLabel.Location = new System.Drawing.Point(636, 44);
            this.searchEditionErrorLabel.Name = "searchEditionErrorLabel";
            this.searchEditionErrorLabel.Size = new System.Drawing.Size(127, 17);
            this.searchEditionErrorLabel.TabIndex = 17;
            this.searchEditionErrorLabel.Text = "*Edition is required";
            this.searchEditionErrorLabel.Visible = false;
            // 
            // searchTitleComboBox
            // 
            this.searchTitleComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchTitleComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.searchTitleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchTitleComboBox.FormattingEnabled = true;
            this.searchTitleComboBox.Location = new System.Drawing.Point(75, 64);
            this.searchTitleComboBox.MaxDropDownItems = 100;
            this.searchTitleComboBox.Name = "searchTitleComboBox";
            this.searchTitleComboBox.Size = new System.Drawing.Size(192, 24);
            this.searchTitleComboBox.TabIndex = 18;
            // 
            // searchAuthorComboBox
            // 
            this.searchAuthorComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchAuthorComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.searchAuthorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchAuthorComboBox.FormattingEnabled = true;
            this.searchAuthorComboBox.Location = new System.Drawing.Point(346, 64);
            this.searchAuthorComboBox.Name = "searchAuthorComboBox";
            this.searchAuthorComboBox.Size = new System.Drawing.Size(200, 24);
            this.searchAuthorComboBox.TabIndex = 19;
            // 
            // searchEditionComboBox
            // 
            this.searchEditionComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchEditionComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.searchEditionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchEditionComboBox.FormattingEnabled = true;
            this.searchEditionComboBox.Location = new System.Drawing.Point(628, 64);
            this.searchEditionComboBox.Name = "searchEditionComboBox";
            this.searchEditionComboBox.Size = new System.Drawing.Size(197, 24);
            this.searchEditionComboBox.TabIndex = 20;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.clearButton.Location = new System.Drawing.Point(601, 419);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(96, 35);
            this.clearButton.TabIndex = 21;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Visible = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // TypewriterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(956, 463);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.searchEditionComboBox);
            this.Controls.Add(this.searchAuthorComboBox);
            this.Controls.Add(this.searchTitleComboBox);
            this.Controls.Add(this.searchEditionErrorLabel);
            this.Controls.Add(this.searchAuthorErrorLabel);
            this.Controls.Add(this.searchTitleErrorLabel);
            this.Controls.Add(this.editionSearchLabel);
            this.Controls.Add(this.authosSearchLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.ratingNumericUpDown);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.criticsLabel);
            this.Controls.Add(this.criticsRichTextBox);
            this.Controls.Add(this.searchTitleButton);
            this.Controls.Add(this.serachTitleLabel);
            this.Controls.Add(this.emailTypewriterLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TypewriterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.ratingNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label emailTypewriterLabel;
        private System.Windows.Forms.Label serachTitleLabel;
        private System.Windows.Forms.Button searchTitleButton;
        private System.Windows.Forms.RichTextBox criticsRichTextBox;
        private System.Windows.Forms.Label criticsLabel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.NumericUpDown ratingNumericUpDown;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label authosSearchLabel;
        private System.Windows.Forms.Label editionSearchLabel;
        private System.Windows.Forms.Label searchTitleErrorLabel;
        private System.Windows.Forms.Label searchAuthorErrorLabel;
        private System.Windows.Forms.Label searchEditionErrorLabel;
        private System.Windows.Forms.ComboBox searchTitleComboBox;
        private System.Windows.Forms.ComboBox searchAuthorComboBox;
        private System.Windows.Forms.ComboBox searchEditionComboBox;
        private System.Windows.Forms.Button clearButton;
    }
}