namespace Projet_Developpement
{
    partial class list_historique
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
            this.hISTORIQUEDataGridView = new System.Windows.Forms.DataGridView();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hISTORIQUEDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // hISTORIQUEDataGridView
            // 
            this.hISTORIQUEDataGridView.AutoGenerateColumns = false;
            this.hISTORIQUEDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.hISTORIQUEDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hISTORIQUEDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.hISTORIQUEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hISTORIQUEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.hISTORIQUEDataGridView.DataSource = this.bs;
            this.hISTORIQUEDataGridView.Location = new System.Drawing.Point(43, 90);
            this.hISTORIQUEDataGridView.Name = "hISTORIQUEDataGridView";
            this.hISTORIQUEDataGridView.Size = new System.Drawing.Size(593, 294);
            this.hISTORIQUEDataGridView.TabIndex = 1;
            // 
            // bs
            // 
            this.bs.DataSource = typeof(Projet_Developpement.HISTORIQUE);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "HISTORIQUE_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Action n°";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HISTORIQUE_LIBELLE";
            this.dataGridViewTextBoxColumn2.HeaderText = "Détails";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HISTORIQUE_DATE";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Gabriola", 17F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(36, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 42);
            this.label6.TabIndex = 18;
            this.label6.Text = "Historique";
            // 
            // list_historique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(689, 422);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hISTORIQUEDataGridView);
            this.Name = "list_historique";
            this.Text = "list_historique";
            ((System.ComponentModel.ISupportInitialize)(this.hISTORIQUEDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.DataGridView hISTORIQUEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label6;
    }
}