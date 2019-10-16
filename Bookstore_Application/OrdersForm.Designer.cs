namespace Bookstore_Application
{
    partial class OrdersForm
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
            this.completedDataGridView = new System.Windows.Forms.DataGridView();
            this.pendingDataGridView = new System.Windows.Forms.DataGridView();
            this.okOrdersButton = new System.Windows.Forms.Button();
            this.ordersPanel = new System.Windows.Forms.Panel();
            this.pendingOrderLabel = new System.Windows.Forms.Label();
            this.copletedOrderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.completedDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pendingDataGridView)).BeginInit();
            this.ordersPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // completedDataGridView
            // 
            this.completedDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.completedDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.completedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.completedDataGridView.Location = new System.Drawing.Point(651, 47);
            this.completedDataGridView.Name = "completedDataGridView";
            this.completedDataGridView.RowTemplate.Height = 24;
            this.completedDataGridView.Size = new System.Drawing.Size(649, 464);
            this.completedDataGridView.TabIndex = 0;
            // 
            // pendingDataGridView
            // 
            this.pendingDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.pendingDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.pendingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pendingDataGridView.Location = new System.Drawing.Point(3, 47);
            this.pendingDataGridView.Name = "pendingDataGridView";
            this.pendingDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.pendingDataGridView.RowTemplate.Height = 24;
            this.pendingDataGridView.Size = new System.Drawing.Size(645, 464);
            this.pendingDataGridView.TabIndex = 1;
            // 
            // okOrdersButton
            // 
            this.okOrdersButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.okOrdersButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okOrdersButton.Location = new System.Drawing.Point(1155, 517);
            this.okOrdersButton.Name = "okOrdersButton";
            this.okOrdersButton.Size = new System.Drawing.Size(136, 30);
            this.okOrdersButton.TabIndex = 2;
            this.okOrdersButton.Text = "OK";
            this.okOrdersButton.UseVisualStyleBackColor = false;
            this.okOrdersButton.Click += new System.EventHandler(this.okOrdersButton_Click);
            // 
            // ordersPanel
            // 
            this.ordersPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ordersPanel.Controls.Add(this.copletedOrderLabel);
            this.ordersPanel.Controls.Add(this.pendingOrderLabel);
            this.ordersPanel.Controls.Add(this.okOrdersButton);
            this.ordersPanel.Controls.Add(this.completedDataGridView);
            this.ordersPanel.Controls.Add(this.pendingDataGridView);
            this.ordersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersPanel.Location = new System.Drawing.Point(0, 0);
            this.ordersPanel.Name = "ordersPanel";
            this.ordersPanel.Size = new System.Drawing.Size(1303, 559);
            this.ordersPanel.TabIndex = 3;
            // 
            // pendingOrderLabel
            // 
            this.pendingOrderLabel.AutoSize = true;
            this.pendingOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.pendingOrderLabel.Location = new System.Drawing.Point(12, 19);
            this.pendingOrderLabel.Name = "pendingOrderLabel";
            this.pendingOrderLabel.Size = new System.Drawing.Size(163, 25);
            this.pendingOrderLabel.TabIndex = 3;
            this.pendingOrderLabel.Text = "Pending Orders";
            // 
            // copletedOrderLabel
            // 
            this.copletedOrderLabel.AutoSize = true;
            this.copletedOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.copletedOrderLabel.Location = new System.Drawing.Point(668, 19);
            this.copletedOrderLabel.Name = "copletedOrderLabel";
            this.copletedOrderLabel.Size = new System.Drawing.Size(188, 25);
            this.copletedOrderLabel.TabIndex = 4;
            this.copletedOrderLabel.Text = "Completed Orders";
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 559);
            this.Controls.Add(this.ordersPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.completedDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pendingDataGridView)).EndInit();
            this.ordersPanel.ResumeLayout(false);
            this.ordersPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView completedDataGridView;
        private System.Windows.Forms.DataGridView pendingDataGridView;
        private System.Windows.Forms.Button okOrdersButton;
        private System.Windows.Forms.Panel ordersPanel;
        private System.Windows.Forms.Label copletedOrderLabel;
        private System.Windows.Forms.Label pendingOrderLabel;
    }
}