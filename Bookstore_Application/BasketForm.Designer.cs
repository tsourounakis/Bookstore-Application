namespace Bookstore_Application
{
    partial class BasketForm
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
            this.moveBasketPanel = new System.Windows.Forms.Panel();
            this.nameBasketLabel = new System.Windows.Forms.Label();
            this.basketMainPanel = new System.Windows.Forms.Panel();
            this.basketTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.infoLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.removeLabel = new System.Windows.Forms.Label();
            this.totalPricelabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.noItemsLabel = new System.Windows.Forms.Label();
            this.proceedButton = new System.Windows.Forms.Button();
            this.payPanel = new System.Windows.Forms.Panel();
            this.cvvErrorLabel = new System.Windows.Forms.Label();
            this.expiredYearErrorLabel = new System.Windows.Forms.Label();
            this.expiredMonthErrorLabel = new System.Windows.Forms.Label();
            this.creditCardNumberErrorLabel = new System.Windows.Forms.Label();
            this.creditCardErrorLabel = new System.Windows.Forms.Label();
            this.ccvTextBox = new System.Windows.Forms.TextBox();
            this.creditCardNumberTextBox = new System.Windows.Forms.TextBox();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.creditCardComboBox = new System.Windows.Forms.ComboBox();
            this.cvvLabel = new System.Windows.Forms.Label();
            this.expiredYearLabel = new System.Windows.Forms.Label();
            this.expiredMonthLabel = new System.Windows.Forms.Label();
            this.creditCardNumberLabel = new System.Windows.Forms.Label();
            this.creditCardTypeLabel = new System.Windows.Forms.Label();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.moveBasketPanel.SuspendLayout();
            this.basketMainPanel.SuspendLayout();
            this.basketTableLayoutPanel.SuspendLayout();
            this.payPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // moveBasketPanel
            // 
            this.moveBasketPanel.BackColor = System.Drawing.SystemColors.Control;
            this.moveBasketPanel.Controls.Add(this.nameBasketLabel);
            this.moveBasketPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.moveBasketPanel.Location = new System.Drawing.Point(0, 0);
            this.moveBasketPanel.Name = "moveBasketPanel";
            this.moveBasketPanel.Size = new System.Drawing.Size(866, 39);
            this.moveBasketPanel.TabIndex = 0;
            this.moveBasketPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.moveBasketPanel_Paint);
            this.moveBasketPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveBasketPanel_MouseDown);
            this.moveBasketPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveBasketPanel_MouseMove);
            this.moveBasketPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveBasketPanel_MouseUp);
            // 
            // nameBasketLabel
            // 
            this.nameBasketLabel.AutoSize = true;
            this.nameBasketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nameBasketLabel.Location = new System.Drawing.Point(12, 9);
            this.nameBasketLabel.Name = "nameBasketLabel";
            this.nameBasketLabel.Size = new System.Drawing.Size(104, 24);
            this.nameBasketLabel.TabIndex = 0;
            this.nameBasketLabel.Text = "My Basket";
            // 
            // basketMainPanel
            // 
            this.basketMainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.basketMainPanel.Controls.Add(this.basketTableLayoutPanel);
            this.basketMainPanel.Controls.Add(this.totalPricelabel);
            this.basketMainPanel.Controls.Add(this.backButton);
            this.basketMainPanel.Controls.Add(this.noItemsLabel);
            this.basketMainPanel.Controls.Add(this.proceedButton);
            this.basketMainPanel.Location = new System.Drawing.Point(8, 58);
            this.basketMainPanel.Name = "basketMainPanel";
            this.basketMainPanel.Size = new System.Drawing.Size(850, 488);
            this.basketMainPanel.TabIndex = 1;
            // 
            // basketTableLayoutPanel
            // 
            this.basketTableLayoutPanel.AutoScroll = true;
            this.basketTableLayoutPanel.AutoSize = true;
            this.basketTableLayoutPanel.ColumnCount = 4;
            this.basketTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.basketTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.basketTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.basketTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.basketTableLayoutPanel.Controls.Add(this.infoLabel, 0, 0);
            this.basketTableLayoutPanel.Controls.Add(this.priceLabel, 1, 0);
            this.basketTableLayoutPanel.Controls.Add(this.quantityLabel, 2, 0);
            this.basketTableLayoutPanel.Controls.Add(this.removeLabel, 3, 0);
            this.basketTableLayoutPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.basketTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.basketTableLayoutPanel.MaximumSize = new System.Drawing.Size(842, 443);
            this.basketTableLayoutPanel.Name = "basketTableLayoutPanel";
            this.basketTableLayoutPanel.RowCount = 1;
            this.basketTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.basketTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.basketTableLayoutPanel.Size = new System.Drawing.Size(842, 45);
            this.basketTableLayoutPanel.TabIndex = 8;
            this.basketTableLayoutPanel.Visible = false;
            // 
            // infoLabel
            // 
            this.infoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.infoLabel.Location = new System.Drawing.Point(127, 13);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(81, 18);
            this.infoLabel.TabIndex = 6;
            this.infoLabel.Text = "Book Info";
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.priceLabel.Location = new System.Drawing.Point(396, 13);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(47, 18);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.Text = "Price";
            // 
            // quantityLabel
            // 
            this.quantityLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.quantityLabel.Location = new System.Drawing.Point(553, 13);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(70, 18);
            this.quantityLabel.TabIndex = 8;
            this.quantityLabel.Text = "Quantity";
            // 
            // removeLabel
            // 
            this.removeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.removeLabel.AutoSize = true;
            this.removeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.removeLabel.Location = new System.Drawing.Point(722, 13);
            this.removeLabel.Name = "removeLabel";
            this.removeLabel.Size = new System.Drawing.Size(70, 18);
            this.removeLabel.TabIndex = 9;
            this.removeLabel.Text = "Remove";
            // 
            // totalPricelabel
            // 
            this.totalPricelabel.AutoSize = true;
            this.totalPricelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.totalPricelabel.Location = new System.Drawing.Point(280, 458);
            this.totalPricelabel.Name = "totalPricelabel";
            this.totalPricelabel.Size = new System.Drawing.Size(113, 20);
            this.totalPricelabel.TabIndex = 7;
            this.totalPricelabel.Text = "Total Price: ";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.backButton.Location = new System.Drawing.Point(727, 452);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(119, 33);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // noItemsLabel
            // 
            this.noItemsLabel.AutoSize = true;
            this.noItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.noItemsLabel.Location = new System.Drawing.Point(324, 238);
            this.noItemsLabel.Name = "noItemsLabel";
            this.noItemsLabel.Size = new System.Drawing.Size(201, 20);
            this.noItemsLabel.TabIndex = 5;
            this.noItemsLabel.Text = "No Items in the Basket";
            this.noItemsLabel.Visible = false;
            // 
            // proceedButton
            // 
            this.proceedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.proceedButton.Location = new System.Drawing.Point(591, 452);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(130, 33);
            this.proceedButton.TabIndex = 3;
            this.proceedButton.Text = "Proceed";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // payPanel
            // 
            this.payPanel.BackColor = System.Drawing.SystemColors.Control;
            this.payPanel.Controls.Add(this.cvvErrorLabel);
            this.payPanel.Controls.Add(this.expiredYearErrorLabel);
            this.payPanel.Controls.Add(this.expiredMonthErrorLabel);
            this.payPanel.Controls.Add(this.creditCardNumberErrorLabel);
            this.payPanel.Controls.Add(this.creditCardErrorLabel);
            this.payPanel.Controls.Add(this.ccvTextBox);
            this.payPanel.Controls.Add(this.creditCardNumberTextBox);
            this.payPanel.Controls.Add(this.yearComboBox);
            this.payPanel.Controls.Add(this.monthComboBox);
            this.payPanel.Controls.Add(this.creditCardComboBox);
            this.payPanel.Controls.Add(this.cvvLabel);
            this.payPanel.Controls.Add(this.expiredYearLabel);
            this.payPanel.Controls.Add(this.expiredMonthLabel);
            this.payPanel.Controls.Add(this.creditCardNumberLabel);
            this.payPanel.Controls.Add(this.creditCardTypeLabel);
            this.payPanel.Controls.Add(this.cancelbutton);
            this.payPanel.Controls.Add(this.confirmButton);
            this.payPanel.Location = new System.Drawing.Point(4, 45);
            this.payPanel.Name = "payPanel";
            this.payPanel.Size = new System.Drawing.Size(856, 519);
            this.payPanel.TabIndex = 0;
            this.payPanel.Visible = false;
            this.payPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.payPanel_Paint);
            // 
            // cvvErrorLabel
            // 
            this.cvvErrorLabel.AutoSize = true;
            this.cvvErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cvvErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.cvvErrorLabel.Location = new System.Drawing.Point(309, 189);
            this.cvvErrorLabel.Name = "cvvErrorLabel";
            this.cvvErrorLabel.Size = new System.Drawing.Size(131, 18);
            this.cvvErrorLabel.TabIndex = 20;
            this.cvvErrorLabel.Text = "*CVV is required";
            this.cvvErrorLabel.Visible = false;
            // 
            // expiredYearErrorLabel
            // 
            this.expiredYearErrorLabel.AutoSize = true;
            this.expiredYearErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.expiredYearErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.expiredYearErrorLabel.Location = new System.Drawing.Point(324, 152);
            this.expiredYearErrorLabel.Name = "expiredYearErrorLabel";
            this.expiredYearErrorLabel.Size = new System.Drawing.Size(194, 18);
            this.expiredYearErrorLabel.TabIndex = 19;
            this.expiredYearErrorLabel.Text = "*Expired Year is required";
            this.expiredYearErrorLabel.Visible = false;
            // 
            // expiredMonthErrorLabel
            // 
            this.expiredMonthErrorLabel.AutoSize = true;
            this.expiredMonthErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.expiredMonthErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.expiredMonthErrorLabel.Location = new System.Drawing.Point(324, 116);
            this.expiredMonthErrorLabel.Name = "expiredMonthErrorLabel";
            this.expiredMonthErrorLabel.Size = new System.Drawing.Size(207, 18);
            this.expiredMonthErrorLabel.TabIndex = 18;
            this.expiredMonthErrorLabel.Text = "*Expired Month is required";
            this.expiredMonthErrorLabel.Visible = false;
            // 
            // creditCardNumberErrorLabel
            // 
            this.creditCardNumberErrorLabel.AutoSize = true;
            this.creditCardNumberErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.creditCardNumberErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.creditCardNumberErrorLabel.Location = new System.Drawing.Point(535, 82);
            this.creditCardNumberErrorLabel.Name = "creditCardNumberErrorLabel";
            this.creditCardNumberErrorLabel.Size = new System.Drawing.Size(249, 18);
            this.creditCardNumberErrorLabel.TabIndex = 17;
            this.creditCardNumberErrorLabel.Text = "*Credit Card Number is required";
            this.creditCardNumberErrorLabel.Visible = false;
            // 
            // creditCardErrorLabel
            // 
            this.creditCardErrorLabel.AutoSize = true;
            this.creditCardErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.creditCardErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.creditCardErrorLabel.Location = new System.Drawing.Point(403, 45);
            this.creditCardErrorLabel.Name = "creditCardErrorLabel";
            this.creditCardErrorLabel.Size = new System.Drawing.Size(226, 18);
            this.creditCardErrorLabel.TabIndex = 16;
            this.creditCardErrorLabel.Text = "*Credit Card Type is required";
            this.creditCardErrorLabel.Visible = false;
            // 
            // ccvTextBox
            // 
            this.ccvTextBox.Location = new System.Drawing.Point(222, 188);
            this.ccvTextBox.Name = "ccvTextBox";
            this.ccvTextBox.Size = new System.Drawing.Size(81, 22);
            this.ccvTextBox.TabIndex = 15;
            // 
            // creditCardNumberTextBox
            // 
            this.creditCardNumberTextBox.Location = new System.Drawing.Point(222, 80);
            this.creditCardNumberTextBox.Name = "creditCardNumberTextBox";
            this.creditCardNumberTextBox.Size = new System.Drawing.Size(307, 22);
            this.creditCardNumberTextBox.TabIndex = 14;
            // 
            // yearComboBox
            // 
            this.yearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.yearComboBox.Location = new System.Drawing.Point(222, 151);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(96, 24);
            this.yearComboBox.TabIndex = 13;
            // 
            // monthComboBox
            // 
            this.monthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.monthComboBox.Location = new System.Drawing.Point(222, 115);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(96, 24);
            this.monthComboBox.TabIndex = 12;
            // 
            // creditCardComboBox
            // 
            this.creditCardComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.creditCardComboBox.FormattingEnabled = true;
            this.creditCardComboBox.Items.AddRange(new object[] {
            "Visa",
            "MasterCard"});
            this.creditCardComboBox.Location = new System.Drawing.Point(222, 44);
            this.creditCardComboBox.Name = "creditCardComboBox";
            this.creditCardComboBox.Size = new System.Drawing.Size(175, 24);
            this.creditCardComboBox.TabIndex = 11;
            // 
            // cvvLabel
            // 
            this.cvvLabel.AutoSize = true;
            this.cvvLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cvvLabel.Location = new System.Drawing.Point(22, 188);
            this.cvvLabel.Name = "cvvLabel";
            this.cvvLabel.Size = new System.Drawing.Size(107, 20);
            this.cvvLabel.TabIndex = 10;
            this.cvvLabel.Text = "CVV Code: ";
            // 
            // expiredYearLabel
            // 
            this.expiredYearLabel.AutoSize = true;
            this.expiredYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.expiredYearLabel.Location = new System.Drawing.Point(22, 151);
            this.expiredYearLabel.Name = "expiredYearLabel";
            this.expiredYearLabel.Size = new System.Drawing.Size(128, 20);
            this.expiredYearLabel.TabIndex = 9;
            this.expiredYearLabel.Text = "Expired Year: ";
            // 
            // expiredMonthLabel
            // 
            this.expiredMonthLabel.AutoSize = true;
            this.expiredMonthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.expiredMonthLabel.Location = new System.Drawing.Point(22, 115);
            this.expiredMonthLabel.Name = "expiredMonthLabel";
            this.expiredMonthLabel.Size = new System.Drawing.Size(141, 20);
            this.expiredMonthLabel.TabIndex = 8;
            this.expiredMonthLabel.Text = "Expired Month: ";
            // 
            // creditCardNumberLabel
            // 
            this.creditCardNumberLabel.AutoSize = true;
            this.creditCardNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.creditCardNumberLabel.Location = new System.Drawing.Point(22, 80);
            this.creditCardNumberLabel.Name = "creditCardNumberLabel";
            this.creditCardNumberLabel.Size = new System.Drawing.Size(189, 20);
            this.creditCardNumberLabel.TabIndex = 7;
            this.creditCardNumberLabel.Text = "Credit Card Number: ";
            // 
            // creditCardTypeLabel
            // 
            this.creditCardTypeLabel.AutoSize = true;
            this.creditCardTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.creditCardTypeLabel.Location = new System.Drawing.Point(22, 44);
            this.creditCardTypeLabel.Name = "creditCardTypeLabel";
            this.creditCardTypeLabel.Size = new System.Drawing.Size(164, 20);
            this.creditCardTypeLabel.TabIndex = 6;
            this.creditCardTypeLabel.Text = "Credit Card Type: ";
            // 
            // cancelbutton
            // 
            this.cancelbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cancelbutton.Location = new System.Drawing.Point(749, 465);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(101, 33);
            this.cancelbutton.TabIndex = 5;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.confirmButton.Location = new System.Drawing.Point(642, 465);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(101, 33);
            this.confirmButton.TabIndex = 4;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // BasketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(866, 569);
            this.Controls.Add(this.moveBasketPanel);
            this.Controls.Add(this.basketMainPanel);
            this.Controls.Add(this.payPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BasketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.moveBasketPanel.ResumeLayout(false);
            this.moveBasketPanel.PerformLayout();
            this.basketMainPanel.ResumeLayout(false);
            this.basketMainPanel.PerformLayout();
            this.basketTableLayoutPanel.ResumeLayout(false);
            this.basketTableLayoutPanel.PerformLayout();
            this.payPanel.ResumeLayout(false);
            this.payPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel moveBasketPanel;
        private System.Windows.Forms.Panel basketMainPanel;
        private System.Windows.Forms.Button proceedButton;
        private System.Windows.Forms.Panel payPanel;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label nameBasketLabel;
        private System.Windows.Forms.Label noItemsLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label totalPricelabel;
        private System.Windows.Forms.Label creditCardNumberLabel;
        private System.Windows.Forms.Label creditCardTypeLabel;
        private System.Windows.Forms.Label expiredYearLabel;
        private System.Windows.Forms.Label expiredMonthLabel;
        private System.Windows.Forms.Label cvvErrorLabel;
        private System.Windows.Forms.Label expiredYearErrorLabel;
        private System.Windows.Forms.Label expiredMonthErrorLabel;
        private System.Windows.Forms.Label creditCardNumberErrorLabel;
        private System.Windows.Forms.Label creditCardErrorLabel;
        private System.Windows.Forms.TextBox ccvTextBox;
        private System.Windows.Forms.TextBox creditCardNumberTextBox;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.ComboBox creditCardComboBox;
        private System.Windows.Forms.Label cvvLabel;
        private System.Windows.Forms.TableLayoutPanel basketTableLayoutPanel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label removeLabel;
    }
}