namespace NetsuiteFormApplication
{
    partial class DeleteFulfillmentForm
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
            this.textBoxOrderNumber = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(152, 54);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(147, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Enter Order Number to Delete";
            // 
            // textBoxOrderNumber
            // 
            this.textBoxOrderNumber.Location = new System.Drawing.Point(155, 188);
            this.textBoxOrderNumber.Name = "textBoxOrderNumber";
            this.textBoxOrderNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxOrderNumber.TabIndex = 1;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(261, 185);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(47, 23);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // DeleteFulfillment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 370);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxOrderNumber);
            this.Controls.Add(this.labelTitle);
            this.Name = "DeleteFulfillment";
            this.Text = "DeleteFulfillment";
            this.Load += new System.EventHandler(this.DeleteFulfillment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxOrderNumber;
        private System.Windows.Forms.Button buttonDelete;
    }
}