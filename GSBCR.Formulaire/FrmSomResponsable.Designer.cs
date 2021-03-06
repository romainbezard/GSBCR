﻿namespace GSBCR.Formulaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSomResponsable));
            this.btnConsulterRapportRegionSecteur = new System.Windows.Forms.Button();
            this.btnConsulterListeVisiteurRegion = new System.Windows.Forms.Button();
            this.btnMettreVisiteurDelegue = new System.Windows.Forms.Button();
            this.btnConsulterMedicament = new System.Windows.Forms.Button();
            this.btnConsulterPraticien = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNomVisiteur = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsulterRapportRegionSecteur
            // 
            this.btnConsulterRapportRegionSecteur.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnConsulterRapportRegionSecteur.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnConsulterRapportRegionSecteur.FlatAppearance.BorderSize = 2;
            this.btnConsulterRapportRegionSecteur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsulterRapportRegionSecteur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(214)))), ((int)(((byte)(254)))));
            this.btnConsulterRapportRegionSecteur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulterRapportRegionSecteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulterRapportRegionSecteur.Location = new System.Drawing.Point(278, 136);
            this.btnConsulterRapportRegionSecteur.Name = "btnConsulterRapportRegionSecteur";
            this.btnConsulterRapportRegionSecteur.Size = new System.Drawing.Size(234, 67);
            this.btnConsulterRapportRegionSecteur.TabIndex = 0;
            this.btnConsulterRapportRegionSecteur.Text = "Consulter les rapports de visite d\'une région de son secteur";
            this.btnConsulterRapportRegionSecteur.UseVisualStyleBackColor = false;
            this.btnConsulterRapportRegionSecteur.Click += new System.EventHandler(this.btnConsulterRapportRegionSecteur_Click);
            // 
            // btnConsulterListeVisiteurRegion
            // 
            this.btnConsulterListeVisiteurRegion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnConsulterListeVisiteurRegion.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnConsulterListeVisiteurRegion.FlatAppearance.BorderSize = 2;
            this.btnConsulterListeVisiteurRegion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsulterListeVisiteurRegion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(214)))), ((int)(((byte)(254)))));
            this.btnConsulterListeVisiteurRegion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulterListeVisiteurRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulterListeVisiteurRegion.Location = new System.Drawing.Point(278, 220);
            this.btnConsulterListeVisiteurRegion.Name = "btnConsulterListeVisiteurRegion";
            this.btnConsulterListeVisiteurRegion.Size = new System.Drawing.Size(234, 62);
            this.btnConsulterListeVisiteurRegion.TabIndex = 1;
            this.btnConsulterListeVisiteurRegion.Text = "Consulter la liste des visiteurs d\'une région de son secteur";
            this.btnConsulterListeVisiteurRegion.UseVisualStyleBackColor = false;
            this.btnConsulterListeVisiteurRegion.Click += new System.EventHandler(this.btnConsulterListeVisiteurRegion_Click);
            // 
            // btnMettreVisiteurDelegue
            // 
            this.btnMettreVisiteurDelegue.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMettreVisiteurDelegue.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnMettreVisiteurDelegue.FlatAppearance.BorderSize = 2;
            this.btnMettreVisiteurDelegue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnMettreVisiteurDelegue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(214)))), ((int)(((byte)(254)))));
            this.btnMettreVisiteurDelegue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMettreVisiteurDelegue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMettreVisiteurDelegue.Location = new System.Drawing.Point(278, 297);
            this.btnMettreVisiteurDelegue.Name = "btnMettreVisiteurDelegue";
            this.btnMettreVisiteurDelegue.Size = new System.Drawing.Size(234, 59);
            this.btnMettreVisiteurDelegue.TabIndex = 2;
            this.btnMettreVisiteurDelegue.Text = "Mettre un visiteur, délégué de région";
            this.btnMettreVisiteurDelegue.UseVisualStyleBackColor = false;
            this.btnMettreVisiteurDelegue.Click += new System.EventHandler(this.btnMettreVisiteurDelegue_Click);
            // 
            // btnConsulterMedicament
            // 
            this.btnConsulterMedicament.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnConsulterMedicament.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnConsulterMedicament.FlatAppearance.BorderSize = 2;
            this.btnConsulterMedicament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsulterMedicament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(214)))), ((int)(((byte)(254)))));
            this.btnConsulterMedicament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulterMedicament.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulterMedicament.Location = new System.Drawing.Point(278, 371);
            this.btnConsulterMedicament.Name = "btnConsulterMedicament";
            this.btnConsulterMedicament.Size = new System.Drawing.Size(234, 59);
            this.btnConsulterMedicament.TabIndex = 3;
            this.btnConsulterMedicament.Text = "Consulter médicament";
            this.btnConsulterMedicament.UseVisualStyleBackColor = false;
            this.btnConsulterMedicament.Click += new System.EventHandler(this.btnConsulterMedicament_Click);
            // 
            // btnConsulterPraticien
            // 
            this.btnConsulterPraticien.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnConsulterPraticien.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnConsulterPraticien.FlatAppearance.BorderSize = 2;
            this.btnConsulterPraticien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsulterPraticien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(214)))), ((int)(((byte)(254)))));
            this.btnConsulterPraticien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulterPraticien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulterPraticien.Location = new System.Drawing.Point(278, 445);
            this.btnConsulterPraticien.Name = "btnConsulterPraticien";
            this.btnConsulterPraticien.Size = new System.Drawing.Size(234, 56);
            this.btnConsulterPraticien.TabIndex = 4;
            this.btnConsulterPraticien.Text = "Consulter praticien";
            this.btnConsulterPraticien.UseVisualStyleBackColor = false;
            this.btnConsulterPraticien.Click += new System.EventHandler(this.btnConsulterPraticien_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "Responsable";
            // 
            // lblNomVisiteur
            // 
            this.lblNomVisiteur.AutoSize = true;
            this.lblNomVisiteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomVisiteur.Location = new System.Drawing.Point(8, 136);
            this.lblNomVisiteur.Name = "lblNomVisiteur";
            this.lblNomVisiteur.Size = new System.Drawing.Size(68, 20);
            this.lblNomVisiteur.TabIndex = 12;
            this.lblNomVisiteur.Text = "Bonjour,";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Gestion des rapports";
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnexion.Location = new System.Drawing.Point(634, 12);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(107, 34);
            this.btnDeconnexion.TabIndex = 14;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GSBCR.Formulaire.Properties.Resources.logo_gsb_300x186;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDeconnexion.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnDeconnexion.FlatAppearance.BorderSize = 2;
            this.btnDeconnexion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDeconnexion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(214)))), ((int)(((byte)(254)))));
            this.btnDeconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeconnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnexion.Location = new System.Drawing.Point(617, 12);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(124, 40);
            this.btnDeconnexion.TabIndex = 14;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = false;
            // 
            // FrmSomResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(755, 512);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNomVisiteur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnConsulterPraticien);
            this.Controls.Add(this.btnConsulterMedicament);
            this.Controls.Add(this.btnMettreVisiteurDelegue);
            this.Controls.Add(this.btnConsulterListeVisiteurRegion);
            this.Controls.Add(this.btnConsulterRapportRegionSecteur);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmSomResponsable";
            this.Text = "Sommaire Responsable";
            this.Load += new System.EventHandler(this.FrmSomResponsable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsulterRapportRegionSecteur;
        private System.Windows.Forms.Button btnConsulterListeVisiteurRegion;
        private System.Windows.Forms.Button btnMettreVisiteurDelegue;
        private System.Windows.Forms.Button btnConsulterMedicament;
        private System.Windows.Forms.Button btnConsulterPraticien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNomVisiteur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDeconnexion;
    }
}