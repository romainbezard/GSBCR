namespace GSBCR.Formulaire
{
    partial class FrmModifierRapport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModifierRapport));
            this.label1 = new System.Windows.Forms.Label();
            this.btndeco = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ckbsaisie = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.txtnumrap = new System.Windows.Forms.TextBox();
            this.txtmotif = new System.Windows.Forms.TextBox();
            this.txtbilan = new System.Windows.Forms.TextBox();
            this.txtpract = new System.Windows.Forms.TextBox();
            this.txtcoefconf = new System.Windows.Forms.TextBox();
            this.txtautremotif = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnvoirmed2 = new System.Windows.Forms.Button();
            this.btnvoirmed1 = new System.Windows.Forms.Button();
            this.txtmed2 = new System.Windows.Forms.TextBox();
            this.txtmed1 = new System.Windows.Forms.TextBox();
            this.cbmed2 = new System.Windows.Forms.ComboBox();
            this.cbmed1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rAPMATRICULEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPPRANUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPDATVISITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPETATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPCONFIANCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPBILANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPMOTIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPMOTIFAUTREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPNOMREMPLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPPNOMREMPLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPMED1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPMED2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leMedicament1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leMedicament2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leMotifVisiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lePraticienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leVisiteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsrapport = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.txtpractremp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrapport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modifier un Rapport de visite";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btndeco
            // 
            this.btndeco.Location = new System.Drawing.Point(759, 27);
            this.btndeco.Margin = new System.Windows.Forms.Padding(4);
            this.btndeco.Name = "btndeco";
            this.btndeco.Size = new System.Drawing.Size(121, 43);
            this.btndeco.TabIndex = 1;
            this.btndeco.Text = "Deconnexion";
            this.btndeco.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(771, 705);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Enregistrer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ckbsaisie
            // 
            this.ckbsaisie.AutoSize = true;
            this.ckbsaisie.Location = new System.Drawing.Point(55, 491);
            this.ckbsaisie.Margin = new System.Windows.Forms.Padding(4);
            this.ckbsaisie.Name = "ckbsaisie";
            this.ckbsaisie.Size = new System.Drawing.Size(121, 20);
            this.ckbsaisie.TabIndex = 3;
            this.ckbsaisie.Text = "Saisie définitive";
            this.ckbsaisie.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(630, 705);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 37);
            this.button3.TabIndex = 5;
            this.button3.Text = "Retour";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Numéro rapport";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date visite";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 272);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Motif";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 320);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bilan";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(328, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Praticien";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(482, 229);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Coef confiance";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(482, 276);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Autre motif";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(183, 225);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 22);
            this.dtp.TabIndex = 13;
            // 
            // txtnumrap
            // 
            this.txtnumrap.Location = new System.Drawing.Point(183, 177);
            this.txtnumrap.Name = "txtnumrap";
            this.txtnumrap.Size = new System.Drawing.Size(107, 22);
            this.txtnumrap.TabIndex = 14;
            // 
            // txtmotif
            // 
            this.txtmotif.Location = new System.Drawing.Point(183, 272);
            this.txtmotif.Name = "txtmotif";
            this.txtmotif.Size = new System.Drawing.Size(200, 22);
            this.txtmotif.TabIndex = 15;
            // 
            // txtbilan
            // 
            this.txtbilan.Location = new System.Drawing.Point(183, 316);
            this.txtbilan.Name = "txtbilan";
            this.txtbilan.Size = new System.Drawing.Size(615, 22);
            this.txtbilan.TabIndex = 16;
            // 
            // txtpract
            // 
            this.txtpract.Location = new System.Drawing.Point(413, 180);
            this.txtpract.Name = "txtpract";
            this.txtpract.Size = new System.Drawing.Size(177, 22);
            this.txtpract.TabIndex = 17;
            // 
            // txtcoefconf
            // 
            this.txtcoefconf.Location = new System.Drawing.Point(621, 227);
            this.txtcoefconf.Name = "txtcoefconf";
            this.txtcoefconf.Size = new System.Drawing.Size(85, 22);
            this.txtcoefconf.TabIndex = 18;
            // 
            // txtautremotif
            // 
            this.txtautremotif.Location = new System.Drawing.Point(621, 276);
            this.txtautremotif.Name = "txtautremotif";
            this.txtautremotif.Size = new System.Drawing.Size(177, 22);
            this.txtautremotif.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnvoirmed2);
            this.groupBox1.Controls.Add(this.btnvoirmed1);
            this.groupBox1.Controls.Add(this.txtmed2);
            this.groupBox1.Controls.Add(this.txtmed1);
            this.groupBox1.Controls.Add(this.cbmed2);
            this.groupBox1.Controls.Add(this.cbmed1);
            this.groupBox1.Location = new System.Drawing.Point(54, 356);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 128);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Médicaments présentés";
            // 
            // btnvoirmed2
            // 
            this.btnvoirmed2.Location = new System.Drawing.Point(576, 86);
            this.btnvoirmed2.Name = "btnvoirmed2";
            this.btnvoirmed2.Size = new System.Drawing.Size(152, 23);
            this.btnvoirmed2.TabIndex = 5;
            this.btnvoirmed2.Text = "Voir le médicament";
            this.btnvoirmed2.UseVisualStyleBackColor = true;
            // 
            // btnvoirmed1
            // 
            this.btnvoirmed1.Location = new System.Drawing.Point(576, 37);
            this.btnvoirmed1.Name = "btnvoirmed1";
            this.btnvoirmed1.Size = new System.Drawing.Size(152, 23);
            this.btnvoirmed1.TabIndex = 4;
            this.btnvoirmed1.Text = "Voir le médicament";
            this.btnvoirmed1.UseVisualStyleBackColor = true;
            // 
            // txtmed2
            // 
            this.txtmed2.Location = new System.Drawing.Point(339, 89);
            this.txtmed2.Name = "txtmed2";
            this.txtmed2.Size = new System.Drawing.Size(163, 22);
            this.txtmed2.TabIndex = 3;
            // 
            // txtmed1
            // 
            this.txtmed1.Location = new System.Drawing.Point(339, 39);
            this.txtmed1.Name = "txtmed1";
            this.txtmed1.Size = new System.Drawing.Size(163, 22);
            this.txtmed1.TabIndex = 2;
            // 
            // cbmed2
            // 
            this.cbmed2.FormattingEnabled = true;
            this.cbmed2.Location = new System.Drawing.Point(31, 86);
            this.cbmed2.Name = "cbmed2";
            this.cbmed2.Size = new System.Drawing.Size(243, 24);
            this.cbmed2.TabIndex = 1;
            // 
            // cbmed1
            // 
            this.cbmed1.FormattingEnabled = true;
            this.cbmed1.Location = new System.Drawing.Point(31, 37);
            this.cbmed1.Name = "cbmed1";
            this.cbmed1.Size = new System.Drawing.Size(243, 24);
            this.cbmed1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rAPMATRICULEDataGridViewTextBoxColumn,
            this.rAPNUMDataGridViewTextBoxColumn,
            this.rAPPRANUMDataGridViewTextBoxColumn,
            this.rAPDATEDataGridViewTextBoxColumn,
            this.rAPDATVISITDataGridViewTextBoxColumn,
            this.rAPETATDataGridViewTextBoxColumn,
            this.rAPCONFIANCEDataGridViewTextBoxColumn,
            this.rAPBILANDataGridViewTextBoxColumn,
            this.rAPMOTIFDataGridViewTextBoxColumn,
            this.rAPMOTIFAUTREDataGridViewTextBoxColumn,
            this.rAPNOMREMPLDataGridViewTextBoxColumn,
            this.rAPPNOMREMPLDataGridViewTextBoxColumn,
            this.rAPMED1DataGridViewTextBoxColumn,
            this.rAPMED2DataGridViewTextBoxColumn,
            this.leMedicament1DataGridViewTextBoxColumn,
            this.leMedicament2DataGridViewTextBoxColumn,
            this.leMotifVisiteDataGridViewTextBoxColumn,
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn,
            this.lePraticienDataGridViewTextBoxColumn,
            this.leVisiteurDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsrapport;
            this.dataGridView1.Location = new System.Drawing.Point(41, 518);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(848, 180);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // rAPMATRICULEDataGridViewTextBoxColumn
            // 
            this.rAPMATRICULEDataGridViewTextBoxColumn.DataPropertyName = "RAP_MATRICULE";
            this.rAPMATRICULEDataGridViewTextBoxColumn.HeaderText = "RAP_MATRICULE";
            this.rAPMATRICULEDataGridViewTextBoxColumn.Name = "rAPMATRICULEDataGridViewTextBoxColumn";
            this.rAPMATRICULEDataGridViewTextBoxColumn.Visible = false;
            // 
            // rAPNUMDataGridViewTextBoxColumn
            // 
            this.rAPNUMDataGridViewTextBoxColumn.DataPropertyName = "RAP_NUM";
            this.rAPNUMDataGridViewTextBoxColumn.HeaderText = "NUM";
            this.rAPNUMDataGridViewTextBoxColumn.Name = "rAPNUMDataGridViewTextBoxColumn";
            // 
            // rAPPRANUMDataGridViewTextBoxColumn
            // 
            this.rAPPRANUMDataGridViewTextBoxColumn.DataPropertyName = "RAP_PRANUM";
            this.rAPPRANUMDataGridViewTextBoxColumn.HeaderText = "RAP_PRANUM";
            this.rAPPRANUMDataGridViewTextBoxColumn.Name = "rAPPRANUMDataGridViewTextBoxColumn";
            this.rAPPRANUMDataGridViewTextBoxColumn.Visible = false;
            // 
            // rAPDATEDataGridViewTextBoxColumn
            // 
            this.rAPDATEDataGridViewTextBoxColumn.DataPropertyName = "RAP_DATE";
            this.rAPDATEDataGridViewTextBoxColumn.HeaderText = "RAP_DATE";
            this.rAPDATEDataGridViewTextBoxColumn.Name = "rAPDATEDataGridViewTextBoxColumn";
            this.rAPDATEDataGridViewTextBoxColumn.Visible = false;
            // 
            // rAPDATVISITDataGridViewTextBoxColumn
            // 
            this.rAPDATVISITDataGridViewTextBoxColumn.DataPropertyName = "RAP_DATVISIT";
            this.rAPDATVISITDataGridViewTextBoxColumn.HeaderText = "DATE VISITE";
            this.rAPDATVISITDataGridViewTextBoxColumn.Name = "rAPDATVISITDataGridViewTextBoxColumn";
            // 
            // rAPETATDataGridViewTextBoxColumn
            // 
            this.rAPETATDataGridViewTextBoxColumn.DataPropertyName = "RAP_ETAT";
            this.rAPETATDataGridViewTextBoxColumn.HeaderText = "RAP_ETAT";
            this.rAPETATDataGridViewTextBoxColumn.Name = "rAPETATDataGridViewTextBoxColumn";
            this.rAPETATDataGridViewTextBoxColumn.Visible = false;
            // 
            // rAPCONFIANCEDataGridViewTextBoxColumn
            // 
            this.rAPCONFIANCEDataGridViewTextBoxColumn.DataPropertyName = "RAP_CONFIANCE";
            this.rAPCONFIANCEDataGridViewTextBoxColumn.HeaderText = "CONFIANCE";
            this.rAPCONFIANCEDataGridViewTextBoxColumn.Name = "rAPCONFIANCEDataGridViewTextBoxColumn";
            // 
            // rAPBILANDataGridViewTextBoxColumn
            // 
            this.rAPBILANDataGridViewTextBoxColumn.DataPropertyName = "RAP_BILAN";
            this.rAPBILANDataGridViewTextBoxColumn.HeaderText = "BILAN";
            this.rAPBILANDataGridViewTextBoxColumn.Name = "rAPBILANDataGridViewTextBoxColumn";
            // 
            // rAPMOTIFDataGridViewTextBoxColumn
            // 
            this.rAPMOTIFDataGridViewTextBoxColumn.DataPropertyName = "RAP_MOTIF";
            this.rAPMOTIFDataGridViewTextBoxColumn.HeaderText = "MOTIF";
            this.rAPMOTIFDataGridViewTextBoxColumn.Name = "rAPMOTIFDataGridViewTextBoxColumn";
            // 
            // rAPMOTIFAUTREDataGridViewTextBoxColumn
            // 
            this.rAPMOTIFAUTREDataGridViewTextBoxColumn.DataPropertyName = "RAP_MOTIFAUTRE";
            this.rAPMOTIFAUTREDataGridViewTextBoxColumn.HeaderText = "AUTRE MOTIF";
            this.rAPMOTIFAUTREDataGridViewTextBoxColumn.Name = "rAPMOTIFAUTREDataGridViewTextBoxColumn";
            // 
            // rAPNOMREMPLDataGridViewTextBoxColumn
            // 
            this.rAPNOMREMPLDataGridViewTextBoxColumn.DataPropertyName = "RAP_NOMREMPL";
            this.rAPNOMREMPLDataGridViewTextBoxColumn.HeaderText = "RAP_NOMREMPL";
            this.rAPNOMREMPLDataGridViewTextBoxColumn.Name = "rAPNOMREMPLDataGridViewTextBoxColumn";
            this.rAPNOMREMPLDataGridViewTextBoxColumn.Visible = false;
            // 
            // rAPPNOMREMPLDataGridViewTextBoxColumn
            // 
            this.rAPPNOMREMPLDataGridViewTextBoxColumn.DataPropertyName = "RAP_PNOMREMPL";
            this.rAPPNOMREMPLDataGridViewTextBoxColumn.HeaderText = "RAP_PNOMREMPL";
            this.rAPPNOMREMPLDataGridViewTextBoxColumn.Name = "rAPPNOMREMPLDataGridViewTextBoxColumn";
            this.rAPPNOMREMPLDataGridViewTextBoxColumn.Visible = false;
            // 
            // rAPMED1DataGridViewTextBoxColumn
            // 
            this.rAPMED1DataGridViewTextBoxColumn.DataPropertyName = "RAP_MED1";
            this.rAPMED1DataGridViewTextBoxColumn.HeaderText = "MEDICAMENT 1";
            this.rAPMED1DataGridViewTextBoxColumn.Name = "rAPMED1DataGridViewTextBoxColumn";
            // 
            // rAPMED2DataGridViewTextBoxColumn
            // 
            this.rAPMED2DataGridViewTextBoxColumn.DataPropertyName = "RAP_MED2";
            this.rAPMED2DataGridViewTextBoxColumn.HeaderText = "MEDICAMENT 2";
            this.rAPMED2DataGridViewTextBoxColumn.Name = "rAPMED2DataGridViewTextBoxColumn";
            // 
            // leMedicament1DataGridViewTextBoxColumn
            // 
            this.leMedicament1DataGridViewTextBoxColumn.DataPropertyName = "leMedicament1";
            this.leMedicament1DataGridViewTextBoxColumn.HeaderText = "leMedicament1";
            this.leMedicament1DataGridViewTextBoxColumn.Name = "leMedicament1DataGridViewTextBoxColumn";
            this.leMedicament1DataGridViewTextBoxColumn.Visible = false;
            // 
            // leMedicament2DataGridViewTextBoxColumn
            // 
            this.leMedicament2DataGridViewTextBoxColumn.DataPropertyName = "LeMedicament2";
            this.leMedicament2DataGridViewTextBoxColumn.HeaderText = "LeMedicament2";
            this.leMedicament2DataGridViewTextBoxColumn.Name = "leMedicament2DataGridViewTextBoxColumn";
            this.leMedicament2DataGridViewTextBoxColumn.Visible = false;
            // 
            // leMotifVisiteDataGridViewTextBoxColumn
            // 
            this.leMotifVisiteDataGridViewTextBoxColumn.DataPropertyName = "LeMotifVisite";
            this.leMotifVisiteDataGridViewTextBoxColumn.HeaderText = "LeMotifVisite";
            this.leMotifVisiteDataGridViewTextBoxColumn.Name = "leMotifVisiteDataGridViewTextBoxColumn";
            this.leMotifVisiteDataGridViewTextBoxColumn.Visible = false;
            // 
            // lesEchantillonsOffertsDataGridViewTextBoxColumn
            // 
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn.DataPropertyName = "LesEchantillonsOfferts";
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn.HeaderText = "LesEchantillonsOfferts";
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn.Name = "lesEchantillonsOffertsDataGridViewTextBoxColumn";
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn.Visible = false;
            // 
            // lePraticienDataGridViewTextBoxColumn
            // 
            this.lePraticienDataGridViewTextBoxColumn.DataPropertyName = "LePraticien";
            this.lePraticienDataGridViewTextBoxColumn.HeaderText = "LePraticien";
            this.lePraticienDataGridViewTextBoxColumn.Name = "lePraticienDataGridViewTextBoxColumn";
            this.lePraticienDataGridViewTextBoxColumn.Visible = false;
            // 
            // leVisiteurDataGridViewTextBoxColumn
            // 
            this.leVisiteurDataGridViewTextBoxColumn.DataPropertyName = "LeVisiteur";
            this.leVisiteurDataGridViewTextBoxColumn.HeaderText = "LeVisiteur";
            this.leVisiteurDataGridViewTextBoxColumn.Name = "leVisiteurDataGridViewTextBoxColumn";
            this.leVisiteurDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsrapport
            // 
            this.bsrapport.DataSource = typeof(GSBCR.modele.RAPPORT_VISITE);
            this.bsrapport.CurrentChanged += new System.EventHandler(this.bsrapport_CurrentChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(611, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 18);
            this.label9.TabIndex = 22;
            this.label9.Text = "Praticien remplacant";
            // 
            // txtpractremp
            // 
            this.txtpractremp.Location = new System.Drawing.Point(759, 181);
            this.txtpractremp.Name = "txtpractremp";
            this.txtpractremp.Size = new System.Drawing.Size(144, 22);
            this.txtpractremp.TabIndex = 23;
            // 
            // FrmModifierRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(916, 755);
            this.Controls.Add(this.txtpractremp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtautremotif);
            this.Controls.Add(this.txtcoefconf);
            this.Controls.Add(this.txtpract);
            this.Controls.Add(this.txtbilan);
            this.Controls.Add(this.txtmotif);
            this.Controls.Add(this.txtnumrap);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ckbsaisie);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btndeco);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmModifierRapport";
            this.Text = "FrmAjoutRapport";
            this.Load += new System.EventHandler(this.FrmAjoutRapport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrapport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndeco;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox ckbsaisie;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.TextBox txtnumrap;
        private System.Windows.Forms.TextBox txtmotif;
        private System.Windows.Forms.TextBox txtbilan;
        private System.Windows.Forms.TextBox txtpract;
        private System.Windows.Forms.TextBox txtcoefconf;
        private System.Windows.Forms.TextBox txtautremotif;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnvoirmed2;
        private System.Windows.Forms.Button btnvoirmed1;
        private System.Windows.Forms.TextBox txtmed2;
        private System.Windows.Forms.TextBox txtmed1;
        private System.Windows.Forms.ComboBox cbmed2;
        private System.Windows.Forms.ComboBox cbmed1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtpractremp;
        private System.Windows.Forms.BindingSource bsrapport;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPMATRICULEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPPRANUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPDATVISITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPETATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPCONFIANCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPBILANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPMOTIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPMOTIFAUTREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPNOMREMPLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPPNOMREMPLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPMED1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPMED2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leMedicament1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leMedicament2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leMotifVisiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lesEchantillonsOffertsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lePraticienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leVisiteurDataGridViewTextBoxColumn;
    }
}