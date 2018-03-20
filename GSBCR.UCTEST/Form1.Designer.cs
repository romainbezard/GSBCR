namespace GSBCR.UCTEST
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_medoc = new System.Windows.Forms.ComboBox();
            this.ucMedoc = new GSBCR.UC.UcMedicament();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.bs_medoc = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bs_medoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultation médicament";
            // 
            // cbx_medoc
            // 
            this.cbx_medoc.FormattingEnabled = true;
            this.cbx_medoc.Location = new System.Drawing.Point(226, 32);
            this.cbx_medoc.Name = "cbx_medoc";
            this.cbx_medoc.Size = new System.Drawing.Size(208, 21);
            this.cbx_medoc.TabIndex = 1;
            this.cbx_medoc.SelectedIndexChanged += new System.EventHandler(this.cbx_medoc_SelectedIndexChanged);
            // 
            // ucMedoc
            // 
            this.ucMedoc.LeMedicament = null;
            this.ucMedoc.Location = new System.Drawing.Point(101, 63);
            this.ucMedoc.Name = "ucMedoc";
            this.ucMedoc.Size = new System.Drawing.Size(485, 535);
            this.ucMedoc.TabIndex = 2;
            // 
            // btn_quitter
            // 
            this.btn_quitter.Location = new System.Drawing.Point(467, 32);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(119, 23);
            this.btn_quitter.TabIndex = 3;
            this.btn_quitter.Text = "Quitter";
            this.btn_quitter.UseVisualStyleBackColor = true;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 610);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.ucMedoc);
            this.Controls.Add(this.cbx_medoc);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Rapport de visite";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs_medoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_medoc;
        private UC.UcMedicament ucMedoc;
        private System.Windows.Forms.Button btn_quitter;
        private System.Windows.Forms.BindingSource bs_medoc;
    }
}

