namespace GSBCR.Formulaire
{
    partial class frmConsultRapportRegion
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Dg = new System.Windows.Forms.DataGridView();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.btnQuitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GSBCR.Formulaire.Properties.Resources.logo_gsb_300x186;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Dg
            // 
            this.Dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg.Location = new System.Drawing.Point(12, 153);
            this.Dg.Name = "Dg";
            this.Dg.Size = new System.Drawing.Size(708, 202);
            this.Dg.TabIndex = 17;
            this.Dg.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dg_CellMouseDoubleClick);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(549, 12);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(171, 40);
            this.btnQuitter.TabIndex = 18;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // frmConsultRapportRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(732, 367);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.Dg);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmConsultRapportRegion";
            this.Text = "frmConsultRapportRegion";
            this.Load += new System.EventHandler(this.frmConsultRapportRegion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView Dg;
        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.Button btnQuitter;
    }
}