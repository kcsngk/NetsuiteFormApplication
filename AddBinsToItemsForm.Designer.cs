namespace NetsuiteFormApplication
{
    partial class AddBinsToItemsForm
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
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.textBoxBinNumber = new System.Windows.Forms.TextBox();
            this.textBoxUpload = new System.Windows.Forms.TextBox();
            this.buttonAddBin = new System.Windows.Forms.Button();
            this.buttonAddBins = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelOr = new System.Windows.Forms.Label();
            this.labelUpload = new System.Windows.Forms.Label();
            this.labelBinNumber = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.textBoxSKU = new System.Windows.Forms.TextBox();
            this.labelSKU = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(149, 84);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(100, 20);
            this.textBoxLocation.TabIndex = 0;
            // 
            // textBoxBinNumber
            // 
            this.textBoxBinNumber.Location = new System.Drawing.Point(260, 84);
            this.textBoxBinNumber.Name = "textBoxBinNumber";
            this.textBoxBinNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxBinNumber.TabIndex = 1;
            // 
            // textBoxUpload
            // 
            this.textBoxUpload.Location = new System.Drawing.Point(173, 254);
            this.textBoxUpload.Name = "textBoxUpload";
            this.textBoxUpload.Size = new System.Drawing.Size(117, 20);
            this.textBoxUpload.TabIndex = 2;
            // 
            // buttonAddBin
            // 
            this.buttonAddBin.Location = new System.Drawing.Point(383, 82);
            this.buttonAddBin.Name = "buttonAddBin";
            this.buttonAddBin.Size = new System.Drawing.Size(75, 23);
            this.buttonAddBin.TabIndex = 3;
            this.buttonAddBin.Text = "Add Bin";
            this.buttonAddBin.UseVisualStyleBackColor = true;
            this.buttonAddBin.Click += new System.EventHandler(this.buttonAddBin_Click);
            // 
            // buttonAddBins
            // 
            this.buttonAddBins.Location = new System.Drawing.Point(298, 251);
            this.buttonAddBins.Name = "buttonAddBins";
            this.buttonAddBins.Size = new System.Drawing.Size(75, 23);
            this.buttonAddBins.TabIndex = 4;
            this.buttonAddBins.Text = "Add Bins";
            this.buttonAddBins.UseVisualStyleBackColor = true;
            this.buttonAddBins.Click += new System.EventHandler(this.buttonAddBins_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(200, 280);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(71, 24);
            this.buttonBrowse.TabIndex = 5;
            this.buttonBrowse.Text = "Browse...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(197, 28);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(93, 13);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Add Bins To Items";
            // 
            // labelOr
            // 
            this.labelOr.AutoSize = true;
            this.labelOr.Location = new System.Drawing.Point(226, 157);
            this.labelOr.Name = "labelOr";
            this.labelOr.Size = new System.Drawing.Size(23, 13);
            this.labelOr.TabIndex = 7;
            this.labelOr.Text = "OR";
            // 
            // labelUpload
            // 
            this.labelUpload.AutoSize = true;
            this.labelUpload.Location = new System.Drawing.Point(207, 238);
            this.labelUpload.Name = "labelUpload";
            this.labelUpload.Size = new System.Drawing.Size(60, 13);
            this.labelUpload.TabIndex = 8;
            this.labelUpload.Text = "Upload File";
            // 
            // labelBinNumber
            // 
            this.labelBinNumber.AutoSize = true;
            this.labelBinNumber.Location = new System.Drawing.Point(295, 68);
            this.labelBinNumber.Name = "labelBinNumber";
            this.labelBinNumber.Size = new System.Drawing.Size(35, 13);
            this.labelBinNumber.TabIndex = 9;
            this.labelBinNumber.Text = "Bin #:";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(172, 68);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(51, 13);
            this.labelLocation.TabIndex = 10;
            this.labelLocation.Text = "Location:";
            // 
            // textBoxSKU
            // 
            this.textBoxSKU.Location = new System.Drawing.Point(33, 84);
            this.textBoxSKU.Name = "textBoxSKU";
            this.textBoxSKU.Size = new System.Drawing.Size(100, 20);
            this.textBoxSKU.TabIndex = 11;
            // 
            // labelSKU
            // 
            this.labelSKU.AutoSize = true;
            this.labelSKU.Location = new System.Drawing.Point(69, 68);
            this.labelSKU.Name = "labelSKU";
            this.labelSKU.Size = new System.Drawing.Size(32, 13);
            this.labelSKU.TabIndex = 12;
            this.labelSKU.Text = "SKU:";
            // 
            // AddBinsToItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 437);
            this.Controls.Add(this.labelSKU);
            this.Controls.Add(this.textBoxSKU);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelBinNumber);
            this.Controls.Add(this.labelUpload);
            this.Controls.Add(this.labelOr);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.buttonAddBins);
            this.Controls.Add(this.buttonAddBin);
            this.Controls.Add(this.textBoxUpload);
            this.Controls.Add(this.textBoxBinNumber);
            this.Controls.Add(this.textBoxLocation);
            this.Name = "AddBinsToItemsForm";
            this.Text = "AddBinsToItemsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.TextBox textBoxBinNumber;
        private System.Windows.Forms.TextBox textBoxUpload;
        private System.Windows.Forms.Button buttonAddBin;
        private System.Windows.Forms.Button buttonAddBins;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelOr;
        private System.Windows.Forms.Label labelUpload;
        private System.Windows.Forms.Label labelBinNumber;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.TextBox textBoxSKU;
        private System.Windows.Forms.Label labelSKU;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}