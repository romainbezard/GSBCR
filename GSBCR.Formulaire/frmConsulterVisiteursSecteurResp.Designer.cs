namespace GSBCR.Formulaire
{
    partial class frmConsulterVisiteursSecteurResp
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
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.btnConsulterVisiteur = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxRegion = new System.Windows.Forms.ComboBox();
            this.btndeco = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bsVisiteurs = new System.Windows.Forms.BindingSource(this.components);
            this.bsRegion = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegion)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1145, 310);
            this.dataGridView1.TabIndex = 45;
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(325, 177);
            this.txtRegion.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(75, 20);
            this.txtRegion.TabIndex = 44;
            this.txtRegion.TabStop = false;
            // 
            // btnConsulterVisiteur
            // 
            this.btnConsulterVisiteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulterVisiteur.Location = new System.Drawing.Point(408, 168);
            this.btnConsulterVisiteur.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsulterVisiteur.Name = "btnConsulterVisiteur";
            this.btnConsulterVisiteur.Size = new System.Drawing.Size(188, 33);
            this.btnConsulterVisiteur.TabIndex = 43;
            this.btnConsulterVisiteur.Text = "Consulter les visiteurs";
            this.btnConsulterVisiteur.UseVisualStyleBackColor = true;
            this.btnConsulterVisiteur.Click += new System.EventHandler(this.btnConsulterVisiteur_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = "Veuillez choisir une région de votre secteur :";
            // 
            // cbxRegion
            // 
            this.cbxRegion.FormattingEnabled = true;
            this.cbxRegion.Location = new System.Drawing.Point(8, 175);
            this.cbxRegion.Margin = new System.Windows.Forms.Padding(4);
            this.cbxRegion.Name = "cbxRegion";
            this.cbxRegion.Size = new System.Drawing.Size(309, 21);
            this.cbxRegion.TabIndex = 41;
            this.cbxRegion.SelectedIndexChanged += new System.EventHandler(this.cbxRegion_SelectedIndexChanged);
            // 
            // btndeco
            // 
            this.btndeco.Location = new System.Drawing.Point(1031, 29);
            this.btndeco.Margin = new System.Windows.Forms.Padding(4);
            this.btndeco.Name = "btndeco";
            this.btndeco.Size = new System.Drawing.Size(121, 43);
            this.btndeco.TabIndex = 40;
            this.btndeco.Text = "Deconnexion";
            this.btndeco.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 62);
            this.label1.TabIndex = 39;
            this.label1.Text = "Consulter les visiteurs \r\nd\'une région de votre secteur";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GSBCR.Formulaire.Properties.Resources.logo_gsb_300x186;
            this.pictureBox1.Location = new System.Drawing.Point(7, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // frmConsulterVisiteursSecteurResp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1161, 530);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.btnConsulterVisiteur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxRegion);
            this.Controls.Add(this.btndeco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmConsulterVisiteursSecteurResp";
            this.Text = "Consulter la liste des visiteurs d\'une région de son secteur";
            this.Load += new System.EventHandler(this.frmConsulterVisiteursSecteurResp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Button btnConsulterVisiteur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxRegion;
        private System.Windows.Forms.Button btndeco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource bsVisiteurs;
        private System.Windows.Forms.BindingSource bsRegion;
    }
}