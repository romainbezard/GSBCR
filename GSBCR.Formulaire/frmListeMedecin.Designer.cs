namespace GSBCR.Formulaire
{
    partial class frmListeMedecin
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
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.DgPraticiens = new System.Windows.Forms.DataGridView();
            this.pRANUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRANOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRAPRENOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRAADRESSEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRACPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRAVILLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRACOEFNOTORIETEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tYPCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSSEDERsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lesRapportsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRATICIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgPraticiens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRATICIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GSBCR.Formulaire.Properties.Resources.logo_gsb_300x186;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des médecins";
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Location = new System.Drawing.Point(741, 12);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(102, 31);
            this.btnDeconnexion.TabIndex = 2;
            this.btnDeconnexion.Text = "Deconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            // 
            // DgPraticiens
            // 
            this.DgPraticiens.AutoGenerateColumns = false;
            this.DgPraticiens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgPraticiens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pRANUMDataGridViewTextBoxColumn,
            this.pRANOMDataGridViewTextBoxColumn,
            this.pRAPRENOMDataGridViewTextBoxColumn,
            this.pRAADRESSEDataGridViewTextBoxColumn,
            this.pRACPDataGridViewTextBoxColumn,
            this.pRAVILLEDataGridViewTextBoxColumn,
            this.pRACOEFNOTORIETEDataGridViewTextBoxColumn,
            this.tYPCODEDataGridViewTextBoxColumn,
            this.pOSSEDERsDataGridViewTextBoxColumn,
            this.leTypeDataGridViewTextBoxColumn,
            this.lesRapportsDataGridViewTextBoxColumn});
            this.DgPraticiens.DataSource = this.pRATICIENBindingSource;
            this.DgPraticiens.Location = new System.Drawing.Point(13, 182);
            this.DgPraticiens.Name = "DgPraticiens";
            this.DgPraticiens.Size = new System.Drawing.Size(1148, 351);
            this.DgPraticiens.TabIndex = 3;
            // 
            // pRANUMDataGridViewTextBoxColumn
            // 
            this.pRANUMDataGridViewTextBoxColumn.DataPropertyName = "PRA_NUM";
            this.pRANUMDataGridViewTextBoxColumn.HeaderText = "PRA_NUM";
            this.pRANUMDataGridViewTextBoxColumn.Name = "pRANUMDataGridViewTextBoxColumn";
            // 
            // pRANOMDataGridViewTextBoxColumn
            // 
            this.pRANOMDataGridViewTextBoxColumn.DataPropertyName = "PRA_NOM";
            this.pRANOMDataGridViewTextBoxColumn.HeaderText = "PRA_NOM";
            this.pRANOMDataGridViewTextBoxColumn.Name = "pRANOMDataGridViewTextBoxColumn";
            // 
            // pRAPRENOMDataGridViewTextBoxColumn
            // 
            this.pRAPRENOMDataGridViewTextBoxColumn.DataPropertyName = "PRA_PRENOM";
            this.pRAPRENOMDataGridViewTextBoxColumn.HeaderText = "PRA_PRENOM";
            this.pRAPRENOMDataGridViewTextBoxColumn.Name = "pRAPRENOMDataGridViewTextBoxColumn";
            // 
            // pRAADRESSEDataGridViewTextBoxColumn
            // 
            this.pRAADRESSEDataGridViewTextBoxColumn.DataPropertyName = "PRA_ADRESSE";
            this.pRAADRESSEDataGridViewTextBoxColumn.HeaderText = "PRA_ADRESSE";
            this.pRAADRESSEDataGridViewTextBoxColumn.Name = "pRAADRESSEDataGridViewTextBoxColumn";
            // 
            // pRACPDataGridViewTextBoxColumn
            // 
            this.pRACPDataGridViewTextBoxColumn.DataPropertyName = "PRA_CP";
            this.pRACPDataGridViewTextBoxColumn.HeaderText = "PRA_CP";
            this.pRACPDataGridViewTextBoxColumn.Name = "pRACPDataGridViewTextBoxColumn";
            // 
            // pRAVILLEDataGridViewTextBoxColumn
            // 
            this.pRAVILLEDataGridViewTextBoxColumn.DataPropertyName = "PRA_VILLE";
            this.pRAVILLEDataGridViewTextBoxColumn.HeaderText = "PRA_VILLE";
            this.pRAVILLEDataGridViewTextBoxColumn.Name = "pRAVILLEDataGridViewTextBoxColumn";
            // 
            // pRACOEFNOTORIETEDataGridViewTextBoxColumn
            // 
            this.pRACOEFNOTORIETEDataGridViewTextBoxColumn.DataPropertyName = "PRA_COEFNOTORIETE";
            this.pRACOEFNOTORIETEDataGridViewTextBoxColumn.HeaderText = "PRA_COEFNOTORIETE";
            this.pRACOEFNOTORIETEDataGridViewTextBoxColumn.Name = "pRACOEFNOTORIETEDataGridViewTextBoxColumn";
            // 
            // tYPCODEDataGridViewTextBoxColumn
            // 
            this.tYPCODEDataGridViewTextBoxColumn.DataPropertyName = "TYP_CODE";
            this.tYPCODEDataGridViewTextBoxColumn.HeaderText = "TYP_CODE";
            this.tYPCODEDataGridViewTextBoxColumn.Name = "tYPCODEDataGridViewTextBoxColumn";
            // 
            // pOSSEDERsDataGridViewTextBoxColumn
            // 
            this.pOSSEDERsDataGridViewTextBoxColumn.DataPropertyName = "POSSEDERs";
            this.pOSSEDERsDataGridViewTextBoxColumn.HeaderText = "POSSEDERs";
            this.pOSSEDERsDataGridViewTextBoxColumn.Name = "pOSSEDERsDataGridViewTextBoxColumn";
            // 
            // leTypeDataGridViewTextBoxColumn
            // 
            this.leTypeDataGridViewTextBoxColumn.DataPropertyName = "LeType";
            this.leTypeDataGridViewTextBoxColumn.HeaderText = "LeType";
            this.leTypeDataGridViewTextBoxColumn.Name = "leTypeDataGridViewTextBoxColumn";
            // 
            // lesRapportsDataGridViewTextBoxColumn
            // 
            this.lesRapportsDataGridViewTextBoxColumn.DataPropertyName = "LesRapports";
            this.lesRapportsDataGridViewTextBoxColumn.HeaderText = "LesRapports";
            this.lesRapportsDataGridViewTextBoxColumn.Name = "lesRapportsDataGridViewTextBoxColumn";
            // 
            // pRATICIENBindingSource
            // 
            this.pRATICIENBindingSource.DataSource = typeof(GSBCR.modele.PRATICIEN);
            // 
            // frmListeMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1240, 585);
            this.Controls.Add(this.DgPraticiens);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmListeMedecin";
            this.Text = "frmListeMedecin";
            this.Load += new System.EventHandler(this.frmListeMedecin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgPraticiens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRATICIENBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.DataGridView DgPraticiens;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRANUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRANOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRAPRENOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRAADRESSEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRACPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRAVILLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRACOEFNOTORIETEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOSSEDERsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lesRapportsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pRATICIENBindingSource;
    }
}