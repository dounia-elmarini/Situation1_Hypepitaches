namespace Projet_Developpement
{
    partial class list_ajoutcomp
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
            System.Windows.Forms.Label cOMP_DETAILLabel;
            System.Windows.Forms.Label cOMP_NOMLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(list_ajoutcomp));
            this.cOMPETENCEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.cOMPETENCEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cOMP_DETAILTextBox = new System.Windows.Forms.TextBox();
            this.cOMP_NOMTextBox = new System.Windows.Forms.TextBox();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            cOMP_DETAILLabel = new System.Windows.Forms.Label();
            cOMP_NOMLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPETENCEBindingNavigator)).BeginInit();
            this.cOMPETENCEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // cOMP_DETAILLabel
            // 
            cOMP_DETAILLabel.AutoSize = true;
            cOMP_DETAILLabel.Location = new System.Drawing.Point(42, 129);
            cOMP_DETAILLabel.Name = "cOMP_DETAILLabel";
            cOMP_DETAILLabel.Size = new System.Drawing.Size(34, 13);
            cOMP_DETAILLabel.TabIndex = 1;
            cOMP_DETAILLabel.Text = "Détail";
            // 
            // cOMP_NOMLabel
            // 
            cOMP_NOMLabel.AutoSize = true;
            cOMP_NOMLabel.Location = new System.Drawing.Point(42, 83);
            cOMP_NOMLabel.Name = "cOMP_NOMLabel";
            cOMP_NOMLabel.Size = new System.Drawing.Size(29, 13);
            cOMP_NOMLabel.TabIndex = 5;
            cOMP_NOMLabel.Text = "Nom";
            // 
            // cOMPETENCEBindingNavigator
            // 
            this.cOMPETENCEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cOMPETENCEBindingNavigator.BindingSource = this.bs;
            this.cOMPETENCEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cOMPETENCEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cOMPETENCEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cOMPETENCEBindingNavigatorSaveItem});
            this.cOMPETENCEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cOMPETENCEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cOMPETENCEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cOMPETENCEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cOMPETENCEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cOMPETENCEBindingNavigator.Name = "cOMPETENCEBindingNavigator";
            this.cOMPETENCEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cOMPETENCEBindingNavigator.Size = new System.Drawing.Size(303, 25);
            this.cOMPETENCEBindingNavigator.TabIndex = 0;
            this.cOMPETENCEBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
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
            // cOMPETENCEBindingNavigatorSaveItem
            // 
            this.cOMPETENCEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cOMPETENCEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cOMPETENCEBindingNavigatorSaveItem.Image")));
            this.cOMPETENCEBindingNavigatorSaveItem.Name = "cOMPETENCEBindingNavigatorSaveItem";
            this.cOMPETENCEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cOMPETENCEBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.cOMPETENCEBindingNavigatorSaveItem.Click += new System.EventHandler(this.cOMPETENCEBindingNavigatorSaveItem_Click);
            // 
            // cOMP_DETAILTextBox
            // 
            this.cOMP_DETAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "COMP_DETAIL", true));
            this.cOMP_DETAILTextBox.Location = new System.Drawing.Point(110, 129);
            this.cOMP_DETAILTextBox.Name = "cOMP_DETAILTextBox";
            this.cOMP_DETAILTextBox.Size = new System.Drawing.Size(146, 20);
            this.cOMP_DETAILTextBox.TabIndex = 2;
            // 
            // cOMP_NOMTextBox
            // 
            this.cOMP_NOMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "COMP_NOM", true));
            this.cOMP_NOMTextBox.Location = new System.Drawing.Point(110, 83);
            this.cOMP_NOMTextBox.Name = "cOMP_NOMTextBox";
            this.cOMP_NOMTextBox.Size = new System.Drawing.Size(146, 20);
            this.cOMP_NOMTextBox.TabIndex = 6;
            // 
            // bs
            // 
            this.bs.DataSource = typeof(Projet_Developpement.COMPETENCE);
            // 
            // list_ajoutcomp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 213);
            this.Controls.Add(cOMP_DETAILLabel);
            this.Controls.Add(this.cOMP_DETAILTextBox);
            this.Controls.Add(cOMP_NOMLabel);
            this.Controls.Add(this.cOMP_NOMTextBox);
            this.Controls.Add(this.cOMPETENCEBindingNavigator);
            this.Name = "list_ajoutcomp";
            this.Text = "Ajout de compétences";
            ((System.ComponentModel.ISupportInitialize)(this.cOMPETENCEBindingNavigator)).EndInit();
            this.cOMPETENCEBindingNavigator.ResumeLayout(false);
            this.cOMPETENCEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.BindingNavigator cOMPETENCEBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cOMPETENCEBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cOMP_DETAILTextBox;
        private System.Windows.Forms.TextBox cOMP_NOMTextBox;
    }
}