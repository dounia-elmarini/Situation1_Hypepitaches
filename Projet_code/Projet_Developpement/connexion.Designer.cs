namespace Projet_Developpement
{
    partial class connexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(connexion));
            this.annuler = new System.Windows.Forms.Button();
            this.se_connecter = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_mdp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // annuler
            // 
            this.annuler.BackColor = System.Drawing.Color.Transparent;
            this.annuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.annuler.FlatAppearance.BorderSize = 0;
            this.annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.annuler.Image = ((System.Drawing.Image)(resources.GetObject("annuler.Image")));
            this.annuler.Location = new System.Drawing.Point(191, 209);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(38, 38);
            this.annuler.TabIndex = 0;
            this.annuler.UseVisualStyleBackColor = false;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // se_connecter
            // 
            this.se_connecter.BackColor = System.Drawing.Color.Transparent;
            this.se_connecter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.se_connecter.FlatAppearance.BorderSize = 0;
            this.se_connecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.se_connecter.Image = ((System.Drawing.Image)(resources.GetObject("se_connecter.Image")));
            this.se_connecter.Location = new System.Drawing.Point(235, 209);
            this.se_connecter.Name = "se_connecter";
            this.se_connecter.Size = new System.Drawing.Size(34, 38);
            this.se_connecter.TabIndex = 1;
            this.se_connecter.UseVisualStyleBackColor = false;
            this.se_connecter.Click += new System.EventHandler(this.se_connecter_Click);
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(150, 108);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 20);
            this.tb_id.TabIndex = 2;
            // 
            // tb_mdp
            // 
            this.tb_mdp.Location = new System.Drawing.Point(150, 156);
            this.tb_mdp.Name = "tb_mdp";
            this.tb_mdp.PasswordChar = '•';
            this.tb_mdp.Size = new System.Drawing.Size(100, 20);
            this.tb_mdp.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 11.25F);
            this.label1.Location = new System.Drawing.Point(68, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Identifiant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gabriola", 11.25F);
            this.label2.Location = new System.Drawing.Point(68, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mot de passe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gabriola", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(54, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "- Espace réservé au DRH -";
            // 
            // connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(320, 270);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_mdp);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.se_connecter);
            this.Controls.Add(this.annuler);
            this.Name = "connexion";
            this.Text = "connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Button se_connecter;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_mdp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}