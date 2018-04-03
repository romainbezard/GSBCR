namespace GSBCR.Formulaire
{
    partial class FrmAjoutRapport
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtDateVisite = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumPraticien = new System.Windows.Forms.TextBox();
            this.cbxNomPraticien = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxMotif = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBilan = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nupCoef = new System.Windows.Forms.NumericUpDown();
            this.txtAutre = new System.Windows.Forms.TextBox();
            this.chbDefinitif = new System.Windows.Forms.CheckBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.txtCodeMotif = new System.Windows.Forms.TextBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVoirMed2 = new System.Windows.Forms.Button();
            this.btnVoirMed1 = new System.Windows.Forms.Button();
            this.txtMed2 = new System.Windows.Forms.TextBox();
            this.txtMed1 = new System.Windows.Forms.TextBox();
            this.cbxMed2 = new System.Windows.Forms.ComboBox();
            this.cbxMed1 = new System.Windows.Forms.ComboBox();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.btnVoirPatricien = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bsPraticien = new System.Windows.Forms.BindingSource(this.components);
            this.bsMotif = new System.Windows.Forms.BindingSource(this.components);
            this.bsMed1 = new System.Windows.Forms.BindingSource(this.components);
            this.bsMed2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nupCoef)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPraticien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMotif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMed1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMed2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numéro de rapport";
            // 
            // txtNum
            // 
            this.txtNum.Enabled = false;
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(257, 136);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 24);
            this.txtNum.TabIndex = 1;
            this.txtNum.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date";
            // 
            // dtDateVisite
            // 
            this.dtDateVisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateVisite.Location = new System.Drawing.Point(138, 166);
            this.dtDateVisite.Name = "dtDateVisite";
            this.dtDateVisite.Size = new System.Drawing.Size(246, 24);
            this.dtDateVisite.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(367, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Praticien visité";
            // 
            // txtNumPraticien
            // 
            this.txtNumPraticien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPraticien.Location = new System.Drawing.Point(632, 139);
            this.txtNumPraticien.Name = "txtNumPraticien";
            this.txtNumPraticien.Size = new System.Drawing.Size(100, 24);
            this.txtNumPraticien.TabIndex = 6;
            this.txtNumPraticien.TabStop = false;
            // 
            // cbxNomPraticien
            // 
            this.cbxNomPraticien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNomPraticien.FormattingEnabled = true;
            this.cbxNomPraticien.Location = new System.Drawing.Point(475, 136);
            this.cbxNomPraticien.Name = "cbxNomPraticien";
            this.cbxNomPraticien.Size = new System.Drawing.Size(151, 26);
            this.cbxNomPraticien.TabIndex = 7;
            this.cbxNomPraticien.SelectedIndexChanged += new System.EventHandler(this.cbxNomPraticien_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Motif";
            // 
            // cbxMotif
            // 
            this.cbxMotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMotif.FormattingEnabled = true;
            this.cbxMotif.Location = new System.Drawing.Point(138, 199);
            this.cbxMotif.Name = "cbxMotif";
            this.cbxMotif.Size = new System.Drawing.Size(191, 26);
            this.cbxMotif.TabIndex = 9;
            this.cbxMotif.SelectedIndexChanged += new System.EventHandler(this.cbxMotif_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(105, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Bilan";
            // 
            // txtBilan
            // 
            this.txtBilan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBilan.Location = new System.Drawing.Point(151, 266);
            this.txtBilan.Name = "txtBilan";
            this.txtBilan.Size = new System.Drawing.Size(581, 68);
            this.txtBilan.TabIndex = 11;
            this.txtBilan.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Coef. confiance";
            // 
            // nupCoef
            // 
            this.nupCoef.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupCoef.Location = new System.Drawing.Point(151, 232);
            this.nupCoef.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nupCoef.Name = "nupCoef";
            this.nupCoef.Size = new System.Drawing.Size(76, 24);
            this.nupCoef.TabIndex = 13;
            // 
            // txtAutre
            // 
            this.txtAutre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutre.Location = new System.Drawing.Point(475, 204);
            this.txtAutre.Name = "txtAutre";
            this.txtAutre.Size = new System.Drawing.Size(257, 24);
            this.txtAutre.TabIndex = 14;
            // 
            // chbDefinitif
            // 
            this.chbDefinitif.AutoSize = true;
            this.chbDefinitif.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbDefinitif.Location = new System.Drawing.Point(21, 474);
            this.chbDefinitif.Name = "chbDefinitif";
            this.chbDefinitif.Size = new System.Drawing.Size(127, 22);
            this.chbDefinitif.TabIndex = 16;
            this.chbDefinitif.Text = "Saisie définitive";
            this.chbDefinitif.UseVisualStyleBackColor = true;
            // 
            // btnValider
            // 
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(440, 474);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(144, 35);
            this.btnValider.TabIndex = 17;
            this.btnValider.Text = "Enregistrer";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // txtCodeMotif
            // 
            this.txtCodeMotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeMotif.Location = new System.Drawing.Point(335, 201);
            this.txtCodeMotif.Name = "txtCodeMotif";
            this.txtCodeMotif.Size = new System.Drawing.Size(49, 24);
            this.txtCodeMotif.TabIndex = 18;
            this.txtCodeMotif.TabStop = false;
            // 
            // btnQuitter
            // 
            this.btnQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(590, 474);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(136, 35);
            this.btnQuitter.TabIndex = 20;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(390, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "Autre Motif";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVoirMed2);
            this.groupBox1.Controls.Add(this.btnVoirMed1);
            this.groupBox1.Controls.Add(this.txtMed2);
            this.groupBox1.Controls.Add(this.txtMed1);
            this.groupBox1.Controls.Add(this.cbxMed2);
            this.groupBox1.Controls.Add(this.cbxMed1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 356);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 99);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Médicaments présentés";
            // 
            // btnVoirMed2
            // 
            this.btnVoirMed2.Location = new System.Drawing.Point(553, 55);
            this.btnVoirMed2.Name = "btnVoirMed2";
            this.btnVoirMed2.Size = new System.Drawing.Size(158, 26);
            this.btnVoirMed2.TabIndex = 5;
            this.btnVoirMed2.Text = "Voir le médicament";
            this.btnVoirMed2.UseVisualStyleBackColor = true;
            this.btnVoirMed2.Click += new System.EventHandler(this.btnVoirMed2_Click);
            // 
            // btnVoirMed1
            // 
            this.btnVoirMed1.Location = new System.Drawing.Point(553, 23);
            this.btnVoirMed1.Name = "btnVoirMed1";
            this.btnVoirMed1.Size = new System.Drawing.Size(158, 26);
            this.btnVoirMed1.TabIndex = 4;
            this.btnVoirMed1.Text = "Voir le médicament";
            this.btnVoirMed1.UseVisualStyleBackColor = true;
            this.btnVoirMed1.Click += new System.EventHandler(this.btnVoirmed1_Click);
            // 
            // txtMed2
            // 
            this.txtMed2.Location = new System.Drawing.Point(366, 57);
            this.txtMed2.Name = "txtMed2";
            this.txtMed2.Size = new System.Drawing.Size(149, 24);
            this.txtMed2.TabIndex = 3;
            this.txtMed2.TabStop = false;
            // 
            // txtMed1
            // 
            this.txtMed1.Location = new System.Drawing.Point(366, 25);
            this.txtMed1.Name = "txtMed1";
            this.txtMed1.Size = new System.Drawing.Size(149, 24);
            this.txtMed1.TabIndex = 2;
            this.txtMed1.TabStop = false;
            // 
            // cbxMed2
            // 
            this.cbxMed2.FormattingEnabled = true;
            this.cbxMed2.Location = new System.Drawing.Point(6, 57);
            this.cbxMed2.Name = "cbxMed2";
            this.cbxMed2.Size = new System.Drawing.Size(322, 26);
            this.cbxMed2.TabIndex = 1;
            this.cbxMed2.SelectedIndexChanged += new System.EventHandler(this.cbxMed2_SelectedIndexChanged);
            // 
            // cbxMed1
            // 
            this.cbxMed1.FormattingEnabled = true;
            this.cbxMed1.Location = new System.Drawing.Point(6, 24);
            this.cbxMed1.Name = "cbxMed1";
            this.cbxMed1.Size = new System.Drawing.Size(322, 26);
            this.cbxMed1.TabIndex = 0;
            this.cbxMed1.SelectedIndexChanged += new System.EventHandler(this.cbxMed1_SelectedIndexChanged);
            // 
            // txtMatricule
            // 
            this.txtMatricule.Enabled = false;
            this.txtMatricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricule.Location = new System.Drawing.Point(138, 136);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(113, 24);
            this.txtMatricule.TabIndex = 23;
            this.txtMatricule.TabStop = false;
            this.txtMatricule.TextChanged += new System.EventHandler(this.txtMatricule_TextChanged);
            // 
            // btnVoirPatricien
            // 
            this.btnVoirPatricien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoirPatricien.Location = new System.Drawing.Point(475, 166);
            this.btnVoirPatricien.Name = "btnVoirPatricien";
            this.btnVoirPatricien.Size = new System.Drawing.Size(121, 34);
            this.btnVoirPatricien.TabIndex = 24;
            this.btnVoirPatricien.Text = "Voir le praticien";
            this.btnVoirPatricien.UseVisualStyleBackColor = true;
            this.btnVoirPatricien.Click += new System.EventHandler(this.btnVoirPatricien_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 74);
            this.label2.TabIndex = 26;
            this.label2.Text = "Ajouter un rapport\r\nde visite";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GSBCR.Formulaire.Properties.Resources.logo_gsb_300x186;
            this.pictureBox1.Location = new System.Drawing.Point(4, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmAjoutRapport
            // 
            this.AcceptButton = this.btnValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CancelButton = this.btnQuitter;
            this.ClientSize = new System.Drawing.Size(744, 524);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVoirPatricien);
            this.Controls.Add(this.txtMatricule);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.txtCodeMotif);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.chbDefinitif);
            this.Controls.Add(this.txtAutre);
            this.Controls.Add(this.nupCoef);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBilan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxMotif);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxNomPraticien);
            this.Controls.Add(this.txtNumPraticien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtDateVisite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label1);
            this.Name = "FrmAjoutRapport";
            this.Text = "Ajouter un rapport de visite";
            this.Load += new System.EventHandler(this.FrmSaisir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupCoef)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPraticien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMotif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMed1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMed2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtDateVisite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumPraticien;
        private System.Windows.Forms.ComboBox cbxNomPraticien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxMotif;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtBilan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nupCoef;
        private System.Windows.Forms.TextBox txtAutre;
        private System.Windows.Forms.CheckBox chbDefinitif;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.BindingSource bsPraticien;
        private System.Windows.Forms.BindingSource bsMotif;
        private System.Windows.Forms.TextBox txtCodeMotif;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMed2;
        private System.Windows.Forms.TextBox txtMed1;
        private System.Windows.Forms.ComboBox cbxMed2;
        private System.Windows.Forms.ComboBox cbxMed1;
        private System.Windows.Forms.BindingSource bsMed1;
        private System.Windows.Forms.BindingSource bsMed2;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbxEch;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQte;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.Button btnVoirMed2;
        private System.Windows.Forms.Button btnVoirMed1;
        private System.Windows.Forms.Button btnVoirPatricien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;

        //private System.Windows.Forms.DataGridViewComboBoxColumn cbxEch;
        //private System.Windows.Forms.DataGridViewTextBoxColumn txtQte;

        public System.Windows.Forms.DataGridViewCellEventHandler dgvOffrir_CellValidated { get; set; }
    }
}