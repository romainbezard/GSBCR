namespace GSBCR.Formulaire
{
    partial class frmMedecindetcs
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
            this.bsmed = new System.Windows.Forms.BindingSource(this.components);
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsmed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.DataSource = this.bsmed;
            this.dataGridView1.Location = new System.Drawing.Point(61, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 204);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bsmed
            // 
            this.bsmed.DataSource = typeof(GSBCR.modele.PRATICIEN);
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
            this.pRACOEFNOTORIETEDataGridViewTextBoxColumn.Visible = false;
            // 
            // tYPCODEDataGridViewTextBoxColumn
            // 
            this.tYPCODEDataGridViewTextBoxColumn.DataPropertyName = "TYP_CODE";
            this.tYPCODEDataGridViewTextBoxColumn.HeaderText = "TYP_CODE";
            this.tYPCODEDataGridViewTextBoxColumn.Name = "tYPCODEDataGridViewTextBoxColumn";
            this.tYPCODEDataGridViewTextBoxColumn.Visible = false;
            // 
            // pOSSEDERsDataGridViewTextBoxColumn
            // 
            this.pOSSEDERsDataGridViewTextBoxColumn.DataPropertyName = "POSSEDERs";
            this.pOSSEDERsDataGridViewTextBoxColumn.HeaderText = "POSSEDERs";
            this.pOSSEDERsDataGridViewTextBoxColumn.Name = "pOSSEDERsDataGridViewTextBoxColumn";
            this.pOSSEDERsDataGridViewTextBoxColumn.Visible = false;
            // 
            // leTypeDataGridViewTextBoxColumn
            // 
            this.leTypeDataGridViewTextBoxColumn.DataPropertyName = "LeType";
            this.leTypeDataGridViewTextBoxColumn.HeaderText = "LeType";
            this.leTypeDataGridViewTextBoxColumn.Name = "leTypeDataGridViewTextBoxColumn";
            this.leTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // lesRapportsDataGridViewTextBoxColumn
            // 
            this.lesRapportsDataGridViewTextBoxColumn.DataPropertyName = "LesRapports";
            this.lesRapportsDataGridViewTextBoxColumn.HeaderText = "LesRapports";
            this.lesRapportsDataGridViewTextBoxColumn.Name = "lesRapportsDataGridViewTextBoxColumn";
            this.lesRapportsDataGridViewTextBoxColumn.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GSBCR.Formulaire.Properties.Resources.logo_gsb_300x186;
            this.pictureBox1.Location = new System.Drawing.Point(26, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Détail du médecin";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(616, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMedecindetcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(753, 393);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmMedecindetcs";
            this.Text = "frmMedecindetcs";
            this.Load += new System.EventHandler(this.frmMedecindetcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsmed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.BindingSource bsmed;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}