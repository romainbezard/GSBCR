namespace GSBCR.Formulaire
{
    partial class FrmConsulterMedicament
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbxMed1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoirMedoc = new System.Windows.Forms.Button();
            this.txtMed1 = new System.Windows.Forms.TextBox();
            this.bsMed1 = new System.Windows.Forms.BindingSource(this.components);
            this.bsRapports = new System.Windows.Forms.BindingSource(this.components);
            this.lblComposition = new System.Windows.Forms.Label();
            this.txtCompo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodeFam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEffet = new System.Windows.Forms.RichTextBox();
            this.txtContrIndic = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVoirRapportMed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMed1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(803, 37);
            this.label2.TabIndex = 28;
            this.label2.Text = "Consultation des informations pour un médicament";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GSBCR.Formulaire.Properties.Resources.logo_gsb_300x186;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // cbxMed1
            // 
            this.cbxMed1.FormattingEnabled = true;
            this.cbxMed1.Location = new System.Drawing.Point(13, 144);
            this.cbxMed1.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMed1.Name = "cbxMed1";
            this.cbxMed1.Size = new System.Drawing.Size(309, 26);
            this.cbxMed1.TabIndex = 29;
            this.cbxMed1.SelectedIndexChanged += new System.EventHandler(this.cbxMed1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Veuillez choisir un médicament :";
            // 
            // btnVoirMedoc
            // 
            this.btnVoirMedoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoirMedoc.Location = new System.Drawing.Point(413, 137);
            this.btnVoirMedoc.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoirMedoc.Name = "btnVoirMedoc";
            this.btnVoirMedoc.Size = new System.Drawing.Size(188, 33);
            this.btnVoirMedoc.TabIndex = 31;
            this.btnVoirMedoc.Text = "Voir les infos";
            this.btnVoirMedoc.UseVisualStyleBackColor = true;
            this.btnVoirMedoc.Click += new System.EventHandler(this.btnVoirMedoc_Click);
            // 
            // txtMed1
            // 
            this.txtMed1.Location = new System.Drawing.Point(330, 146);
            this.txtMed1.Margin = new System.Windows.Forms.Padding(4);
            this.txtMed1.Name = "txtMed1";
            this.txtMed1.Size = new System.Drawing.Size(75, 24);
            this.txtMed1.TabIndex = 32;
            this.txtMed1.TabStop = false;
            // 
            // lblComposition
            // 
            this.lblComposition.AutoSize = true;
            this.lblComposition.Location = new System.Drawing.Point(13, 174);
            this.lblComposition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComposition.Name = "lblComposition";
            this.lblComposition.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblComposition.Size = new System.Drawing.Size(93, 18);
            this.lblComposition.TabIndex = 33;
            this.lblComposition.Text = "Composition";
            // 
            // txtCompo
            // 
            this.txtCompo.Location = new System.Drawing.Point(13, 195);
            this.txtCompo.Name = "txtCompo";
            this.txtCompo.ReadOnly = true;
            this.txtCompo.Size = new System.Drawing.Size(523, 24);
            this.txtCompo.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "Effets";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 349);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(119, 18);
            this.label4.TabIndex = 37;
            this.label4.Text = "Contre indication";
            // 
            // txtCodeFam
            // 
            this.txtCodeFam.Location = new System.Drawing.Point(542, 195);
            this.txtCodeFam.Name = "txtCodeFam";
            this.txtCodeFam.ReadOnly = true;
            this.txtCodeFam.Size = new System.Drawing.Size(59, 24);
            this.txtCodeFam.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(541, 174);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 39;
            this.label5.Text = "Code Fam";
            // 
            // txtEffet
            // 
            this.txtEffet.Location = new System.Drawing.Point(13, 259);
            this.txtEffet.Name = "txtEffet";
            this.txtEffet.ReadOnly = true;
            this.txtEffet.Size = new System.Drawing.Size(588, 65);
            this.txtEffet.TabIndex = 41;
            this.txtEffet.Text = "";
            // 
            // txtContrIndic
            // 
            this.txtContrIndic.Location = new System.Drawing.Point(13, 370);
            this.txtContrIndic.Name = "txtContrIndic";
            this.txtContrIndic.ReadOnly = true;
            this.txtContrIndic.Size = new System.Drawing.Size(586, 72);
            this.txtContrIndic.TabIndex = 42;
            this.txtContrIndic.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.bsRapports;
            this.dataGridView1.Location = new System.Drawing.Point(626, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(794, 257);
            this.dataGridView1.TabIndex = 43;
            // 
            // btnVoirRapportMed
            // 
            this.btnVoirRapportMed.Location = new System.Drawing.Point(1047, 137);
            this.btnVoirRapportMed.Name = "btnVoirRapportMed";
            this.btnVoirRapportMed.Size = new System.Drawing.Size(373, 32);
            this.btnVoirRapportMed.TabIndex = 44;
            this.btnVoirRapportMed.Text = "Voir les rapports qui concerne ce médicament";
            this.btnVoirRapportMed.UseVisualStyleBackColor = true;
            this.btnVoirRapportMed.Click += new System.EventHandler(this.btnVoirRapportMed_Click);
            // 
            // FrmConsulterMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1432, 458);
            this.Controls.Add(this.btnVoirRapportMed);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtContrIndic);
            this.Controls.Add(this.txtEffet);
            this.Controls.Add(this.txtCodeFam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCompo);
            this.Controls.Add(this.lblComposition);
            this.Controls.Add(this.txtMed1);
            this.Controls.Add(this.btnVoirMedoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxMed1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmConsulterMedicament";
            this.Text = "Consulter un médicament";
            this.Load += new System.EventHandler(this.FrmConsulterMedicament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMed1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbxMed1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoirMedoc;
        private System.Windows.Forms.TextBox txtMed1;
        private System.Windows.Forms.BindingSource bsMed1;
        private System.Windows.Forms.BindingSource bsRapports;
        private System.Windows.Forms.Label lblComposition;
        private System.Windows.Forms.TextBox txtCompo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodeFam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtEffet;
        private System.Windows.Forms.RichTextBox txtContrIndic;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVoirRapportMed;
    }
}