namespace GSBCR.Formulaire
{
    partial class FrmSomDelegue
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
            this.btnConsulterInfosMedicament = new System.Windows.Forms.Button();
            this.btnConsulterInfosPraticien = new System.Windows.Forms.Button();
            this.btnConsulterRapport = new System.Windows.Forms.Button();
            this.btnModifierRapport = new System.Windows.Forms.Button();
            this.bntNouveauRapport = new System.Windows.Forms.Button();
            this.btnConsulterNvRapRegion = new System.Windows.Forms.Button();
            this.btnConsulterVisiteurRegion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsulterInfosMedicament
            // 
            this.btnConsulterInfosMedicament.Location = new System.Drawing.Point(302, 23);
            this.btnConsulterInfosMedicament.Name = "btnConsulterInfosMedicament";
            this.btnConsulterInfosMedicament.Size = new System.Drawing.Size(227, 60);
            this.btnConsulterInfosMedicament.TabIndex = 9;
            this.btnConsulterInfosMedicament.Text = "Consulter les informations médicaments";
            this.btnConsulterInfosMedicament.UseVisualStyleBackColor = true;
            // 
            // btnConsulterInfosPraticien
            // 
            this.btnConsulterInfosPraticien.Location = new System.Drawing.Point(35, 265);
            this.btnConsulterInfosPraticien.Name = "btnConsulterInfosPraticien";
            this.btnConsulterInfosPraticien.Size = new System.Drawing.Size(239, 59);
            this.btnConsulterInfosPraticien.TabIndex = 8;
            this.btnConsulterInfosPraticien.Text = "Consulter les informations praticiens";
            this.btnConsulterInfosPraticien.UseVisualStyleBackColor = true;
            // 
            // btnConsulterRapport
            // 
            this.btnConsulterRapport.Location = new System.Drawing.Point(35, 185);
            this.btnConsulterRapport.Name = "btnConsulterRapport";
            this.btnConsulterRapport.Size = new System.Drawing.Size(239, 63);
            this.btnConsulterRapport.TabIndex = 7;
            this.btnConsulterRapport.Text = "Consulter les rapports validés";
            this.btnConsulterRapport.UseVisualStyleBackColor = true;
            // 
            // btnModifierRapport
            // 
            this.btnModifierRapport.Location = new System.Drawing.Point(35, 100);
            this.btnModifierRapport.Name = "btnModifierRapport";
            this.btnModifierRapport.Size = new System.Drawing.Size(239, 66);
            this.btnModifierRapport.TabIndex = 6;
            this.btnModifierRapport.Text = "Modifier un rapport en cours";
            this.btnModifierRapport.UseVisualStyleBackColor = true;
            // 
            // bntNouveauRapport
            // 
            this.bntNouveauRapport.Location = new System.Drawing.Point(35, 23);
            this.bntNouveauRapport.Name = "bntNouveauRapport";
            this.bntNouveauRapport.Size = new System.Drawing.Size(239, 60);
            this.bntNouveauRapport.TabIndex = 5;
            this.bntNouveauRapport.Text = "Nouveau rapport de visite";
            this.bntNouveauRapport.UseVisualStyleBackColor = true;
            // 
            // btnConsulterNvRapRegion
            // 
            this.btnConsulterNvRapRegion.Location = new System.Drawing.Point(302, 100);
            this.btnConsulterNvRapRegion.Name = "btnConsulterNvRapRegion";
            this.btnConsulterNvRapRegion.Size = new System.Drawing.Size(227, 66);
            this.btnConsulterNvRapRegion.TabIndex = 10;
            this.btnConsulterNvRapRegion.Text = "Consulter les nouveaux rapports de sa région";
            this.btnConsulterNvRapRegion.UseVisualStyleBackColor = true;
            // 
            // btnConsulterVisiteurRegion
            // 
            this.btnConsulterVisiteurRegion.Location = new System.Drawing.Point(302, 183);
            this.btnConsulterVisiteurRegion.Name = "btnConsulterVisiteurRegion";
            this.btnConsulterVisiteurRegion.Size = new System.Drawing.Size(227, 65);
            this.btnConsulterVisiteurRegion.TabIndex = 11;
            this.btnConsulterVisiteurRegion.Text = "Consulter les visiteurs de sa région";
            this.btnConsulterVisiteurRegion.UseVisualStyleBackColor = true;
            // 
            // FrmSomDelegue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 341);
            this.Controls.Add(this.btnConsulterVisiteurRegion);
            this.Controls.Add(this.btnConsulterNvRapRegion);
            this.Controls.Add(this.btnConsulterInfosMedicament);
            this.Controls.Add(this.btnConsulterInfosPraticien);
            this.Controls.Add(this.btnConsulterRapport);
            this.Controls.Add(this.btnModifierRapport);
            this.Controls.Add(this.bntNouveauRapport);
            this.Name = "FrmSomDelegue";
            this.Text = "Sommaire Délégué";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsulterInfosMedicament;
        private System.Windows.Forms.Button btnConsulterInfosPraticien;
        private System.Windows.Forms.Button btnConsulterRapport;
        private System.Windows.Forms.Button btnModifierRapport;
        private System.Windows.Forms.Button bntNouveauRapport;
        private System.Windows.Forms.Button btnConsulterNvRapRegion;
        private System.Windows.Forms.Button btnConsulterVisiteurRegion;
    }
}