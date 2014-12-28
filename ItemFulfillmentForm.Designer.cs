namespace NetsuiteFormApplication
{
    partial class ItemFulfillmentForm
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
            this.buttonFulfillOrders = new System.Windows.Forms.Button();
            this.buttonDeleteOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(184, 54);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(81, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Item Fulfillments";
            // 
            // buttonFulfillOrders
            // 
            this.buttonFulfillOrders.Location = new System.Drawing.Point(54, 111);
            this.buttonFulfillOrders.Name = "buttonFulfillOrders";
            this.buttonFulfillOrders.Size = new System.Drawing.Size(94, 23);
            this.buttonFulfillOrders.TabIndex = 1;
            this.buttonFulfillOrders.Text = "Fulfill Orders";
            this.buttonFulfillOrders.UseVisualStyleBackColor = true;
            this.buttonFulfillOrders.Click += new System.EventHandler(this.buttonFulfillOrders_Click);
            // 
            // buttonDeleteOrders
            // 
            this.buttonDeleteOrders.Location = new System.Drawing.Point(54, 166);
            this.buttonDeleteOrders.Name = "buttonDeleteOrders";
            this.buttonDeleteOrders.Size = new System.Drawing.Size(94, 23);
            this.buttonDeleteOrders.TabIndex = 2;
            this.buttonDeleteOrders.Text = "Delete Orders";
            this.buttonDeleteOrders.UseVisualStyleBackColor = true;
            this.buttonDeleteOrders.Click += new System.EventHandler(this.buttonDeleteOrders_Click);
            // 
            // ItemFulfillmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 394);
            this.Controls.Add(this.buttonDeleteOrders);
            this.Controls.Add(this.buttonFulfillOrders);
            this.Controls.Add(this.labelTitle);
            this.Name = "ItemFulfillmentForm";
            this.Text = "ItemFulfillmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonFulfillOrders;
        private System.Windows.Forms.Button buttonDeleteOrders;
    }
}