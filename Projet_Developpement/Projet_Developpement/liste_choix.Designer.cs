namespace Projet_Developpement
{
    partial class liste_choix
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
            this.btn_diplome = new System.Windows.Forms.Button();
            this.btn_metier = new System.Windows.Forms.Button();
            this.btn_contrat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_diplome
            // 
            this.btn_diplome.Location = new System.Drawing.Point(102, 64);
            this.btn_diplome.Name = "btn_diplome";
            this.btn_diplome.Size = new System.Drawing.Size(75, 23);
            this.btn_diplome.TabIndex = 0;
            this.btn_diplome.Text = "DIPLOMES";
            this.btn_diplome.UseVisualStyleBackColor = true;
            this.btn_diplome.Click += new System.EventHandler(this.btn_diplome_Click);
            // 
            // btn_metier
            // 
            this.btn_metier.Location = new System.Drawing.Point(102, 123);
            this.btn_metier.Name = "btn_metier";
            this.btn_metier.Size = new System.Drawing.Size(75, 23);
            this.btn_metier.TabIndex = 1;
            this.btn_metier.Text = "METIERS";
            this.btn_metier.UseVisualStyleBackColor = true;
            this.btn_metier.Click += new System.EventHandler(this.btn_metier_Click);
            // 
            // btn_contrat
            // 
            this.btn_contrat.Location = new System.Drawing.Point(102, 173);
            this.btn_contrat.Name = "btn_contrat";
            this.btn_contrat.Size = new System.Drawing.Size(75, 23);
            this.btn_contrat.TabIndex = 2;
            this.btn_contrat.Text = "CONTRATS";
            this.btn_contrat.UseVisualStyleBackColor = true;
            this.btn_contrat.Click += new System.EventHandler(this.btn_contrat_Click);
            // 
            // liste_choix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.btn_contrat);
            this.Controls.Add(this.btn_metier);
            this.Controls.Add(this.btn_diplome);
            this.Name = "liste_choix";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_diplome;
        private System.Windows.Forms.Button btn_metier;
        private System.Windows.Forms.Button btn_contrat;
    }
}

