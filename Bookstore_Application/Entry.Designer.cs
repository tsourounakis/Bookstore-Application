namespace Bookstore_Application
{
    partial class EntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.helpLabel = new System.Windows.Forms.Label();
            this.accountFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.emailLabel = new System.Windows.Forms.Label();
            this.logoutLabel = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.cartPicturebox = new System.Windows.Forms.PictureBox();
            this.ordersLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.rightPictureBox = new System.Windows.Forms.PictureBox();
            this.upPictureBox = new System.Windows.Forms.PictureBox();
            this.leftPictureBox = new System.Windows.Forms.PictureBox();
            this.downPictureBox = new System.Windows.Forms.PictureBox();
            this.movePanel = new System.Windows.Forms.Panel();
            this.padPictureBox = new System.Windows.Forms.PictureBox();
            this.typewriterPanel = new System.Windows.Forms.Panel();
            this.pianoPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.accountFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.padPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.helpLabel);
            this.panel1.Controls.Add(this.accountFlowLayoutPanel);
            this.panel1.Controls.Add(this.cartPicturebox);
            this.panel1.Controls.Add(this.ordersLabel);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Location = new System.Drawing.Point(903, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 139);
            this.panel1.TabIndex = 1;
            // 
            // helpLabel
            // 
            this.helpLabel.AutoSize = true;
            this.helpLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpLabel.ForeColor = System.Drawing.Color.White;
            this.helpLabel.Location = new System.Drawing.Point(153, 6);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(40, 18);
            this.helpLabel.TabIndex = 5;
            this.helpLabel.Text = "Help";
            this.helpLabel.Click += new System.EventHandler(this.helpLabel_Click);
            // 
            // accountFlowLayoutPanel
            // 
            this.accountFlowLayoutPanel.Controls.Add(this.emailLabel);
            this.accountFlowLayoutPanel.Controls.Add(this.logoutLabel);
            this.accountFlowLayoutPanel.Controls.Add(this.exitLabel);
            this.accountFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.accountFlowLayoutPanel.Location = new System.Drawing.Point(35, 31);
            this.accountFlowLayoutPanel.Name = "accountFlowLayoutPanel";
            this.accountFlowLayoutPanel.Size = new System.Drawing.Size(245, 100);
            this.accountFlowLayoutPanel.TabIndex = 4;
            this.accountFlowLayoutPanel.Visible = false;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.White;
            this.emailLabel.Location = new System.Drawing.Point(3, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(42, 17);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "email";
            // 
            // logoutLabel
            // 
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutLabel.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLabel.ForeColor = System.Drawing.Color.White;
            this.logoutLabel.Location = new System.Drawing.Point(3, 17);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(52, 17);
            this.logoutLabel.TabIndex = 1;
            this.logoutLabel.Text = "Logout";
            this.logoutLabel.Click += new System.EventHandler(this.logoutLabel_Click);
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitLabel.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.White;
            this.exitLabel.Location = new System.Drawing.Point(3, 34);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(35, 17);
            this.exitLabel.TabIndex = 2;
            this.exitLabel.Text = "Exit";
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            // 
            // cartPicturebox
            // 
            this.cartPicturebox.BackColor = System.Drawing.Color.White;
            this.cartPicturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cartPicturebox.Image = global::Bookstore_Application.Properties.Resources.add_to_cart;
            this.cartPicturebox.Location = new System.Drawing.Point(282, 0);
            this.cartPicturebox.Name = "cartPicturebox";
            this.cartPicturebox.Size = new System.Drawing.Size(32, 32);
            this.cartPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cartPicturebox.TabIndex = 3;
            this.cartPicturebox.TabStop = false;
            this.cartPicturebox.Click += new System.EventHandler(this.cartPicturebox_Click);
            // 
            // ordersLabel
            // 
            this.ordersLabel.AutoSize = true;
            this.ordersLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ordersLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersLabel.ForeColor = System.Drawing.Color.White;
            this.ordersLabel.Location = new System.Drawing.Point(212, 6);
            this.ordersLabel.Name = "ordersLabel";
            this.ordersLabel.Size = new System.Drawing.Size(50, 18);
            this.ordersLabel.TabIndex = 2;
            this.ordersLabel.Text = "Orders";
            this.ordersLabel.Click += new System.EventHandler(this.ordersLabel_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nameLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(14, 6);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 18);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // rightPictureBox
            // 
            this.rightPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.rightPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("rightPictureBox.Image")));
            this.rightPictureBox.Location = new System.Drawing.Point(679, 717);
            this.rightPictureBox.Name = "rightPictureBox";
            this.rightPictureBox.Size = new System.Drawing.Size(41, 36);
            this.rightPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rightPictureBox.TabIndex = 2;
            this.rightPictureBox.TabStop = false;
            this.rightPictureBox.Visible = false;
            this.rightPictureBox.Click += new System.EventHandler(this.rightPictureBox_Click);
            // 
            // upPictureBox
            // 
            this.upPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("upPictureBox.Image")));
            this.upPictureBox.Location = new System.Drawing.Point(615, 671);
            this.upPictureBox.Name = "upPictureBox";
            this.upPictureBox.Size = new System.Drawing.Size(36, 41);
            this.upPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.upPictureBox.TabIndex = 3;
            this.upPictureBox.TabStop = false;
            this.upPictureBox.Click += new System.EventHandler(this.upPictureBox_Click);
            // 
            // leftPictureBox
            // 
            this.leftPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("leftPictureBox.Image")));
            this.leftPictureBox.Location = new System.Drawing.Point(546, 717);
            this.leftPictureBox.Name = "leftPictureBox";
            this.leftPictureBox.Size = new System.Drawing.Size(41, 36);
            this.leftPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.leftPictureBox.TabIndex = 4;
            this.leftPictureBox.TabStop = false;
            this.leftPictureBox.Click += new System.EventHandler(this.leftPictureBox_Click);
            // 
            // downPictureBox
            // 
            this.downPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("downPictureBox.Image")));
            this.downPictureBox.Location = new System.Drawing.Point(615, 759);
            this.downPictureBox.Name = "downPictureBox";
            this.downPictureBox.Size = new System.Drawing.Size(36, 41);
            this.downPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.downPictureBox.TabIndex = 5;
            this.downPictureBox.TabStop = false;
            this.downPictureBox.Click += new System.EventHandler(this.downPictureBox_Click);
            // 
            // movePanel
            // 
            this.movePanel.BackColor = System.Drawing.Color.Transparent;
            this.movePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.movePanel.Location = new System.Drawing.Point(0, 0);
            this.movePanel.Name = "movePanel";
            this.movePanel.Size = new System.Drawing.Size(1232, 34);
            this.movePanel.TabIndex = 6;
            this.movePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.movePanel_MouseDown);
            this.movePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.movePanel_MouseMove);
            this.movePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.movePanel_MouseUp);
            // 
            // padPictureBox
            // 
            this.padPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.padPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.padPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("padPictureBox.Image")));
            this.padPictureBox.Location = new System.Drawing.Point(1066, 259);
            this.padPictureBox.Name = "padPictureBox";
            this.padPictureBox.Size = new System.Drawing.Size(46, 64);
            this.padPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.padPictureBox.TabIndex = 7;
            this.padPictureBox.TabStop = false;
            this.padPictureBox.Click += new System.EventHandler(this.padPictureBox_Click);
            // 
            // typewriterPanel
            // 
            this.typewriterPanel.BackColor = System.Drawing.Color.Transparent;
            this.typewriterPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.typewriterPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.typewriterPanel.Location = new System.Drawing.Point(379, 620);
            this.typewriterPanel.Name = "typewriterPanel";
            this.typewriterPanel.Size = new System.Drawing.Size(208, 139);
            this.typewriterPanel.TabIndex = 5;
            this.typewriterPanel.Visible = false;
            this.typewriterPanel.Click += new System.EventHandler(this.typewriterPanel_Click);
            this.typewriterPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.typewriterPanel_Paint);
            // 
            // pianoPanel
            // 
            this.pianoPanel.BackColor = System.Drawing.Color.Transparent;
            this.pianoPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pianoPanel.ForeColor = System.Drawing.Color.Transparent;
            this.pianoPanel.Location = new System.Drawing.Point(201, 550);
            this.pianoPanel.Name = "pianoPanel";
            this.pianoPanel.Size = new System.Drawing.Size(339, 241);
            this.pianoPanel.TabIndex = 8;
            this.pianoPanel.Click += new System.EventHandler(this.pianoPanel_Click);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1232, 803);
            this.Controls.Add(this.pianoPanel);
            this.Controls.Add(this.leftPictureBox);
            this.Controls.Add(this.upPictureBox);
            this.Controls.Add(this.rightPictureBox);
            this.Controls.Add(this.typewriterPanel);
            this.Controls.Add(this.padPictureBox);
            this.Controls.Add(this.downPictureBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.movePanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Modern No. 20", 7.8F);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EntryForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Entry_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.accountFlowLayoutPanel.ResumeLayout(false);
            this.accountFlowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.padPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox cartPicturebox;
        private System.Windows.Forms.Label ordersLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.FlowLayoutPanel accountFlowLayoutPanel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label logoutLabel;
        private System.Windows.Forms.PictureBox rightPictureBox;
        private System.Windows.Forms.PictureBox upPictureBox;
        private System.Windows.Forms.PictureBox leftPictureBox;
        private System.Windows.Forms.PictureBox downPictureBox;
        private System.Windows.Forms.Panel movePanel;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.PictureBox padPictureBox;
        private System.Windows.Forms.Panel typewriterPanel;
        private System.Windows.Forms.Label helpLabel;
        private System.Windows.Forms.Panel pianoPanel;
    }
}