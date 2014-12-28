namespace NetsuiteFormApplication
{
    partial class CreateNewBinsForm
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
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.textBoxBinNumber = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.labelBinNumber = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxUpload = new System.Windows.Forms.TextBox();
            this.buttonCreateBins = new System.Windows.Forms.Button();
            this.labelOr = new System.Windows.Forms.Label();
            this.labelUpload = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(111, 31);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(155, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Enter Location and Bin Number";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(51, 82);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(100, 20);
            this.textBoxLocation.TabIndex = 1;
            // 
            // textBoxBinNumber
            // 
            this.textBoxBinNumber.Location = new System.Drawing.Point(180, 82);
            this.textBoxBinNumber.Name = "textBoxBinNumber";
            this.textBoxBinNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxBinNumber.TabIndex = 2;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(296, 79);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(48, 23);
            this.buttonCreate.TabIndex = 3;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // labelBinNumber
            // 
            this.labelBinNumber.AutoSize = true;
            this.labelBinNumber.Location = new System.Drawing.Point(204, 66);
            this.labelBinNumber.Name = "labelBinNumber";
            this.labelBinNumber.Size = new System.Drawing.Size(62, 13);
            this.labelBinNumber.TabIndex = 4;
            this.labelBinNumber.Text = "Bin Number";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(77, 66);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(48, 13);
            this.labelLocation.TabIndex = 5;
            this.labelLocation.Text = "Location";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(130, 247);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 6;
            this.buttonBrowse.Text = "Browse...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textBoxUpload
            // 
            this.textBoxUpload.Location = new System.Drawing.Point(114, 221);
            this.textBoxUpload.Name = "textBoxUpload";
            this.textBoxUpload.Size = new System.Drawing.Size(100, 20);
            this.textBoxUpload.TabIndex = 7;
            // 
            // buttonCreateBins
            // 
            this.buttonCreateBins.Location = new System.Drawing.Point(220, 219);
            this.buttonCreateBins.Name = "buttonCreateBins";
            this.buttonCreateBins.Size = new System.Drawing.Size(71, 23);
            this.buttonCreateBins.TabIndex = 8;
            this.buttonCreateBins.Text = "Create Bins";
            this.buttonCreateBins.UseVisualStyleBackColor = true;
            this.buttonCreateBins.Click += new System.EventHandler(this.buttonCreateBins_Click);
            // 
            // labelOr
            // 
            this.labelOr.AutoSize = true;
            this.labelOr.Location = new System.Drawing.Point(148, 141);
            this.labelOr.Name = "labelOr";
            this.labelOr.Size = new System.Drawing.Size(23, 13);
            this.labelOr.TabIndex = 9;
            this.labelOr.Text = "OR";
            // 
            // labelUpload
            // 
            this.labelUpload.AutoSize = true;
            this.labelUpload.Location = new System.Drawing.Point(136, 192);
            this.labelUpload.Name = "labelUpload";
            this.labelUpload.Size = new System.Drawing.Size(60, 13);
            this.labelUpload.TabIndex = 10;
            this.labelUpload.Text = "Upload File";
            // 
            // CreateNewBinsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 334);
            this.Controls.Add(this.labelUpload);
            this.Controls.Add(this.labelOr);
            this.Controls.Add(this.buttonCreateBins);
            this.Controls.Add(this.textBoxUpload);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelBinNumber);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.textBoxBinNumber);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.labelTitle);
            this.Name = "CreateNewBinsForm";
            this.Text = "CreateNewBins";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.TextBox textBoxBinNumber;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label labelBinNumber;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxUpload;
        private System.Windows.Forms.Button buttonCreateBins;
        private System.Windows.Forms.Label labelOr;
        private System.Windows.Forms.Label labelUpload;
    }
}