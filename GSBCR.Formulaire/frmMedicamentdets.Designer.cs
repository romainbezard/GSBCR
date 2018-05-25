namespace GSBCR.Formulaire
{
    partial class frmMedicamentdets
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.bsmedicament = new System.Windows.Forms.BindingSource(this.components);
            this.mEDDEPOTLEGALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEDNOMCOMMERCIALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fAMCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEDCOMPOSITIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEDEFFETSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEDCONTREINDICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEDPRIXECHANTILLONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laFamilleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lesRapports1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lesRapports2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEDDEPOTLEGALDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEDNOMCOMMERCIALDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fAMCODEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEDCOMPOSITIONDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEDEFFETSDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEDCONTREINDICDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEDPRIXECHANTILLONDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laFamilleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lesRapports1DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lesRapports2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsmedicament2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsmedicament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsmedicament2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GSBCR.Formulaire.Properties.Resources.logo_gsb_300x186;
            this.pictureBox1.Location = new System.Drawing.Point(22, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Détail des médicaments";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mEDDEPOTLEGALDataGridViewTextBoxColumn,
            this.mEDNOMCOMMERCIALDataGridViewTextBoxColumn,
            this.fAMCODEDataGridViewTextBoxColumn,
            this.mEDCOMPOSITIONDataGridViewTextBoxColumn,
            this.mEDEFFETSDataGridViewTextBoxColumn,
            this.mEDCONTREINDICDataGridViewTextBoxColumn,
            this.mEDPRIXECHANTILLONDataGridViewTextBoxColumn,
            this.laFamilleDataGridViewTextBoxColumn,
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn,
            this.lesRapports1DataGridViewTextBoxColumn,
            this.lesRapports2DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsmedicament;
            this.dataGridView1.Location = new System.Drawing.Point(114, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mEDDEPOTLEGALDataGridViewTextBoxColumn1,
            this.mEDNOMCOMMERCIALDataGridViewTextBoxColumn1,
            this.fAMCODEDataGridViewTextBoxColumn1,
            this.mEDCOMPOSITIONDataGridViewTextBoxColumn1,
            this.mEDEFFETSDataGridViewTextBoxColumn1,
            this.mEDCONTREINDICDataGridViewTextBoxColumn1,
            this.mEDPRIXECHANTILLONDataGridViewTextBoxColumn1,
            this.laFamilleDataGridViewTextBoxColumn1,
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn1,
            this.lesRapports1DataGridViewTextBoxColumn1,
            this.lesRapports2DataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.bsmedicament2;
            this.dataGridView2.Location = new System.Drawing.Point(114, 325);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(646, 150);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(772, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bsmedicament
            // 
            this.bsmedicament.DataSource = typeof(GSBCR.modele.MEDICAMENT);
            // 
            // mEDDEPOTLEGALDataGridViewTextBoxColumn
            // 
            this.mEDDEPOTLEGALDataGridViewTextBoxColumn.DataPropertyName = "MED_DEPOTLEGAL";
            this.mEDDEPOTLEGALDataGridViewTextBoxColumn.HeaderText = "MED_DEPOTLEGAL";
            this.mEDDEPOTLEGALDataGridViewTextBoxColumn.Name = "mEDDEPOTLEGALDataGridViewTextBoxColumn";
            // 
            // mEDNOMCOMMERCIALDataGridViewTextBoxColumn
            // 
            this.mEDNOMCOMMERCIALDataGridViewTextBoxColumn.DataPropertyName = "MED_NOMCOMMERCIAL";
            this.mEDNOMCOMMERCIALDataGridViewTextBoxColumn.HeaderText = "MED_NOMCOMMERCIAL";
            this.mEDNOMCOMMERCIALDataGridViewTextBoxColumn.Name = "mEDNOMCOMMERCIALDataGridViewTextBoxColumn";
            // 
            // fAMCODEDataGridViewTextBoxColumn
            // 
            this.fAMCODEDataGridViewTextBoxColumn.DataPropertyName = "FAM_CODE";
            this.fAMCODEDataGridViewTextBoxColumn.HeaderText = "FAM_CODE";
            this.fAMCODEDataGridViewTextBoxColumn.Name = "fAMCODEDataGridViewTextBoxColumn";
            // 
            // mEDCOMPOSITIONDataGridViewTextBoxColumn
            // 
            this.mEDCOMPOSITIONDataGridViewTextBoxColumn.DataPropertyName = "MED_COMPOSITION";
            this.mEDCOMPOSITIONDataGridViewTextBoxColumn.HeaderText = "MED_COMPOSITION";
            this.mEDCOMPOSITIONDataGridViewTextBoxColumn.Name = "mEDCOMPOSITIONDataGridViewTextBoxColumn";
            // 
            // mEDEFFETSDataGridViewTextBoxColumn
            // 
            this.mEDEFFETSDataGridViewTextBoxColumn.DataPropertyName = "MED_EFFETS";
            this.mEDEFFETSDataGridViewTextBoxColumn.HeaderText = "MED_EFFETS";
            this.mEDEFFETSDataGridViewTextBoxColumn.Name = "mEDEFFETSDataGridViewTextBoxColumn";
            // 
            // mEDCONTREINDICDataGridViewTextBoxColumn
            // 
            this.mEDCONTREINDICDataGridViewTextBoxColumn.DataPropertyName = "MED_CONTREINDIC";
            this.mEDCONTREINDICDataGridViewTextBoxColumn.HeaderText = "MED_CONTREINDIC";
            this.mEDCONTREINDICDataGridViewTextBoxColumn.Name = "mEDCONTREINDICDataGridViewTextBoxColumn";
            // 
            // mEDPRIXECHANTILLONDataGridViewTextBoxColumn
            // 
            this.mEDPRIXECHANTILLONDataGridViewTextBoxColumn.DataPropertyName = "MED_PRIXECHANTILLON";
            this.mEDPRIXECHANTILLONDataGridViewTextBoxColumn.HeaderText = "MED_PRIXECHANTILLON";
            this.mEDPRIXECHANTILLONDataGridViewTextBoxColumn.Name = "mEDPRIXECHANTILLONDataGridViewTextBoxColumn";
            this.mEDPRIXECHANTILLONDataGridViewTextBoxColumn.Visible = false;
            // 
            // laFamilleDataGridViewTextBoxColumn
            // 
            this.laFamilleDataGridViewTextBoxColumn.DataPropertyName = "LaFamille";
            this.laFamilleDataGridViewTextBoxColumn.HeaderText = "LaFamille";
            this.laFamilleDataGridViewTextBoxColumn.Name = "laFamilleDataGridViewTextBoxColumn";
            this.laFamilleDataGridViewTextBoxColumn.Visible = false;
            // 
            // lesEchantillonsOffertsDataGridViewTextBoxColumn
            // 
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn.DataPropertyName = "LesEchantillonsOfferts";
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn.HeaderText = "LesEchantillonsOfferts";
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn.Name = "lesEchantillonsOffertsDataGridViewTextBoxColumn";
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn.Visible = false;
            // 
            // lesRapports1DataGridViewTextBoxColumn
            // 
            this.lesRapports1DataGridViewTextBoxColumn.DataPropertyName = "LesRapports1";
            this.lesRapports1DataGridViewTextBoxColumn.HeaderText = "LesRapports1";
            this.lesRapports1DataGridViewTextBoxColumn.Name = "lesRapports1DataGridViewTextBoxColumn";
            this.lesRapports1DataGridViewTextBoxColumn.Visible = false;
            // 
            // lesRapports2DataGridViewTextBoxColumn
            // 
            this.lesRapports2DataGridViewTextBoxColumn.DataPropertyName = "LesRapports2";
            this.lesRapports2DataGridViewTextBoxColumn.HeaderText = "LesRapports2";
            this.lesRapports2DataGridViewTextBoxColumn.Name = "lesRapports2DataGridViewTextBoxColumn";
            this.lesRapports2DataGridViewTextBoxColumn.Visible = false;
            // 
            // mEDDEPOTLEGALDataGridViewTextBoxColumn1
            // 
            this.mEDDEPOTLEGALDataGridViewTextBoxColumn1.DataPropertyName = "MED_DEPOTLEGAL";
            this.mEDDEPOTLEGALDataGridViewTextBoxColumn1.HeaderText = "MED_DEPOTLEGAL";
            this.mEDDEPOTLEGALDataGridViewTextBoxColumn1.Name = "mEDDEPOTLEGALDataGridViewTextBoxColumn1";
            // 
            // mEDNOMCOMMERCIALDataGridViewTextBoxColumn1
            // 
            this.mEDNOMCOMMERCIALDataGridViewTextBoxColumn1.DataPropertyName = "MED_NOMCOMMERCIAL";
            this.mEDNOMCOMMERCIALDataGridViewTextBoxColumn1.HeaderText = "MED_NOMCOMMERCIAL";
            this.mEDNOMCOMMERCIALDataGridViewTextBoxColumn1.Name = "mEDNOMCOMMERCIALDataGridViewTextBoxColumn1";
            // 
            // fAMCODEDataGridViewTextBoxColumn1
            // 
            this.fAMCODEDataGridViewTextBoxColumn1.DataPropertyName = "FAM_CODE";
            this.fAMCODEDataGridViewTextBoxColumn1.HeaderText = "FAM_CODE";
            this.fAMCODEDataGridViewTextBoxColumn1.Name = "fAMCODEDataGridViewTextBoxColumn1";
            // 
            // mEDCOMPOSITIONDataGridViewTextBoxColumn1
            // 
            this.mEDCOMPOSITIONDataGridViewTextBoxColumn1.DataPropertyName = "MED_COMPOSITION";
            this.mEDCOMPOSITIONDataGridViewTextBoxColumn1.HeaderText = "MED_COMPOSITION";
            this.mEDCOMPOSITIONDataGridViewTextBoxColumn1.Name = "mEDCOMPOSITIONDataGridViewTextBoxColumn1";
            // 
            // mEDEFFETSDataGridViewTextBoxColumn1
            // 
            this.mEDEFFETSDataGridViewTextBoxColumn1.DataPropertyName = "MED_EFFETS";
            this.mEDEFFETSDataGridViewTextBoxColumn1.HeaderText = "MED_EFFETS";
            this.mEDEFFETSDataGridViewTextBoxColumn1.Name = "mEDEFFETSDataGridViewTextBoxColumn1";
            // 
            // mEDCONTREINDICDataGridViewTextBoxColumn1
            // 
            this.mEDCONTREINDICDataGridViewTextBoxColumn1.DataPropertyName = "MED_CONTREINDIC";
            this.mEDCONTREINDICDataGridViewTextBoxColumn1.HeaderText = "MED_CONTREINDIC";
            this.mEDCONTREINDICDataGridViewTextBoxColumn1.Name = "mEDCONTREINDICDataGridViewTextBoxColumn1";
            // 
            // mEDPRIXECHANTILLONDataGridViewTextBoxColumn1
            // 
            this.mEDPRIXECHANTILLONDataGridViewTextBoxColumn1.DataPropertyName = "MED_PRIXECHANTILLON";
            this.mEDPRIXECHANTILLONDataGridViewTextBoxColumn1.HeaderText = "MED_PRIXECHANTILLON";
            this.mEDPRIXECHANTILLONDataGridViewTextBoxColumn1.Name = "mEDPRIXECHANTILLONDataGridViewTextBoxColumn1";
            this.mEDPRIXECHANTILLONDataGridViewTextBoxColumn1.Visible = false;
            // 
            // laFamilleDataGridViewTextBoxColumn1
            // 
            this.laFamilleDataGridViewTextBoxColumn1.DataPropertyName = "LaFamille";
            this.laFamilleDataGridViewTextBoxColumn1.HeaderText = "LaFamille";
            this.laFamilleDataGridViewTextBoxColumn1.Name = "laFamilleDataGridViewTextBoxColumn1";
            this.laFamilleDataGridViewTextBoxColumn1.Visible = false;
            // 
            // lesEchantillonsOffertsDataGridViewTextBoxColumn1
            // 
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn1.DataPropertyName = "LesEchantillonsOfferts";
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn1.HeaderText = "LesEchantillonsOfferts";
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn1.Name = "lesEchantillonsOffertsDataGridViewTextBoxColumn1";
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn1.Visible = false;
            // 
            // lesRapports1DataGridViewTextBoxColumn1
            // 
            this.lesRapports1DataGridViewTextBoxColumn1.DataPropertyName = "LesRapports1";
            this.lesRapports1DataGridViewTextBoxColumn1.HeaderText = "LesRapports1";
            this.lesRapports1DataGridViewTextBoxColumn1.Name = "lesRapports1DataGridViewTextBoxColumn1";
            this.lesRapports1DataGridViewTextBoxColumn1.Visible = false;
            // 
            // lesRapports2DataGridViewTextBoxColumn1
            // 
            this.lesRapports2DataGridViewTextBoxColumn1.DataPropertyName = "LesRapports2";
            this.lesRapports2DataGridViewTextBoxColumn1.HeaderText = "LesRapports2";
            this.lesRapports2DataGridViewTextBoxColumn1.Name = "lesRapports2DataGridViewTextBoxColumn1";
            this.lesRapports2DataGridViewTextBoxColumn1.Visible = false;
            // 
            // bsmedicament2
            // 
            this.bsmedicament2.DataSource = typeof(GSBCR.modele.MEDICAMENT);
            // 
            // frmMedicamentdets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(912, 487);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmMedicamentdets";
            this.Text = "frmMedicamentdets";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsmedicament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsmedicament2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEDDEPOTLEGALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEDNOMCOMMERCIALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fAMCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEDCOMPOSITIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEDEFFETSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEDCONTREINDICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEDPRIXECHANTILLONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn laFamilleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lesEchantillonsOffertsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lesRapports1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lesRapports2DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsmedicament;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEDDEPOTLEGALDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEDNOMCOMMERCIALDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fAMCODEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEDCOMPOSITIONDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEDEFFETSDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEDCONTREINDICDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEDPRIXECHANTILLONDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn laFamilleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lesEchantillonsOffertsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lesRapports1DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lesRapports2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bsmedicament2;
    }
}