namespace NetsuiteFormApplication
{
    partial class CreateFulfillmentForm
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
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonFulfill = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(154, 267);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 0;
            this.buttonBrowse.Text = "Browse...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(92, 46);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(227, 13);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Enter Sales Order Number or Upload Excel File";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 208);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // buttonFulfill
            // 
            this.buttonFulfill.Location = new System.Drawing.Point(251, 204);
            this.buttonFulfill.Name = "buttonFulfill";
            this.buttonFulfill.Size = new System.Drawing.Size(43, 24);
            this.buttonFulfill.TabIndex = 3;
            this.buttonFulfill.Text = "Fulfill";
            this.buttonFulfill.UseVisualStyleBackColor = true;
            this.buttonFulfill.Click += new System.EventHandler(this.buttonFulfill_Click);
            // 
            // CreateFulfillmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 359);
            this.Controls.Add(this.buttonFulfill);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonBrowse);
            this.Name = "CreateFulfillmentForm";
            this.Text = "FulfillmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonFulfill;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}