namespace GSBCR.Formulaire
{
    partial class frmInfoRapportRegion
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
            this.txtNomVisiteur = new System.Windows.Forms.TextBox();
            this.txtCoefConf = new System.Windows.Forms.TextBox();
            this.txtCodeMed1 = new System.Windows.Forms.TextBox();
            this.txtCodeMed2 = new System.Windows.Forms.TextBox();
            this.txtMotifVisite = new System.Windows.Forms.TextBox();
            this.txtDateVisite = new System.Windows.Forms.TextBox();
            this.txtNomPraticien = new System.Windows.Forms.TextBox();
            this.txtNumPraticien = new System.Windows.Forms.TextBox();
            this.txtNumRapport = new System.Windows.Forms.TextBox();
            this.btnInfoPraticien = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInfoMed1 = new System.Windows.Forms.Button();
            this.btnInfoMed2 = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomVisiteur
            // 
            this.txtNomVisiteur.Location = new System.Drawing.Point(12, 147);
            this.txtNomVisiteur.Name = "txtNomVisiteur";
            this.txtNomVisiteur.Size = new System.Drawing.Size(100, 20);
            this.txtNomVisiteur.TabIndex = 18;
            // 
            // txtCoefConf
            // 
            this.txtCoefConf.Location = new System.Drawing.Point(299, 147);
            this.txtCoefConf.Name = "txtCoefConf";
            this.txtCoefConf.Size = new System.Drawing.Size(100, 20);
            this.txtCoefConf.TabIndex = 19;
            // 
            // txtCodeMed1
            // 
            this.txtCodeMed1.Location = new System.Drawing.Point(299, 179);
            this.txtCodeMed1.Name = "txtCodeMed1";
            this.txtCodeMed1.Size = new System.Drawing.Size(100, 20);
            this.txtCodeMed1.TabIndex = 20;
            // 
            // txtCodeMed2
            // 
            this.txtCodeMed2.Location = new System.Drawing.Point(299, 214);
            this.txtCodeMed2.Name = "txtCodeMed2";
            this.txtCodeMed2.Size = new System.Drawing.Size(100, 20);
            this.txtCodeMed2.TabIndex = 21;
            // 
            // txtMotifVisite
            // 
            this.txtMotifVisite.Location = new System.Drawing.Point(156, 214);
            this.txtMotifVisite.Name = "txtMotifVisite";
            this.txtMotifVisite.Size = new System.Drawing.Size(100, 20);
            this.txtMotifVisite.TabIndex = 22;
            // 
            // txtDateVisite
            // 
            this.txtDateVisite.Location = new System.Drawing.Point(156, 179);
            this.txtDateVisite.Name = "txtDateVisite";
            this.txtDateVisite.Size = new System.Drawing.Size(124, 20);
            this.txtDateVisite.TabIndex = 23;
            // 
            // txtNomPraticien
            // 
            this.txtNomPraticien.Location = new System.Drawing.Point(156, 147);
            this.txtNomPraticien.Name = "txtNomPraticien";
            this.txtNomPraticien.Size = new System.Drawing.Size(100, 20);
            this.txtNomPraticien.TabIndex = 24;
            // 
            // txtNumPraticien
            // 
            this.txtNumPraticien.Location = new System.Drawing.Point(12, 214);
            this.txtNumPraticien.Name = "txtNumPraticien";
            this.txtNumPraticien.Size = new System.Drawing.Size(100, 20);
            this.txtNumPraticien.TabIndex = 25;
            // 
            // txtNumRapport
            // 
            this.txtNumRapport.Location = new System.Drawing.Point(12, 179);
            this.txtNumRapport.Name = "txtNumRapport";
            this.txtNumRapport.Size = new System.Drawing.Size(100, 20);
            this.txtNumRapport.TabIndex = 26;
            // 
            // btnInfoPraticien
            // 
            this.btnInfoPraticien.Location = new System.Drawing.Point(12, 263);
            this.btnInfoPraticien.Name = "btnInfoPraticien";
            this.btnInfoPraticien.Size = new System.Drawing.Size(157, 23);
            this.btnInfoPraticien.TabIndex = 27;
            this.btnInfoPraticien.Text = "Informations sur le praticien";
            this.btnInfoPraticien.UseVisualStyleBackColor = true;
            this.btnInfoPraticien.Click += new System.EventHandler(this.btnInfoPraticien_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GSBCR.Formulaire.Properties.Resources.logo_gsb_300x186;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnInfoMed1
            // 
            this.btnInfoMed1.Location = new System.Drawing.Point(415, 179);
            this.btnInfoMed1.Name = "btnInfoMed1";
            this.btnInfoMed1.Size = new System.Drawing.Size(157, 23);
            this.btnInfoMed1.TabIndex = 28;
            this.btnInfoMed1.Text = "Information médicament";
            this.btnInfoMed1.UseVisualStyleBackColor = true;
            this.btnInfoMed1.Click += new System.EventHandler(this.btnInfoMed1_Click);
            // 
            // btnInfoMed2
            // 
            this.btnInfoMed2.Location = new System.Drawing.Point(415, 211);
            this.btnInfoMed2.Name = "btnInfoMed2";
            this.btnInfoMed2.Size = new System.Drawing.Size(157, 23);
            this.btnInfoMed2.TabIndex = 29;
            this.btnInfoMed2.Text = "Information médicament";
            this.btnInfoMed2.UseVisualStyleBackColor = true;
            this.btnInfoMed2.Click += new System.EventHandler(this.btnInfoMed2_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(200, 263);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(125, 23);
            this.btnQuitter.TabIndex = 30;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // frmInfoRapportRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(609, 298);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnInfoMed2);
            this.Controls.Add(this.btnInfoMed1);
            this.Controls.Add(this.btnInfoPraticien);
            this.Controls.Add(this.txtNumRapport);
            this.Controls.Add(this.txtNumPraticien);
            this.Controls.Add(this.txtNomPraticien);
            this.Controls.Add(this.txtDateVisite);
            this.Controls.Add(this.txtMotifVisite);
            this.Controls.Add(this.txtCodeMed2);
            this.Controls.Add(this.txtCodeMed1);
            this.Controls.Add(this.txtCoefConf);
            this.Controls.Add(this.txtNomVisiteur);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmInfoRapportRegion";
            this.Text = "frmInfoRapportRegion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNomVisiteur;
        private System.Windows.Forms.TextBox txtCoefConf;
        private System.Windows.Forms.TextBox txtCodeMed1;
        private System.Windows.Forms.TextBox txtCodeMed2;
        private System.Windows.Forms.TextBox txtMotifVisite;
        private System.Windows.Forms.TextBox txtDateVisite;
        private System.Windows.Forms.TextBox txtNomPraticien;
        private System.Windows.Forms.TextBox txtNumPraticien;
        private System.Windows.Forms.TextBox txtNumRapport;
        private System.Windows.Forms.Button btnInfoPraticien;
        private System.Windows.Forms.Button btnInfoMed1;
        private System.Windows.Forms.Button btnInfoMed2;
        private System.Windows.Forms.Button btnQuitter;
    }
}