namespace Projet_Developpement
{
    partial class liste_emp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(liste_emp));
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_ajoutemp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bs
            // 
            this.bs.DataSource = typeof(Projet_Developpement.EMPLOYE);
            // 
            // eMPLOYEDataGridView
            // 
            this.eMPLOYEDataGridView.AutoGenerateColumns = false;
            this.eMPLOYEDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eMPLOYEDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.eMPLOYEDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.eMPLOYEDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.eMPLOYEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eMPLOYEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.Details});
            this.eMPLOYEDataGridView.DataSource = this.bs;
            this.eMPLOYEDataGridView.Location = new System.Drawing.Point(12, 130);
            this.eMPLOYEDataGridView.Name = "eMPLOYEDataGridView";
            this.eMPLOYEDataGridView.Size = new System.Drawing.Size(708, 220);
            this.eMPLOYEDataGridView.TabIndex = 1;
            this.eMPLOYEDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eMPLOYEDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EMP_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Identifiant";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EMP_NOM";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EMP_PRENOM";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prénom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "EMP_TEL";
            this.dataGridViewTextBoxColumn7.HeaderText = "Téléphone";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "EMP_MAIL";
            this.dataGridViewTextBoxColumn8.HeaderText = "E-mail";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 160;
            // 
            // Details
            // 
            this.Details.HeaderText = "Détails";
            this.Details.Name = "Details";
            // 
            // btn_ajoutemp
            // 
            this.btn_ajoutemp.BackColor = System.Drawing.Color.Transparent;
            this.btn_ajoutemp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ajoutemp.FlatAppearance.BorderSize = 0;
            this.btn_ajoutemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ajoutemp.Image = ((System.Drawing.Image)(resources.GetObject("btn_ajoutemp.Image")));
            this.btn_ajoutemp.Location = new System.Drawing.Point(632, 383);
            this.btn_ajoutemp.Name = "btn_ajoutemp";
            this.btn_ajoutemp.Size = new System.Drawing.Size(23, 23);
            this.btn_ajoutemp.TabIndex = 2;
            this.btn_ajoutemp.UseVisualStyleBackColor = false;
            this.btn_ajoutemp.Click += new System.EventHandler(this.btn_ajoutemp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gabriola", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(651, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employé";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gabriola", 17F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "Liste des employés";
            // 
            // liste_emp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(747, 442);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ajoutemp);
            this.Controls.Add(this.eMPLOYEDataGridView);
            this.Name = "liste_emp";
            this.Text = "Liste des employés";
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.DataGridView eMPLOYEDataGridView;
        private System.Windows.Forms.Button btn_ajoutemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewButtonColumn Details;
        private System.Windows.Forms.Label label2;
    }
}