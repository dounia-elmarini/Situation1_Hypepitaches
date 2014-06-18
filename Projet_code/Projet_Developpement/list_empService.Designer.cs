namespace Projet_Developpement
{
    partial class list_empService
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
            System.Windows.Forms.Label sERVICE_DESIGNATIONLabel;
            System.Windows.Forms.Label label1;
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.bs_empserv = new System.Windows.Forms.BindingSource(this.components);
            this.lesEmployesListBox = new System.Windows.Forms.ListBox();
            this.sERVICE_DESIGNATIONTextBox = new System.Windows.Forms.TextBox();
            sERVICE_DESIGNATIONLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_empserv)).BeginInit();
            this.SuspendLayout();
            // 
            // sERVICE_DESIGNATIONLabel
            // 
            sERVICE_DESIGNATIONLabel.AutoSize = true;
            sERVICE_DESIGNATIONLabel.Font = new System.Drawing.Font("Gabriola", 10F);
            sERVICE_DESIGNATIONLabel.Location = new System.Drawing.Point(88, 44);
            sERVICE_DESIGNATIONLabel.Name = "sERVICE_DESIGNATIONLabel";
            sERVICE_DESIGNATIONLabel.Size = new System.Drawing.Size(40, 26);
            sERVICE_DESIGNATIONLabel.TabIndex = 3;
            sERVICE_DESIGNATIONLabel.Text = "Service";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Gabriola", 10F);
            label1.Location = new System.Drawing.Point(88, 96);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(159, 26);
            label1.TabIndex = 5;
            label1.Text = "Employés appartenant à ce service :";
            // 
            // bs
            // 
            this.bs.DataSource = typeof(Projet_Developpement.SERVICE);
            // 
            // bs_empserv
            // 
            this.bs_empserv.DataMember = "LesEmployes";
            this.bs_empserv.DataSource = this.bs;
            // 
            // lesEmployesListBox
            // 
            this.lesEmployesListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bs, "SERVICE_DESIGNATION", true));
            this.lesEmployesListBox.DataSource = this.bs_empserv;
            this.lesEmployesListBox.DisplayMember = "EMP_NOM";
            this.lesEmployesListBox.FormattingEnabled = true;
            this.lesEmployesListBox.Location = new System.Drawing.Point(93, 134);
            this.lesEmployesListBox.Name = "lesEmployesListBox";
            this.lesEmployesListBox.Size = new System.Drawing.Size(243, 82);
            this.lesEmployesListBox.TabIndex = 3;
            this.lesEmployesListBox.ValueMember = "EMP_ID";
            // 
            // sERVICE_DESIGNATIONTextBox
            // 
            this.sERVICE_DESIGNATIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "SERVICE_DESIGNATION", true));
            this.sERVICE_DESIGNATIONTextBox.Location = new System.Drawing.Point(147, 45);
            this.sERVICE_DESIGNATIONTextBox.Name = "sERVICE_DESIGNATIONTextBox";
            this.sERVICE_DESIGNATIONTextBox.Size = new System.Drawing.Size(100, 20);
            this.sERVICE_DESIGNATIONTextBox.TabIndex = 4;
            // 
            // list_empService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(413, 263);
            this.Controls.Add(label1);
            this.Controls.Add(sERVICE_DESIGNATIONLabel);
            this.Controls.Add(this.sERVICE_DESIGNATIONTextBox);
            this.Controls.Add(this.lesEmployesListBox);
            this.Name = "list_empService";
            this.Text = "list_empService";
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_empserv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.BindingSource bs_empserv;
        private System.Windows.Forms.ListBox lesEmployesListBox;
        private System.Windows.Forms.TextBox sERVICE_DESIGNATIONTextBox;
    }
}