namespace GSBCR.Formulaire
{
    partial class frmDetailRap
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
            this.txtnumrap = new System.Windows.Forms.TextBox();
            this.txtnumpra = new System.Windows.Forms.TextBox();
            this.txtmed2 = new System.Windows.Forms.TextBox();
            this.txtmed1 = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.txtetat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btndetmed = new System.Windows.Forms.Button();
            this.btndetcodemed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnumrap
            // 
            this.txtnumrap.Location = new System.Drawing.Point(228, 170);
            this.txtnumrap.Name = "txtnumrap";
            this.txtnumrap.ReadOnly = true;
            this.txtnumrap.Size = new System.Drawing.Size(100, 20);
            this.txtnumrap.TabIndex = 0;
            this.txtnumrap.TextChanged += new System.EventHandler(this.txtnumrap_TextChanged);
            // 
            // txtnumpra
            // 
            this.txtnumpra.Location = new System.Drawing.Point(507, 170);
            this.txtnumpra.Name = "txtnumpra";
            this.txtnumpra.ReadOnly = true;
            this.txtnumpra.Size = new System.Drawing.Size(100, 20);
            this.txtnumpra.TabIndex = 1;
            // 
            // txtmed2
            // 
            this.txtmed2.Location = new System.Drawing.Point(505, 311);
            this.txtmed2.Name = "txtmed2";
            this.txtmed2.ReadOnly = true;
            this.txtmed2.Size = new System.Drawing.Size(100, 20);
            this.txtmed2.TabIndex = 2;
            // 
            // txtmed1
            // 
            this.txtmed1.Location = new System.Drawing.Point(227, 311);
            this.txtmed1.Name = "txtmed1";
            this.txtmed1.ReadOnly = true;
            this.txtmed1.Size = new System.Drawing.Size(100, 20);
            this.txtmed1.TabIndex = 3;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(228, 238);
            this.txtdate.Name = "txtdate";
            this.txtdate.ReadOnly = true;
            this.txtdate.Size = new System.Drawing.Size(100, 20);
            this.txtdate.TabIndex = 4;
            // 
            // txtetat
            // 
            this.txtetat.Location = new System.Drawing.Point(504, 238);
            this.txtetat.Name = "txtetat";
            this.txtetat.ReadOnly = true;
            this.txtetat.Size = new System.Drawing.Size(100, 20);
            this.txtetat.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Numéro Rapport";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Numéro du praticien visité";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date de la visite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Etat du rapport";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Code médicament 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Code médicament 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(235, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(361, 31);
            this.label7.TabIndex = 12;
            this.label7.Text = "Détail des rapports validés";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(628, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 38);
            this.button1.TabIndex = 14;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GSBCR.Formulaire.Properties.Resources.logo_gsb_300x186;
            this.pictureBox1.Location = new System.Drawing.Point(16, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btndetmed
            // 
            this.btndetmed.Location = new System.Drawing.Point(641, 170);
            this.btndetmed.Name = "btndetmed";
            this.btndetmed.Size = new System.Drawing.Size(75, 23);
            this.btndetmed.TabIndex = 15;
            this.btndetmed.Text = "Détail praticien";
            this.btndetmed.UseVisualStyleBackColor = true;
            this.btndetmed.Click += new System.EventHandler(this.btndetmed_Click);
            // 
            // btndetcodemed
            // 
            this.btndetcodemed.Location = new System.Drawing.Point(628, 309);
            this.btndetcodemed.Name = "btndetcodemed";
            this.btndetcodemed.Size = new System.Drawing.Size(109, 23);
            this.btndetcodemed.TabIndex = 16;
            this.btndetcodemed.Text = "Détail médicaments";
            this.btndetcodemed.UseVisualStyleBackColor = true;
            this.btndetcodemed.Click += new System.EventHandler(this.btndetcodemed_Click);
            // 
            // frmDetailRap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(749, 438);
            this.Controls.Add(this.btndetcodemed);
            this.Controls.Add(this.btndetmed);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtetat);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.txtmed1);
            this.Controls.Add(this.txtmed2);
            this.Controls.Add(this.txtnumpra);
            this.Controls.Add(this.txtnumrap);
            this.Name = "frmDetailRap";
            this.Text = "frmDetailRap";
            this.Load += new System.EventHandler(this.frmDetailRap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnumrap;
        private System.Windows.Forms.TextBox txtnumpra;
        private System.Windows.Forms.TextBox txtmed2;
        private System.Windows.Forms.TextBox txtmed1;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.TextBox txtetat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btndetmed;
        private System.Windows.Forms.Button btndetcodemed;
    }
}