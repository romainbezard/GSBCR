namespace GSBCR.Formulaire
{
    partial class FrmSomResponsable
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
            this.btnConsulterRapportRegionSecteur = new System.Windows.Forms.Button();
            this.btnConsulterListeVisiteurRegion = new System.Windows.Forms.Button();
            this.btnMettreVisiteurDelegue = new System.Windows.Forms.Button();
            this.btnConsulterMedicament = new System.Windows.Forms.Button();
            this.btnConsulterPraticien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsulterRapportRegionSecteur
            // 
            this.btnConsulterRapportRegionSecteur.Location = new System.Drawing.Point(31, 33);
            this.btnConsulterRapportRegionSecteur.Name = "btnConsulterRapportRegionSecteur";
            this.btnConsulterRapportRegionSecteur.Size = new System.Drawing.Size(227, 58);
            this.btnConsulterRapportRegionSecteur.TabIndex = 0;
            this.btnConsulterRapportRegionSecteur.Text = "Consulter les rapports de visite d\'une région de son secteur";
            this.btnConsulterRapportRegionSecteur.UseVisualStyleBackColor = true;
            // 
            // btnConsulterListeVisiteurRegion
            // 
            this.btnConsulterListeVisiteurRegion.Location = new System.Drawing.Point(31, 98);
            this.btnConsulterListeVisiteurRegion.Name = "btnConsulterListeVisiteurRegion";
            this.btnConsulterListeVisiteurRegion.Size = new System.Drawing.Size(227, 52);
            this.btnConsulterListeVisiteurRegion.TabIndex = 1;
            this.btnConsulterListeVisiteurRegion.Text = "Consulter la liste des visiteurs d\'une région de son secteur";
            this.btnConsulterListeVisiteurRegion.UseVisualStyleBackColor = true;
            // 
            // btnMettreVisiteurDelegue
            // 
            this.btnMettreVisiteurDelegue.Location = new System.Drawing.Point(31, 157);
            this.btnMettreVisiteurDelegue.Name = "btnMettreVisiteurDelegue";
            this.btnMettreVisiteurDelegue.Size = new System.Drawing.Size(227, 48);
            this.btnMettreVisiteurDelegue.TabIndex = 2;
            this.btnMettreVisiteurDelegue.Text = "Mettre un visiteur, délégué de région";
            this.btnMettreVisiteurDelegue.UseVisualStyleBackColor = true;
            // 
            // btnConsulterMedicament
            // 
            this.btnConsulterMedicament.Location = new System.Drawing.Point(278, 33);
            this.btnConsulterMedicament.Name = "btnConsulterMedicament";
            this.btnConsulterMedicament.Size = new System.Drawing.Size(211, 58);
            this.btnConsulterMedicament.TabIndex = 3;
            this.btnConsulterMedicament.Text = "Consulter médicament";
            this.btnConsulterMedicament.UseVisualStyleBackColor = true;
            // 
            // btnConsulterPraticien
            // 
            this.btnConsulterPraticien.Location = new System.Drawing.Point(278, 98);
            this.btnConsulterPraticien.Name = "btnConsulterPraticien";
            this.btnConsulterPraticien.Size = new System.Drawing.Size(211, 52);
            this.btnConsulterPraticien.TabIndex = 4;
            this.btnConsulterPraticien.Text = "Consulter praticien";
            this.btnConsulterPraticien.UseVisualStyleBackColor = true;
            // 
            // FrmSomResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 248);
            this.Controls.Add(this.btnConsulterPraticien);
            this.Controls.Add(this.btnConsulterMedicament);
            this.Controls.Add(this.btnMettreVisiteurDelegue);
            this.Controls.Add(this.btnConsulterListeVisiteurRegion);
            this.Controls.Add(this.btnConsulterRapportRegionSecteur);
            this.Name = "FrmSomResponsable";
            this.Text = "Sommaire Responsable";
            this.Load += new System.EventHandler(this.FrmSomResponsable_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsulterRapportRegionSecteur;
        private System.Windows.Forms.Button btnConsulterListeVisiteurRegion;
        private System.Windows.Forms.Button btnMettreVisiteurDelegue;
        private System.Windows.Forms.Button btnConsulterMedicament;
        private System.Windows.Forms.Button btnConsulterPraticien;
    }
}