namespace GSBCR.Formulaire
{
    partial class frmConsulterRapportSecteurResp
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
            this.btndeco = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.btnConsulterRapport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxRegion = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bsRegion = new System.Windows.Forms.BindingSource(this.components);
            this.bsRapports = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapports)).BeginInit();
            this.SuspendLayout();
            // 
            // btndeco
            // 
            this.btndeco.Location = new System.Drawing.Point(1036, 13);
            this.btndeco.Margin = new System.Windows.Forms.Padding(4);
            this.btndeco.Name = "btndeco";
            this.btndeco.Size = new System.Drawing.Size(121, 43);
            this.btndeco.TabIndex = 19;
            this.btndeco.Text = "Deconnexion";
            this.btndeco.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 62);
            this.label1.TabIndex = 18;
            this.label1.Text = "Consulter les rapports de visite\r\nd\'une région de votre secteur";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(330, 161);
            this.txtRegion.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(75, 20);
            this.txtRegion.TabIndex = 36;
            this.txtRegion.TabStop = false;
            // 
            // btnConsulterRapport
            // 
            this.btnConsulterRapport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulterRapport.Location = new System.Drawing.Point(413, 152);
            this.btnConsulterRapport.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsulterRapport.Name = "btnConsulterRapport";
            this.btnConsulterRapport.Size = new System.Drawing.Size(188, 33);
            this.btnConsulterRapport.TabIndex = 35;
            this.btnConsulterRapport.Text = "Consulter les rapports";
            this.btnConsulterRapport.UseVisualStyleBackColor = true;
            this.btnConsulterRapport.Click += new System.EventHandler(this.btnConsulterRapport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 18);
            this.label2.TabIndex = 34;
            this.label2.Text = "Veuillez choisir une région de votre secteur :";
            // 
            // cbxRegion
            // 
            this.cbxRegion.FormattingEnabled = true;
            this.cbxRegion.Location = new System.Drawing.Point(13, 159);
            this.cbxRegion.Margin = new System.Windows.Forms.Padding(4);
            this.cbxRegion.Name = "cbxRegion";
            this.cbxRegion.Size = new System.Drawing.Size(309, 21);
            this.cbxRegion.TabIndex = 33;
            this.cbxRegion.SelectedIndexChanged += new System.EventHandler(this.cbxRegion_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1145, 310);
            this.dataGridView1.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GSBCR.Formulaire.Properties.Resources.logo_gsb_300x186;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // frmConsulterRapportSecteurResp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1170, 543);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.btnConsulterRapport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxRegion);
            this.Controls.Add(this.btndeco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmConsulterRapportSecteurResp";
            this.Text = "Consulter les rapports de visite d\'une région de son secteur";
            this.Load += new System.EventHandler(this.frmConsulterRapportSecteurResp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btndeco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Button btnConsulterRapport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxRegion;
        private System.Windows.Forms.BindingSource bsRegion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bsRapports;
    }
}