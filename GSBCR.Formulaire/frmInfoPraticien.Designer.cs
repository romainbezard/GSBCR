namespace GSBCR.Formulaire
{
    partial class frmInfoPraticien
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPraNum = new System.Windows.Forms.TextBox();
            this.txtPraCoefNot = new System.Windows.Forms.TextBox();
            this.txtPraVille = new System.Windows.Forms.TextBox();
            this.txtPraCP = new System.Windows.Forms.TextBox();
            this.txtPraAddr = new System.Windows.Forms.TextBox();
            this.txtPraPrenom = new System.Windows.Forms.TextBox();
            this.txtPraNom = new System.Windows.Forms.TextBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GSBCR.Formulaire.Properties.Resources.logo_gsb_300x186;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // txtPraNum
            // 
            this.txtPraNum.Location = new System.Drawing.Point(256, 12);
            this.txtPraNum.Name = "txtPraNum";
            this.txtPraNum.Size = new System.Drawing.Size(100, 20);
            this.txtPraNum.TabIndex = 19;
            // 
            // txtPraCoefNot
            // 
            this.txtPraCoefNot.Location = new System.Drawing.Point(451, 101);
            this.txtPraCoefNot.Name = "txtPraCoefNot";
            this.txtPraCoefNot.Size = new System.Drawing.Size(100, 20);
            this.txtPraCoefNot.TabIndex = 21;
            // 
            // txtPraVille
            // 
            this.txtPraVille.Location = new System.Drawing.Point(451, 55);
            this.txtPraVille.Name = "txtPraVille";
            this.txtPraVille.Size = new System.Drawing.Size(100, 20);
            this.txtPraVille.TabIndex = 22;
            // 
            // txtPraCP
            // 
            this.txtPraCP.Location = new System.Drawing.Point(451, 12);
            this.txtPraCP.Name = "txtPraCP";
            this.txtPraCP.Size = new System.Drawing.Size(100, 20);
            this.txtPraCP.TabIndex = 23;
            // 
            // txtPraAddr
            // 
            this.txtPraAddr.Location = new System.Drawing.Point(256, 156);
            this.txtPraAddr.Name = "txtPraAddr";
            this.txtPraAddr.Size = new System.Drawing.Size(100, 20);
            this.txtPraAddr.TabIndex = 24;
            // 
            // txtPraPrenom
            // 
            this.txtPraPrenom.Location = new System.Drawing.Point(256, 101);
            this.txtPraPrenom.Name = "txtPraPrenom";
            this.txtPraPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPraPrenom.TabIndex = 25;
            // 
            // txtPraNom
            // 
            this.txtPraNom.Location = new System.Drawing.Point(256, 55);
            this.txtPraNom.Name = "txtPraNom";
            this.txtPraNom.Size = new System.Drawing.Size(100, 20);
            this.txtPraNom.TabIndex = 26;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(555, 196);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(111, 23);
            this.btnQuitter.TabIndex = 27;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // frmInfoPraticien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(678, 231);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.txtPraNom);
            this.Controls.Add(this.txtPraPrenom);
            this.Controls.Add(this.txtPraAddr);
            this.Controls.Add(this.txtPraCP);
            this.Controls.Add(this.txtPraVille);
            this.Controls.Add(this.txtPraCoefNot);
            this.Controls.Add(this.txtPraNum);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmInfoPraticien";
            this.Text = "frmInfoPraticien";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPraNum;
        private System.Windows.Forms.TextBox txtPraCoefNot;
        private System.Windows.Forms.TextBox txtPraVille;
        private System.Windows.Forms.TextBox txtPraCP;
        private System.Windows.Forms.TextBox txtPraAddr;
        private System.Windows.Forms.TextBox txtPraPrenom;
        private System.Windows.Forms.TextBox txtPraNom;
        private System.Windows.Forms.Button btnQuitter;
    }
}