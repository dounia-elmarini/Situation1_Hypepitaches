namespace Projet_Developpement
{
    partial class list_empCompetences
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
            System.Windows.Forms.Label cOMP_NOMLabel;
            System.Windows.Forms.Label label1;
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.cOMP_NOMTextBox = new System.Windows.Forms.TextBox();
            this.bs_empcomp = new System.Windows.Forms.BindingSource(this.components);
            this.lesEmployesListBox = new System.Windows.Forms.ListBox();
            cOMP_NOMLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_empcomp)).BeginInit();
            this.SuspendLayout();
            // 
            // cOMP_NOMLabel
            // 
            cOMP_NOMLabel.AutoSize = true;
            cOMP_NOMLabel.Font = new System.Drawing.Font("Gabriola", 10F);
            cOMP_NOMLabel.Location = new System.Drawing.Point(91, 32);
            cOMP_NOMLabel.Name = "cOMP_NOMLabel";
            cOMP_NOMLabel.Size = new System.Drawing.Size(64, 26);
            cOMP_NOMLabel.TabIndex = 1;
            cOMP_NOMLabel.Text = "Compétence";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Gabriola", 10F);
            label1.Location = new System.Drawing.Point(91, 84);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(174, 26);
            label1.TabIndex = 4;
            label1.Text = "Employés possédant cette compétence :";
            // 
            // bs
            // 
            this.bs.DataSource = typeof(Projet_Developpement.COMPETENCE);
            // 
            // cOMP_NOMTextBox
            // 
            this.cOMP_NOMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "COMP_NOM", true));
            this.cOMP_NOMTextBox.Location = new System.Drawing.Point(199, 38);
            this.cOMP_NOMTextBox.Name = "cOMP_NOMTextBox";
            this.cOMP_NOMTextBox.Size = new System.Drawing.Size(100, 20);
            this.cOMP_NOMTextBox.TabIndex = 2;
            // 
            // bs_empcomp
            // 
            this.bs_empcomp.DataMember = "LesEmployes";
            this.bs_empcomp.DataSource = this.bs;
            // 
            // lesEmployesListBox
            // 
            this.lesEmployesListBox.DataSource = this.bs_empcomp;
            this.lesEmployesListBox.DisplayMember = "EMP_NOM";
            this.lesEmployesListBox.FormattingEnabled = true;
            this.lesEmployesListBox.Location = new System.Drawing.Point(96, 122);
            this.lesEmployesListBox.Name = "lesEmployesListBox";
            this.lesEmployesListBox.Size = new System.Drawing.Size(244, 82);
            this.lesEmployesListBox.TabIndex = 3;
            this.lesEmployesListBox.ValueMember = "EMP_ID";
            // 
            // list_empCompetences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(424, 254);
            this.Controls.Add(label1);
            this.Controls.Add(this.lesEmployesListBox);
            this.Controls.Add(cOMP_NOMLabel);
            this.Controls.Add(this.cOMP_NOMTextBox);
            this.Name = "list_empCompetences";
            this.Text = "list_empCompetences";
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_empcomp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.TextBox cOMP_NOMTextBox;
        private System.Windows.Forms.BindingSource bs_empcomp;
        private System.Windows.Forms.ListBox lesEmployesListBox;

    }
}