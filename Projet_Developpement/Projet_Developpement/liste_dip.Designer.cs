namespace Projet_Developpement
{
    partial class liste_dip
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
            System.Windows.Forms.Label dIPLOME_IDLabel;
            System.Windows.Forms.Label dIPLOME_NOMLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(liste_dip));
            this.bn = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dIPLOMEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dIPLOME_IDTextBox = new System.Windows.Forms.TextBox();
            this.dIPLOME_NOMTextBox = new System.Windows.Forms.TextBox();
            this.bs_employe = new System.Windows.Forms.BindingSource(this.components);
            this.lb_employes = new System.Windows.Forms.ListBox();
            dIPLOME_IDLabel = new System.Windows.Forms.Label();
            dIPLOME_NOMLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bn)).BeginInit();
            this.bn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_employe)).BeginInit();
            this.SuspendLayout();
            // 
            // dIPLOME_IDLabel
            // 
            dIPLOME_IDLabel.AutoSize = true;
            dIPLOME_IDLabel.Location = new System.Drawing.Point(100, 90);
            dIPLOME_IDLabel.Name = "dIPLOME_IDLabel";
            dIPLOME_IDLabel.Size = new System.Drawing.Size(72, 13);
            dIPLOME_IDLabel.TabIndex = 1;
            dIPLOME_IDLabel.Text = "DIPLOME ID:";
            // 
            // dIPLOME_NOMLabel
            // 
            dIPLOME_NOMLabel.AutoSize = true;
            dIPLOME_NOMLabel.Location = new System.Drawing.Point(100, 116);
            dIPLOME_NOMLabel.Name = "dIPLOME_NOMLabel";
            dIPLOME_NOMLabel.Size = new System.Drawing.Size(86, 13);
            dIPLOME_NOMLabel.TabIndex = 3;
            dIPLOME_NOMLabel.Text = "DIPLOME NOM:";
            // 
            // bn
            // 
            this.bn.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bn.BindingSource = this.bs;
            this.bn.CountItem = this.bindingNavigatorCountItem;
            this.bn.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.dIPLOMEBindingNavigatorSaveItem});
            this.bn.Location = new System.Drawing.Point(0, 0);
            this.bn.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn.Name = "bn";
            this.bn.PositionItem = this.bindingNavigatorPositionItem;
            this.bn.Size = new System.Drawing.Size(459, 25);
            this.bn.TabIndex = 0;
            this.bn.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bs
            // 
            this.bs.DataSource = typeof(Projet_Developpement.DIPLOME);
            this.bs.CurrentChanged += new System.EventHandler(this.bs_CurrentChanged);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dIPLOMEBindingNavigatorSaveItem
            // 
            this.dIPLOMEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dIPLOMEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dIPLOMEBindingNavigatorSaveItem.Image")));
            this.dIPLOMEBindingNavigatorSaveItem.Name = "dIPLOMEBindingNavigatorSaveItem";
            this.dIPLOMEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.dIPLOMEBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.dIPLOMEBindingNavigatorSaveItem.Click += new System.EventHandler(this.dIPLOMEBindingNavigatorSaveItem_Click);
            // 
            // dIPLOME_IDTextBox
            // 
            this.dIPLOME_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "DIPLOME_ID", true));
            this.dIPLOME_IDTextBox.Location = new System.Drawing.Point(192, 87);
            this.dIPLOME_IDTextBox.Name = "dIPLOME_IDTextBox";
            this.dIPLOME_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.dIPLOME_IDTextBox.TabIndex = 2;
            // 
            // dIPLOME_NOMTextBox
            // 
            this.dIPLOME_NOMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "DIPLOME_NOM", true));
            this.dIPLOME_NOMTextBox.Location = new System.Drawing.Point(192, 113);
            this.dIPLOME_NOMTextBox.Name = "dIPLOME_NOMTextBox";
            this.dIPLOME_NOMTextBox.Size = new System.Drawing.Size(100, 20);
            this.dIPLOME_NOMTextBox.TabIndex = 4;
            // 
            // bs_employe
            // 
            this.bs_employe.DataMember = "LesEmployes";
            this.bs_employe.DataSource = this.bs;
            // 
            // lb_employes
            // 
            this.lb_employes.DataSource = this.bs_employe;
            this.lb_employes.DisplayMember = "EMP_NOM";
            this.lb_employes.FormattingEnabled = true;
            this.lb_employes.Location = new System.Drawing.Point(69, 173);
            this.lb_employes.Name = "lb_employes";
            this.lb_employes.Size = new System.Drawing.Size(300, 212);
            this.lb_employes.TabIndex = 5;
            this.lb_employes.ValueMember = "EMP_ID";
            // 
            // liste_dip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 415);
            this.Controls.Add(this.lb_employes);
            this.Controls.Add(dIPLOME_IDLabel);
            this.Controls.Add(this.dIPLOME_IDTextBox);
            this.Controls.Add(dIPLOME_NOMLabel);
            this.Controls.Add(this.dIPLOME_NOMTextBox);
            this.Controls.Add(this.bn);
            this.Name = "liste_dip";
            this.Text = "Form_diplomes";
            ((System.ComponentModel.ISupportInitialize)(this.bn)).EndInit();
            this.bn.ResumeLayout(false);
            this.bn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_employe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.BindingNavigator bn;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton dIPLOMEBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox dIPLOME_IDTextBox;
        private System.Windows.Forms.TextBox dIPLOME_NOMTextBox;
        private System.Windows.Forms.BindingSource bs_employe;
        private System.Windows.Forms.ListBox lb_employes;
    }
}