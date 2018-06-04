namespace GSBCR.Formulaire
{
    partial class frmVisiteurADelegue
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vISMATRICULEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vISNOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visPRENOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vISADRESSEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vISCPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vISVILLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vISDATEEMBAUCHEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sECCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lABCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vismdpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lesRapportsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leSecteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lesAffectationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsvisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsvisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vISMATRICULEDataGridViewTextBoxColumn,
            this.vISNOMDataGridViewTextBoxColumn,
            this.visPRENOMDataGridViewTextBoxColumn,
            this.vISADRESSEDataGridViewTextBoxColumn,
            this.vISCPDataGridViewTextBoxColumn,
            this.vISVILLEDataGridViewTextBoxColumn,
            this.vISDATEEMBAUCHEDataGridViewTextBoxColumn,
            this.sECCODEDataGridViewTextBoxColumn,
            this.lABCODEDataGridViewTextBoxColumn,
            this.vismdpDataGridViewTextBoxColumn,
            this.lesRapportsDataGridViewTextBoxColumn,
            this.leSecteurDataGridViewTextBoxColumn,
            this.lesAffectationsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsvisiteur;
            this.dataGridView1.Location = new System.Drawing.Point(12, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(854, 186);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // vISMATRICULEDataGridViewTextBoxColumn
            // 
            this.vISMATRICULEDataGridViewTextBoxColumn.DataPropertyName = "VIS_MATRICULE";
            this.vISMATRICULEDataGridViewTextBoxColumn.HeaderText = "VIS_MATRICULE";
            this.vISMATRICULEDataGridViewTextBoxColumn.Name = "vISMATRICULEDataGridViewTextBoxColumn";
            // 
            // vISNOMDataGridViewTextBoxColumn
            // 
            this.vISNOMDataGridViewTextBoxColumn.DataPropertyName = "VIS_NOM";
            this.vISNOMDataGridViewTextBoxColumn.HeaderText = "VIS_NOM";
            this.vISNOMDataGridViewTextBoxColumn.Name = "vISNOMDataGridViewTextBoxColumn";
            // 
            // visPRENOMDataGridViewTextBoxColumn
            // 
            this.visPRENOMDataGridViewTextBoxColumn.DataPropertyName = "Vis_PRENOM";
            this.visPRENOMDataGridViewTextBoxColumn.HeaderText = "Vis_PRENOM";
            this.visPRENOMDataGridViewTextBoxColumn.Name = "visPRENOMDataGridViewTextBoxColumn";
            // 
            // vISADRESSEDataGridViewTextBoxColumn
            // 
            this.vISADRESSEDataGridViewTextBoxColumn.DataPropertyName = "VIS_ADRESSE";
            this.vISADRESSEDataGridViewTextBoxColumn.HeaderText = "VIS_ADRESSE";
            this.vISADRESSEDataGridViewTextBoxColumn.Name = "vISADRESSEDataGridViewTextBoxColumn";
            // 
            // vISCPDataGridViewTextBoxColumn
            // 
            this.vISCPDataGridViewTextBoxColumn.DataPropertyName = "VIS_CP";
            this.vISCPDataGridViewTextBoxColumn.HeaderText = "VIS_CP";
            this.vISCPDataGridViewTextBoxColumn.Name = "vISCPDataGridViewTextBoxColumn";
            // 
            // vISVILLEDataGridViewTextBoxColumn
            // 
            this.vISVILLEDataGridViewTextBoxColumn.DataPropertyName = "VIS_VILLE";
            this.vISVILLEDataGridViewTextBoxColumn.HeaderText = "VIS_VILLE";
            this.vISVILLEDataGridViewTextBoxColumn.Name = "vISVILLEDataGridViewTextBoxColumn";
            // 
            // vISDATEEMBAUCHEDataGridViewTextBoxColumn
            // 
            this.vISDATEEMBAUCHEDataGridViewTextBoxColumn.DataPropertyName = "VIS_DATEEMBAUCHE";
            this.vISDATEEMBAUCHEDataGridViewTextBoxColumn.HeaderText = "VIS_DATEEMBAUCHE";
            this.vISDATEEMBAUCHEDataGridViewTextBoxColumn.Name = "vISDATEEMBAUCHEDataGridViewTextBoxColumn";
            // 
            // sECCODEDataGridViewTextBoxColumn
            // 
            this.sECCODEDataGridViewTextBoxColumn.DataPropertyName = "SEC_CODE";
            this.sECCODEDataGridViewTextBoxColumn.HeaderText = "SEC_CODE";
            this.sECCODEDataGridViewTextBoxColumn.Name = "sECCODEDataGridViewTextBoxColumn";
            // 
            // lABCODEDataGridViewTextBoxColumn
            // 
            this.lABCODEDataGridViewTextBoxColumn.DataPropertyName = "LAB_CODE";
            this.lABCODEDataGridViewTextBoxColumn.HeaderText = "LAB_CODE";
            this.lABCODEDataGridViewTextBoxColumn.Name = "lABCODEDataGridViewTextBoxColumn";
            // 
            // vismdpDataGridViewTextBoxColumn
            // 
            this.vismdpDataGridViewTextBoxColumn.DataPropertyName = "vis_mdp";
            this.vismdpDataGridViewTextBoxColumn.HeaderText = "vis_mdp";
            this.vismdpDataGridViewTextBoxColumn.Name = "vismdpDataGridViewTextBoxColumn";
            // 
            // lesRapportsDataGridViewTextBoxColumn
            // 
            this.lesRapportsDataGridViewTextBoxColumn.DataPropertyName = "LesRapports";
            this.lesRapportsDataGridViewTextBoxColumn.HeaderText = "LesRapports";
            this.lesRapportsDataGridViewTextBoxColumn.Name = "lesRapportsDataGridViewTextBoxColumn";
            // 
            // leSecteurDataGridViewTextBoxColumn
            // 
            this.leSecteurDataGridViewTextBoxColumn.DataPropertyName = "LeSecteur";
            this.leSecteurDataGridViewTextBoxColumn.HeaderText = "LeSecteur";
            this.leSecteurDataGridViewTextBoxColumn.Name = "leSecteurDataGridViewTextBoxColumn";
            // 
            // lesAffectationsDataGridViewTextBoxColumn
            // 
            this.lesAffectationsDataGridViewTextBoxColumn.DataPropertyName = "LesAffectations";
            this.lesAffectationsDataGridViewTextBoxColumn.HeaderText = "LesAffectations";
            this.lesAffectationsDataGridViewTextBoxColumn.Name = "lesAffectationsDataGridViewTextBoxColumn";
            // 
            // bsvisiteur
            // 
            this.bsvisiteur.DataSource = typeof(GSBCR.modele.VISITEUR);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(734, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Retour";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GSBCR.Formulaire.Properties.Resources.logo_gsb_300x186;
            this.pictureBox1.Location = new System.Drawing.Point(34, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Changer un Visiteur en Délégué";
            // 
            // frmVisiteurADelegue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(878, 466);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmVisiteurADelegue";
            this.Text = "frmVisiteurADelegue";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsvisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vISMATRICULEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vISNOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visPRENOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vISADRESSEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vISCPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vISVILLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vISDATEEMBAUCHEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lABCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vismdpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lesRapportsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leSecteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lesAffectationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsvisiteur;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}