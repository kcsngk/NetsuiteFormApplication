namespace NetsuiteFormApplication
{
    partial class MainForm
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonSalesOrders = new System.Windows.Forms.Button();
            this.buttonFulfillOrders = new System.Windows.Forms.Button();
            this.buttonBinManagement = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(213, 47);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(46, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Netsuite";
            // 
            // buttonSalesOrders
            // 
            this.buttonSalesOrders.Location = new System.Drawing.Point(33, 88);
            this.buttonSalesOrders.Name = "buttonSalesOrders";
            this.buttonSalesOrders.Size = new System.Drawing.Size(111, 23);
            this.buttonSalesOrders.TabIndex = 1;
            this.buttonSalesOrders.Text = "Sales Orders";
            this.buttonSalesOrders.UseVisualStyleBackColor = true;
            // 
            // buttonFulfillOrders
            // 
            this.buttonFulfillOrders.Location = new System.Drawing.Point(33, 135);
            this.buttonFulfillOrders.Name = "buttonFulfillOrders";
            this.buttonFulfillOrders.Size = new System.Drawing.Size(111, 23);
            this.buttonFulfillOrders.TabIndex = 2;
            this.buttonFulfillOrders.Text = "Item Fulfillments";
            this.buttonFulfillOrders.UseVisualStyleBackColor = true;
            this.buttonFulfillOrders.Click += new System.EventHandler(this.buttonFulfillOrders_Click);
            // 
            // buttonBinManagement
            // 
            this.buttonBinManagement.Location = new System.Drawing.Point(33, 186);
            this.buttonBinManagement.Name = "buttonBinManagement";
            this.buttonBinManagement.Size = new System.Drawing.Size(111, 23);
            this.buttonBinManagement.TabIndex = 3;
            this.buttonBinManagement.Text = "Bin Management";
            this.buttonBinManagement.UseVisualStyleBackColor = true;
            this.buttonBinManagement.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(33, 233);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 388);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonBinManagement);
            this.Controls.Add(this.buttonFulfillOrders);
            this.Controls.Add(this.buttonSalesOrders);
            this.Controls.Add(this.labelTitle);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonSalesOrders;
        private System.Windows.Forms.Button buttonFulfillOrders;
        private System.Windows.Forms.Button buttonBinManagement;
        private System.Windows.Forms.Button button4;
    }
}

