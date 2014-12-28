namespace NetsuiteFormApplication
{
    partial class BinManagementForm
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
            this.buttonCreateBins = new System.Windows.Forms.Button();
            this.buttonDeleteBins = new System.Windows.Forms.Button();
            this.buttonAddBins = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(160, 40);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(87, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Bin Management";
            // 
            // buttonCreateBins
            // 
            this.buttonCreateBins.Location = new System.Drawing.Point(58, 96);
            this.buttonCreateBins.Name = "buttonCreateBins";
            this.buttonCreateBins.Size = new System.Drawing.Size(97, 23);
            this.buttonCreateBins.TabIndex = 1;
            this.buttonCreateBins.Text = "Create Bins";
            this.buttonCreateBins.UseVisualStyleBackColor = true;
            this.buttonCreateBins.Click += new System.EventHandler(this.buttonCreateBins_Click);
            // 
            // buttonDeleteBins
            // 
            this.buttonDeleteBins.Location = new System.Drawing.Point(58, 144);
            this.buttonDeleteBins.Name = "buttonDeleteBins";
            this.buttonDeleteBins.Size = new System.Drawing.Size(97, 23);
            this.buttonDeleteBins.TabIndex = 2;
            this.buttonDeleteBins.Text = "Delete Bins";
            this.buttonDeleteBins.UseVisualStyleBackColor = true;
            this.buttonDeleteBins.Click += new System.EventHandler(this.buttonDeleteBins_Click);
            // 
            // buttonAddBins
            // 
            this.buttonAddBins.Location = new System.Drawing.Point(58, 193);
            this.buttonAddBins.Name = "buttonAddBins";
            this.buttonAddBins.Size = new System.Drawing.Size(97, 23);
            this.buttonAddBins.TabIndex = 3;
            this.buttonAddBins.Text = "Add Bins to Items";
            this.buttonAddBins.UseVisualStyleBackColor = true;
            // 
            // BinManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 362);
            this.Controls.Add(this.buttonAddBins);
            this.Controls.Add(this.buttonDeleteBins);
            this.Controls.Add(this.buttonCreateBins);
            this.Controls.Add(this.labelTitle);
            this.Name = "BinManagementForm";
            this.Text = "BinManagement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonCreateBins;
        private System.Windows.Forms.Button buttonDeleteBins;
        private System.Windows.Forms.Button buttonAddBins;
    }
}