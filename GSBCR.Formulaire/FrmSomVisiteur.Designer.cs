namespace GSBCR.Formulaire
{
    partial class FrmSomVisiteur
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
            this.bntNouveauRapport = new System.Windows.Forms.Button();
            this.btnModifierRapport = new System.Windows.Forms.Button();
            this.btnConsulterRapport = new System.Windows.Forms.Button();
            this.btnConsulterInfosPraticien = new System.Windows.Forms.Button();
            this.btnConsulterInfosMedicament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntNouveauRapport
            // 
            this.bntNouveauRapport.Location = new System.Drawing.Point(24, 19);
            this.bntNouveauRapport.Name = "bntNouveauRapport";
            this.bntNouveauRapport.Size = new System.Drawing.Size(239, 60);
            this.bntNouveauRapport.TabIndex = 0;
            this.bntNouveauRapport.Text = "Nouveau rapport de visite";
            this.bntNouveauRapport.UseVisualStyleBackColor = true;
            // 
            // btnModifierRapport
            // 
            this.btnModifierRapport.Location = new System.Drawing.Point(24, 96);
            this.btnModifierRapport.Name = "btnModifierRapport";
            this.btnModifierRapport.Size = new System.Drawing.Size(239, 66);
            this.btnModifierRapport.TabIndex = 1;
            this.btnModifierRapport.Text = "Modifier un rapport en cours";
            this.btnModifierRapport.UseVisualStyleBackColor = true;
            // 
            // btnConsulterRapport
            // 
            this.btnConsulterRapport.Location = new System.Drawing.Point(24, 181);
            this.btnConsulterRapport.Name = "btnConsulterRapport";
            this.btnConsulterRapport.Size = new System.Drawing.Size(239, 63);
            this.btnConsulterRapport.TabIndex = 2;
            this.btnConsulterRapport.Text = "Consulter les rapports validés";
            this.btnConsulterRapport.UseVisualStyleBackColor = true;
            // 
            // btnConsulterInfosPraticien
            // 
            this.btnConsulterInfosPraticien.Location = new System.Drawing.Point(292, 20);
            this.btnConsulterInfosPraticien.Name = "btnConsulterInfosPraticien";
            this.btnConsulterInfosPraticien.Size = new System.Drawing.Size(239, 59);
            this.btnConsulterInfosPraticien.TabIndex = 3;
            this.btnConsulterInfosPraticien.Text = "Consulter les informations praticiens";
            this.btnConsulterInfosPraticien.UseVisualStyleBackColor = true;
            // 
            // btnConsulterInfosMedicament
            // 
            this.btnConsulterInfosMedicament.Location = new System.Drawing.Point(292, 96);
            this.btnConsulterInfosMedicament.Name = "btnConsulterInfosMedicament";
            this.btnConsulterInfosMedicament.Size = new System.Drawing.Size(239, 66);
            this.btnConsulterInfosMedicament.TabIndex = 4;
            this.btnConsulterInfosMedicament.Text = "Consulter les informations médicaments";
            this.btnConsulterInfosMedicament.UseVisualStyleBackColor = true;
            // 
            // FrmSomVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 266);
            this.Controls.Add(this.btnConsulterInfosMedicament);
            this.Controls.Add(this.btnConsulterInfosPraticien);
            this.Controls.Add(this.btnConsulterRapport);
            this.Controls.Add(this.btnModifierRapport);
            this.Controls.Add(this.bntNouveauRapport);
            this.Name = "FrmSomVisiteur";
            this.Text = "Sommaire Visiteur";
            this.Load += new System.EventHandler(this.FrmSomVisiteur_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntNouveauRapport;
        private System.Windows.Forms.Button btnModifierRapport;
        private System.Windows.Forms.Button btnConsulterRapport;
        private System.Windows.Forms.Button btnConsulterInfosPraticien;
        private System.Windows.Forms.Button btnConsulterInfosMedicament;
    }
}