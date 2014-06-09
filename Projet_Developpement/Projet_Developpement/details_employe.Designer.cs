namespace Projet_Developpement
{
    partial class details_employe
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
            System.Windows.Forms.Label eMP_ADRESSELabel;
            System.Windows.Forms.Label eMP_CPLabel;
            System.Windows.Forms.Label eMP_IDLabel;
            System.Windows.Forms.Label eMP_MAILLabel;
            System.Windows.Forms.Label eMP_NOMLabel;
            System.Windows.Forms.Label eMP_PRENOMLabel;
            System.Windows.Forms.Label eMP_TELLabel;
            System.Windows.Forms.Label eMP_VILLELabel;
            System.Windows.Forms.Label leServiceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(details_employe));
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.bn = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.eMPLOYEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.eMP_ADRESSETextBox = new System.Windows.Forms.TextBox();
            this.eMP_CPTextBox = new System.Windows.Forms.TextBox();
            this.eMP_IDTextBox = new System.Windows.Forms.TextBox();
            this.eMP_MAILTextBox = new System.Windows.Forms.TextBox();
            this.eMP_NOMTextBox = new System.Windows.Forms.TextBox();
            this.eMP_PRENOMTextBox = new System.Windows.Forms.TextBox();
            this.eMP_TELTextBox = new System.Windows.Forms.TextBox();
            this.eMP_VILLETextBox = new System.Windows.Forms.TextBox();
            this.bs_diplome = new System.Windows.Forms.BindingSource(this.components);
            this.lesDiplomesListBox = new System.Windows.Forms.ListBox();
            this.bs_travaille_service = new System.Windows.Forms.BindingSource(this.components);
            this.cb_service = new System.Windows.Forms.ComboBox();
            this.bs_service = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_feminin = new System.Windows.Forms.RadioButton();
            this.rb_masculin = new System.Windows.Forms.RadioButton();
            eMP_ADRESSELabel = new System.Windows.Forms.Label();
            eMP_CPLabel = new System.Windows.Forms.Label();
            eMP_IDLabel = new System.Windows.Forms.Label();
            eMP_MAILLabel = new System.Windows.Forms.Label();
            eMP_NOMLabel = new System.Windows.Forms.Label();
            eMP_PRENOMLabel = new System.Windows.Forms.Label();
            eMP_TELLabel = new System.Windows.Forms.Label();
            eMP_VILLELabel = new System.Windows.Forms.Label();
            leServiceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn)).BeginInit();
            this.bn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_diplome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_travaille_service)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_service)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // eMP_ADRESSELabel
            // 
            eMP_ADRESSELabel.AutoSize = true;
            eMP_ADRESSELabel.BackColor = System.Drawing.Color.Transparent;
            eMP_ADRESSELabel.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold);
            eMP_ADRESSELabel.Location = new System.Drawing.Point(77, 156);
            eMP_ADRESSELabel.Name = "eMP_ADRESSELabel";
            eMP_ADRESSELabel.Size = new System.Drawing.Size(60, 29);
            eMP_ADRESSELabel.TabIndex = 1;
            eMP_ADRESSELabel.Text = "Adresse";
            // 
            // eMP_CPLabel
            // 
            eMP_CPLabel.AutoSize = true;
            eMP_CPLabel.BackColor = System.Drawing.Color.Transparent;
            eMP_CPLabel.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold);
            eMP_CPLabel.Location = new System.Drawing.Point(77, 208);
            eMP_CPLabel.Name = "eMP_CPLabel";
            eMP_CPLabel.Size = new System.Drawing.Size(84, 29);
            eMP_CPLabel.TabIndex = 3;
            eMP_CPLabel.Text = "Code postal";
            // 
            // eMP_IDLabel
            // 
            eMP_IDLabel.AutoSize = true;
            eMP_IDLabel.BackColor = System.Drawing.Color.Transparent;
            eMP_IDLabel.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold);
            eMP_IDLabel.Location = new System.Drawing.Point(77, 46);
            eMP_IDLabel.Name = "eMP_IDLabel";
            eMP_IDLabel.Size = new System.Drawing.Size(76, 29);
            eMP_IDLabel.TabIndex = 5;
            eMP_IDLabel.Text = "Identifiant";
            // 
            // eMP_MAILLabel
            // 
            eMP_MAILLabel.AutoSize = true;
            eMP_MAILLabel.BackColor = System.Drawing.Color.Transparent;
            eMP_MAILLabel.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold);
            eMP_MAILLabel.Location = new System.Drawing.Point(326, 46);
            eMP_MAILLabel.Name = "eMP_MAILLabel";
            eMP_MAILLabel.Size = new System.Drawing.Size(52, 29);
            eMP_MAILLabel.TabIndex = 7;
            eMP_MAILLabel.Text = "E-mail";
            // 
            // eMP_NOMLabel
            // 
            eMP_NOMLabel.AutoSize = true;
            eMP_NOMLabel.BackColor = System.Drawing.Color.Transparent;
            eMP_NOMLabel.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold);
            eMP_NOMLabel.Location = new System.Drawing.Point(77, 72);
            eMP_NOMLabel.Name = "eMP_NOMLabel";
            eMP_NOMLabel.Size = new System.Drawing.Size(40, 29);
            eMP_NOMLabel.TabIndex = 9;
            eMP_NOMLabel.Text = "Nom";
            // 
            // eMP_PRENOMLabel
            // 
            eMP_PRENOMLabel.AutoSize = true;
            eMP_PRENOMLabel.BackColor = System.Drawing.Color.Transparent;
            eMP_PRENOMLabel.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold);
            eMP_PRENOMLabel.Location = new System.Drawing.Point(78, 94);
            eMP_PRENOMLabel.Name = "eMP_PRENOMLabel";
            eMP_PRENOMLabel.Size = new System.Drawing.Size(59, 29);
            eMP_PRENOMLabel.TabIndex = 11;
            eMP_PRENOMLabel.Text = "Prénom";
            // 
            // eMP_TELLabel
            // 
            eMP_TELLabel.AutoSize = true;
            eMP_TELLabel.BackColor = System.Drawing.Color.Transparent;
            eMP_TELLabel.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold);
            eMP_TELLabel.Location = new System.Drawing.Point(327, 75);
            eMP_TELLabel.Name = "eMP_TELLabel";
            eMP_TELLabel.Size = new System.Drawing.Size(73, 29);
            eMP_TELLabel.TabIndex = 13;
            eMP_TELLabel.Text = "Téléphone";
            // 
            // eMP_VILLELabel
            // 
            eMP_VILLELabel.AutoSize = true;
            eMP_VILLELabel.BackColor = System.Drawing.Color.Transparent;
            eMP_VILLELabel.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold);
            eMP_VILLELabel.Location = new System.Drawing.Point(78, 182);
            eMP_VILLELabel.Name = "eMP_VILLELabel";
            eMP_VILLELabel.Size = new System.Drawing.Size(39, 29);
            eMP_VILLELabel.TabIndex = 15;
            eMP_VILLELabel.Text = "Ville";
            // 
            // leServiceLabel
            // 
            leServiceLabel.AutoSize = true;
            leServiceLabel.BackColor = System.Drawing.Color.Transparent;
            leServiceLabel.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold);
            leServiceLabel.Location = new System.Drawing.Point(78, 237);
            leServiceLabel.Name = "leServiceLabel";
            leServiceLabel.Size = new System.Drawing.Size(54, 29);
            leServiceLabel.TabIndex = 26;
            leServiceLabel.Text = "Service";
            // 
            // bs
            // 
            this.bs.DataSource = typeof(Projet_Developpement.EMPLOYE);
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
            this.eMPLOYEBindingNavigatorSaveItem});
            this.bn.Location = new System.Drawing.Point(0, 0);
            this.bn.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn.Name = "bn";
            this.bn.PositionItem = this.bindingNavigatorPositionItem;
            this.bn.Size = new System.Drawing.Size(568, 25);
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
            // eMPLOYEBindingNavigatorSaveItem
            // 
            this.eMPLOYEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eMPLOYEBindingNavigatorSaveItem.Enabled = false;
            this.eMPLOYEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eMPLOYEBindingNavigatorSaveItem.Image")));
            this.eMPLOYEBindingNavigatorSaveItem.Name = "eMPLOYEBindingNavigatorSaveItem";
            this.eMPLOYEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.eMPLOYEBindingNavigatorSaveItem.Text = "Enregistrer les données";
            // 
            // eMP_ADRESSETextBox
            // 
            this.eMP_ADRESSETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "EMP_ADRESSE", true));
            this.eMP_ADRESSETextBox.Location = new System.Drawing.Point(170, 161);
            this.eMP_ADRESSETextBox.Name = "eMP_ADRESSETextBox";
            this.eMP_ADRESSETextBox.Size = new System.Drawing.Size(100, 20);
            this.eMP_ADRESSETextBox.TabIndex = 2;
            // 
            // eMP_CPTextBox
            // 
            this.eMP_CPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "EMP_CP", true));
            this.eMP_CPTextBox.Location = new System.Drawing.Point(170, 213);
            this.eMP_CPTextBox.Name = "eMP_CPTextBox";
            this.eMP_CPTextBox.Size = new System.Drawing.Size(100, 20);
            this.eMP_CPTextBox.TabIndex = 4;
            // 
            // eMP_IDTextBox
            // 
            this.eMP_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "EMP_ID", true));
            this.eMP_IDTextBox.Location = new System.Drawing.Point(170, 51);
            this.eMP_IDTextBox.Name = "eMP_IDTextBox";
            this.eMP_IDTextBox.ReadOnly = true;
            this.eMP_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.eMP_IDTextBox.TabIndex = 6;
            // 
            // eMP_MAILTextBox
            // 
            this.eMP_MAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "EMP_MAIL", true));
            this.eMP_MAILTextBox.Location = new System.Drawing.Point(416, 51);
            this.eMP_MAILTextBox.Name = "eMP_MAILTextBox";
            this.eMP_MAILTextBox.Size = new System.Drawing.Size(100, 20);
            this.eMP_MAILTextBox.TabIndex = 8;
            // 
            // eMP_NOMTextBox
            // 
            this.eMP_NOMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "EMP_NOM", true));
            this.eMP_NOMTextBox.Location = new System.Drawing.Point(170, 77);
            this.eMP_NOMTextBox.Name = "eMP_NOMTextBox";
            this.eMP_NOMTextBox.Size = new System.Drawing.Size(100, 20);
            this.eMP_NOMTextBox.TabIndex = 10;
            // 
            // eMP_PRENOMTextBox
            // 
            this.eMP_PRENOMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "EMP_PRENOM", true));
            this.eMP_PRENOMTextBox.Location = new System.Drawing.Point(170, 103);
            this.eMP_PRENOMTextBox.Name = "eMP_PRENOMTextBox";
            this.eMP_PRENOMTextBox.Size = new System.Drawing.Size(100, 20);
            this.eMP_PRENOMTextBox.TabIndex = 12;
            // 
            // eMP_TELTextBox
            // 
            this.eMP_TELTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "EMP_TEL", true));
            this.eMP_TELTextBox.Location = new System.Drawing.Point(416, 80);
            this.eMP_TELTextBox.Name = "eMP_TELTextBox";
            this.eMP_TELTextBox.Size = new System.Drawing.Size(100, 20);
            this.eMP_TELTextBox.TabIndex = 14;
            // 
            // eMP_VILLETextBox
            // 
            this.eMP_VILLETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "EMP_VILLE", true));
            this.eMP_VILLETextBox.Location = new System.Drawing.Point(170, 187);
            this.eMP_VILLETextBox.Name = "eMP_VILLETextBox";
            this.eMP_VILLETextBox.Size = new System.Drawing.Size(100, 20);
            this.eMP_VILLETextBox.TabIndex = 16;
            // 
            // bs_diplome
            // 
            this.bs_diplome.DataMember = "LesDiplomes";
            this.bs_diplome.DataSource = this.bs;
            // 
            // lesDiplomesListBox
            // 
            this.lesDiplomesListBox.DataSource = this.bs_diplome;
            this.lesDiplomesListBox.DisplayMember = "DIPLOME_NOM";
            this.lesDiplomesListBox.FormattingEnabled = true;
            this.lesDiplomesListBox.Location = new System.Drawing.Point(143, 326);
            this.lesDiplomesListBox.Name = "lesDiplomesListBox";
            this.lesDiplomesListBox.Size = new System.Drawing.Size(235, 69);
            this.lesDiplomesListBox.TabIndex = 17;
            this.lesDiplomesListBox.ValueMember = "DIPLOME_ID";
            // 
            // bs_travaille_service
            // 
            this.bs_travaille_service.DataMember = "TRAVAILLE";
            this.bs_travaille_service.DataSource = this.bs;
            // 
            // cb_service
            // 
            this.cb_service.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bs_travaille_service, "LeService", true));
            this.cb_service.DataSource = this.bs_service;
            this.cb_service.DisplayMember = "SERVICE_DESIGNATION";
            this.cb_service.FormattingEnabled = true;
            this.cb_service.Location = new System.Drawing.Point(170, 239);
            this.cb_service.Name = "cb_service";
            this.cb_service.Size = new System.Drawing.Size(100, 21);
            this.cb_service.TabIndex = 27;
            // 
            // bs_service
            // 
            this.bs_service.DataSource = typeof(Projet_Developpement.SERVICE);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rb_masculin);
            this.groupBox1.Controls.Add(this.rb_feminin);
            this.groupBox1.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(337, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 76);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexe";
            // 
            // rb_feminin
            // 
            this.rb_feminin.AutoSize = true;
            this.rb_feminin.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bs, "IsFemme", true));
            this.rb_feminin.Location = new System.Drawing.Point(32, 32);
            this.rb_feminin.Name = "rb_feminin";
            this.rb_feminin.Size = new System.Drawing.Size(38, 33);
            this.rb_feminin.TabIndex = 0;
            this.rb_feminin.TabStop = true;
            this.rb_feminin.Text = "F";
            this.rb_feminin.UseVisualStyleBackColor = true;
            // 
            // rb_masculin
            // 
            this.rb_masculin.AutoSize = true;
            this.rb_masculin.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bs, "IsHomme", true));
            this.rb_masculin.Location = new System.Drawing.Point(99, 32);
            this.rb_masculin.Name = "rb_masculin";
            this.rb_masculin.Size = new System.Drawing.Size(41, 33);
            this.rb_masculin.TabIndex = 1;
            this.rb_masculin.TabStop = true;
            this.rb_masculin.Text = "H";
            this.rb_masculin.UseVisualStyleBackColor = true;
            // 
            // details_employe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(568, 407);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(leServiceLabel);
            this.Controls.Add(this.cb_service);
            this.Controls.Add(this.lesDiplomesListBox);
            this.Controls.Add(eMP_ADRESSELabel);
            this.Controls.Add(this.eMP_ADRESSETextBox);
            this.Controls.Add(eMP_CPLabel);
            this.Controls.Add(this.eMP_CPTextBox);
            this.Controls.Add(eMP_IDLabel);
            this.Controls.Add(this.eMP_IDTextBox);
            this.Controls.Add(eMP_MAILLabel);
            this.Controls.Add(this.eMP_MAILTextBox);
            this.Controls.Add(eMP_NOMLabel);
            this.Controls.Add(this.eMP_NOMTextBox);
            this.Controls.Add(eMP_PRENOMLabel);
            this.Controls.Add(this.eMP_PRENOMTextBox);
            this.Controls.Add(eMP_TELLabel);
            this.Controls.Add(this.eMP_TELTextBox);
            this.Controls.Add(eMP_VILLELabel);
            this.Controls.Add(this.eMP_VILLETextBox);
            this.Controls.Add(this.bn);
            this.Name = "details_employe";
            this.Text = "details_emp";
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn)).EndInit();
            this.bn.ResumeLayout(false);
            this.bn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_diplome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_travaille_service)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_service)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton eMPLOYEBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox eMP_ADRESSETextBox;
        private System.Windows.Forms.TextBox eMP_CPTextBox;
        private System.Windows.Forms.TextBox eMP_IDTextBox;
        private System.Windows.Forms.TextBox eMP_MAILTextBox;
        private System.Windows.Forms.TextBox eMP_NOMTextBox;
        private System.Windows.Forms.TextBox eMP_PRENOMTextBox;
        private System.Windows.Forms.TextBox eMP_TELTextBox;
        private System.Windows.Forms.TextBox eMP_VILLETextBox;
        private System.Windows.Forms.BindingSource bs_diplome;
        private System.Windows.Forms.ListBox lesDiplomesListBox;
        private System.Windows.Forms.BindingSource bs_travaille_service;
        private System.Windows.Forms.ComboBox cb_service;
        private System.Windows.Forms.BindingSource bs_service;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_masculin;
        private System.Windows.Forms.RadioButton rb_feminin;
    }
}