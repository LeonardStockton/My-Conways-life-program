namespace My_Conways_Game_Of_Life
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hUDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nAHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toroidalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PuaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromSeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromCurrentSeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cellColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gridColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cellColorX10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.playToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.puaseToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.nextToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cellColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolStripStatusLabelGenerations = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TimerIntervalCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.CellsAliveCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.SeedCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.graphicsPanel1 = new My_Conways_Game_Of_Life.GraphicsPanel();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.randomizeToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "&Import";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hUDToolStripMenuItem,
            this.gridToolStripMenuItem,
            this.nAHToolStripMenuItem,
            this.toolStripSeparator3,
            this.toroidalToolStripMenuItem,
            this.finiteToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.toolsToolStripMenuItem.Text = "&View";
            // 
            // hUDToolStripMenuItem
            // 
            this.hUDToolStripMenuItem.Name = "hUDToolStripMenuItem";
            this.hUDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hUDToolStripMenuItem.Text = "HUD";
            // 
            // gridToolStripMenuItem
            // 
            this.gridToolStripMenuItem.Name = "gridToolStripMenuItem";
            this.gridToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gridToolStripMenuItem.Text = "Grid";
            // 
            // nAHToolStripMenuItem
            // 
            this.nAHToolStripMenuItem.Name = "nAHToolStripMenuItem";
            this.nAHToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nAHToolStripMenuItem.Text = "Neighbor Count";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // toroidalToolStripMenuItem
            // 
            this.toroidalToolStripMenuItem.Checked = true;
            this.toroidalToolStripMenuItem.CheckOnClick = true;
            this.toroidalToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toroidalToolStripMenuItem.Name = "toroidalToolStripMenuItem";
            this.toroidalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toroidalToolStripMenuItem.Text = "Toroidal";
            this.toroidalToolStripMenuItem.Click += new System.EventHandler(this.finiteToolStripMenuItem_Click);
            // 
            // finiteToolStripMenuItem
            // 
            this.finiteToolStripMenuItem.CheckOnClick = true;
            this.finiteToolStripMenuItem.Name = "finiteToolStripMenuItem";
            this.finiteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.finiteToolStripMenuItem.Text = "Finite";
            this.finiteToolStripMenuItem.Click += new System.EventHandler(this.toroidalToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.PuaseToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.helpToolStripMenuItem.Text = "&Run";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.contentsToolStripMenuItem.Text = "Start";
            this.contentsToolStripMenuItem.Click += new System.EventHandler(this.contentsToolStripMenuItem_Click);
            // 
            // PuaseToolStripMenuItem
            // 
            this.PuaseToolStripMenuItem.Name = "PuaseToolStripMenuItem";
            this.PuaseToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.PuaseToolStripMenuItem.Text = "Puase";
            this.PuaseToolStripMenuItem.Click += new System.EventHandler(this.indexToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.searchToolStripMenuItem.Text = "Next";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // toToolStripMenuItem
            // 
            this.toToolStripMenuItem.Name = "toToolStripMenuItem";
            this.toToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.toToolStripMenuItem.Text = "To";
            // 
            // randomizeToolStripMenuItem
            // 
            this.randomizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromSeedToolStripMenuItem,
            this.fromCurrentSeedToolStripMenuItem,
            this.fromTimeToolStripMenuItem});
            this.randomizeToolStripMenuItem.Name = "randomizeToolStripMenuItem";
            this.randomizeToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.randomizeToolStripMenuItem.Text = "R&andomize";
            // 
            // fromSeedToolStripMenuItem
            // 
            this.fromSeedToolStripMenuItem.Name = "fromSeedToolStripMenuItem";
            this.fromSeedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fromSeedToolStripMenuItem.Text = "From Seed ";
            this.fromSeedToolStripMenuItem.Click += new System.EventHandler(this.fromSeedToolStripMenuItem_Click);
            // 
            // fromCurrentSeedToolStripMenuItem
            // 
            this.fromCurrentSeedToolStripMenuItem.Name = "fromCurrentSeedToolStripMenuItem";
            this.fromCurrentSeedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fromCurrentSeedToolStripMenuItem.Text = "From Current Seed";
            // 
            // fromTimeToolStripMenuItem
            // 
            this.fromTimeToolStripMenuItem.Name = "fromTimeToolStripMenuItem";
            this.fromTimeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fromTimeToolStripMenuItem.Text = "From Time";
            this.fromTimeToolStripMenuItem.Click += new System.EventHandler(this.fromTimeToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundColorToolStripMenuItem1,
            this.cellColorToolStripMenuItem1,
            this.gridColorToolStripMenuItem,
            this.cellColorX10ToolStripMenuItem,
            this.toolStripSeparator4,
            this.optionsToolStripMenuItem1,
            this.toolStripSeparator5,
            this.resetToolStripMenuItem,
            this.reloadToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // backgroundColorToolStripMenuItem1
            // 
            this.backgroundColorToolStripMenuItem1.Name = "backgroundColorToolStripMenuItem1";
            this.backgroundColorToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.backgroundColorToolStripMenuItem1.Text = "Background Color";
            this.backgroundColorToolStripMenuItem1.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
            // 
            // cellColorToolStripMenuItem1
            // 
            this.cellColorToolStripMenuItem1.Name = "cellColorToolStripMenuItem1";
            this.cellColorToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cellColorToolStripMenuItem1.Text = "Cell Color";
            this.cellColorToolStripMenuItem1.Click += new System.EventHandler(this.cellColorToolStripMenuItem_Click);
            // 
            // gridColorToolStripMenuItem
            // 
            this.gridColorToolStripMenuItem.Name = "gridColorToolStripMenuItem";
            this.gridColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gridColorToolStripMenuItem.Text = "Grid Color ";
            this.gridColorToolStripMenuItem.Click += new System.EventHandler(this.gridColorToolStripMenuItem_Click);
            // 
            // cellColorX10ToolStripMenuItem
            // 
            this.cellColorX10ToolStripMenuItem.Name = "cellColorX10ToolStripMenuItem";
            this.cellColorX10ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cellColorX10ToolStripMenuItem.Text = "Grid Color x10";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.optionsToolStripMenuItem1.Text = "&Options";
            this.optionsToolStripMenuItem1.Click += new System.EventHandler(this.optionsToolStripMenuItem1_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(45, 20);
            this.helpToolStripMenuItem1.Text = "&Help";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator6,
            this.toolStripSeparator7,
            this.playToolStripButton1,
            this.puaseToolStripButton2,
            this.nextToolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(734, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // playToolStripButton1
            // 
            this.playToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.playToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("playToolStripButton1.Image")));
            this.playToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.playToolStripButton1.Name = "playToolStripButton1";
            this.playToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.playToolStripButton1.Text = "toolStripButton1";
            this.playToolStripButton1.Click += new System.EventHandler(this.contentsToolStripMenuItem_Click);
            // 
            // puaseToolStripButton2
            // 
            this.puaseToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.puaseToolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("puaseToolStripButton2.Image")));
            this.puaseToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.puaseToolStripButton2.Name = "puaseToolStripButton2";
            this.puaseToolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.puaseToolStripButton2.Text = "puaseToolStripButton2";
            this.puaseToolStripButton2.Click += new System.EventHandler(this.indexToolStripMenuItem_Click);
            // 
            // nextToolStripButton3
            // 
            this.nextToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nextToolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("nextToolStripButton3.Image")));
            this.nextToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nextToolStripButton3.Name = "nextToolStripButton3";
            this.nextToolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.nextToolStripButton3.Text = "toolStripButton3";
            this.nextToolStripButton3.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundColorToolStripMenuItem,
            this.cellColorToolStripMenuItem,
            this.modalToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(173, 70);
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.backgroundColorToolStripMenuItem.Text = "Background Color";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
            // 
            // cellColorToolStripMenuItem
            // 
            this.cellColorToolStripMenuItem.Name = "cellColorToolStripMenuItem";
            this.cellColorToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.cellColorToolStripMenuItem.Text = "Cell Color";
            this.cellColorToolStripMenuItem.Click += new System.EventHandler(this.cellColorToolStripMenuItem_Click);
            // 
            // modalToolStripMenuItem
            // 
            this.modalToolStripMenuItem.Name = "modalToolStripMenuItem";
            this.modalToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.modalToolStripMenuItem.Text = "Grid Color";
            // 
            // toolStripStatusLabelGenerations
            // 
            this.toolStripStatusLabelGenerations.Name = "toolStripStatusLabelGenerations";
            this.toolStripStatusLabelGenerations.Size = new System.Drawing.Size(82, 17);
            this.toolStripStatusLabelGenerations.Text = "Generations: 0";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelGenerations,
            this.TimerIntervalCounter,
            this.CellsAliveCounter,
            this.SeedCounter});
            this.statusStrip1.Location = new System.Drawing.Point(0, 404);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(734, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TimerIntervalCounter
            // 
            this.TimerIntervalCounter.Name = "TimerIntervalCounter";
            this.TimerIntervalCounter.Size = new System.Drawing.Size(58, 17);
            this.TimerIntervalCounter.Text = "Interval: 0";
            // 
            // CellsAliveCounter
            // 
            this.CellsAliveCounter.Name = "CellsAliveCounter";
            this.CellsAliveCounter.Size = new System.Drawing.Size(45, 17);
            this.CellsAliveCounter.Text = "Alive: 0";
            // 
            // SeedCounter
            // 
            this.SeedCounter.Name = "SeedCounter";
            this.SeedCounter.Size = new System.Drawing.Size(44, 17);
            this.SeedCounter.Text = "Seed: 0";
            this.SeedCounter.Click += new System.EventHandler(this.SeedCounter_Click);
            // 
            // graphicsPanel1
            // 
            this.graphicsPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.graphicsPanel1.ContextMenuStrip = this.contextMenuStrip1;
            this.graphicsPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphicsPanel1.Location = new System.Drawing.Point(0, 49);
            this.graphicsPanel1.Name = "graphicsPanel1";
            this.graphicsPanel1.Size = new System.Drawing.Size(734, 355);
            this.graphicsPanel1.TabIndex = 3;
            this.graphicsPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.graphicsPanel1_Paint);
            this.graphicsPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphicsPanel1_MouseClick);
            this.graphicsPanel1.SystemColorsChanged += new System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetToolStripMenuItem.Text = "&Reset";
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reloadToolStripMenuItem.Text = "R&eload";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 426);
            this.Controls.Add(this.graphicsPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conways Game of Life";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private GraphicsPanel graphicsPanel1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PuaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton playToolStripButton1;
        private System.Windows.Forms.ToolStripButton puaseToolStripButton2;
        private System.Windows.Forms.ToolStripButton nextToolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem randomizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromSeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromTimeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cellColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hUDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nAHToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toroidalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromCurrentSeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cellColorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gridColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cellColorX10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelGenerations;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TimerIntervalCounter;
        private System.Windows.Forms.ToolStripStatusLabel CellsAliveCounter;
        private System.Windows.Forms.ToolStripStatusLabel SeedCounter;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
    }
}

