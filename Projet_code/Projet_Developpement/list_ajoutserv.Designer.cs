namespace Projet_Developpement
{
    partial class list_ajoutserv
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
            System.Windows.Forms.Label sERVICE_CAPACITELabel;
            System.Windows.Forms.Label sERVICE_DESIGNATIONLabel;
            System.Windows.Forms.Label sERVICE_TYPELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(list_ajoutserv));
            this.sERVICEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.sERVICEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sERVICE_CAPACITETextBox = new System.Windows.Forms.TextBox();
            this.sERVICE_DESIGNATIONTextBox = new System.Windows.Forms.TextBox();
            this.sERVICE_TYPETextBox = new System.Windows.Forms.TextBox();
            sERVICE_CAPACITELabel = new System.Windows.Forms.Label();
            sERVICE_DESIGNATIONLabel = new System.Windows.Forms.Label();
            sERVICE_TYPELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICEBindingNavigator)).BeginInit();
            this.sERVICEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // sERVICE_CAPACITELabel
            // 
            sERVICE_CAPACITELabel.AutoSize = true;
            sERVICE_CAPACITELabel.Location = new System.Drawing.Point(75, 149);
            sERVICE_CAPACITELabel.Name = "sERVICE_CAPACITELabel";
            sERVICE_CAPACITELabel.Size = new System.Drawing.Size(49, 13);
            sERVICE_CAPACITELabel.TabIndex = 1;
            sERVICE_CAPACITELabel.Text = "Capacité";
            // 
            // sERVICE_DESIGNATIONLabel
            // 
            sERVICE_DESIGNATIONLabel.AutoSize = true;
            sERVICE_DESIGNATIONLabel.Location = new System.Drawing.Point(75, 78);
            sERVICE_DESIGNATIONLabel.Name = "sERVICE_DESIGNATIONLabel";
            sERVICE_DESIGNATIONLabel.Size = new System.Drawing.Size(37, 13);
            sERVICE_DESIGNATIONLabel.TabIndex = 3;
            sERVICE_DESIGNATIONLabel.Text = "Libellé";
            // 
            // sERVICE_TYPELabel
            // 
            sERVICE_TYPELabel.AutoSize = true;
            sERVICE_TYPELabel.Location = new System.Drawing.Point(75, 113);
            sERVICE_TYPELabel.Name = "sERVICE_TYPELabel";
            sERVICE_TYPELabel.Size = new System.Drawing.Size(31, 13);
            sERVICE_TYPELabel.TabIndex = 7;
            sERVICE_TYPELabel.Text = "Type";
            // 
            // sERVICEBindingNavigator
            // 
            this.sERVICEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sERVICEBindingNavigator.BindingSource = this.bs;
            this.sERVICEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sERVICEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sERVICEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sERVICEBindingNavigatorSaveItem});
            this.sERVICEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sERVICEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sERVICEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sERVICEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sERVICEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sERVICEBindingNavigator.Name = "sERVICEBindingNavigator";
            this.sERVICEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sERVICEBindingNavigator.Size = new System.Drawing.Size(396, 25);
            this.sERVICEBindingNavigator.TabIndex = 0;
            this.sERVICEBindingNavigator.Text = "bindingNavigator1";
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
            this.bs.DataSource = typeof(Projet_Developpement.SERVICE);
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
            // sERVICEBindingNavigatorSaveItem
            // 
            this.sERVICEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sERVICEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sERVICEBindingNavigatorSaveItem.Image")));
            this.sERVICEBindingNavigatorSaveItem.Name = "sERVICEBindingNavigatorSaveItem";
            this.sERVICEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.sERVICEBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.sERVICEBindingNavigatorSaveItem.Click += new System.EventHandler(this.sERVICEBindingNavigatorSaveItem_Click_1);
            // 
            // sERVICE_CAPACITETextBox
            // 
            this.sERVICE_CAPACITETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "SERVICE_CAPACITE", true));
            this.sERVICE_CAPACITETextBox.Location = new System.Drawing.Point(200, 146);
            this.sERVICE_CAPACITETextBox.Name = "sERVICE_CAPACITETextBox";
            this.sERVICE_CAPACITETextBox.Size = new System.Drawing.Size(114, 20);
            this.sERVICE_CAPACITETextBox.TabIndex = 2;
            // 
            // sERVICE_DESIGNATIONTextBox
            // 
            this.sERVICE_DESIGNATIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "SERVICE_DESIGNATION", true));
            this.sERVICE_DESIGNATIONTextBox.Location = new System.Drawing.Point(200, 75);
            this.sERVICE_DESIGNATIONTextBox.Name = "sERVICE_DESIGNATIONTextBox";
            this.sERVICE_DESIGNATIONTextBox.Size = new System.Drawing.Size(114, 20);
            this.sERVICE_DESIGNATIONTextBox.TabIndex = 4;
            // 
            // sERVICE_TYPETextBox
            // 
            this.sERVICE_TYPETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "SERVICE_TYPE", true));
            this.sERVICE_TYPETextBox.Location = new System.Drawing.Point(200, 110);
            this.sERVICE_TYPETextBox.Name = "sERVICE_TYPETextBox";
            this.sERVICE_TYPETextBox.Size = new System.Drawing.Size(114, 20);
            this.sERVICE_TYPETextBox.TabIndex = 8;
            // 
            // list_ajoutserv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 209);
            this.Controls.Add(sERVICE_CAPACITELabel);
            this.Controls.Add(this.sERVICE_CAPACITETextBox);
            this.Controls.Add(sERVICE_DESIGNATIONLabel);
            this.Controls.Add(this.sERVICE_DESIGNATIONTextBox);
            this.Controls.Add(sERVICE_TYPELabel);
            this.Controls.Add(this.sERVICE_TYPETextBox);
            this.Controls.Add(this.sERVICEBindingNavigator);
            this.Name = "list_ajoutserv";
            this.Text = "Ajout de service";
            this.Load += new System.EventHandler(this.list_ajoutserv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sERVICEBindingNavigator)).EndInit();
            this.sERVICEBindingNavigator.ResumeLayout(false);
            this.sERVICEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.BindingNavigator sERVICEBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sERVICEBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox sERVICE_CAPACITETextBox;
        private System.Windows.Forms.TextBox sERVICE_DESIGNATIONTextBox;
        private System.Windows.Forms.TextBox sERVICE_TYPETextBox;
    }
}