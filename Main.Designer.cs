namespace Grimoire
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tvComputerMap = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmsComputerMap = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newComputerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pMain = new System.Windows.Forms.Panel();
            this.bSearch = new System.Windows.Forms.Button();
            this.tSearch = new System.Windows.Forms.TextBox();
            this.bModelUnlock = new System.Windows.Forms.Button();
            this.bModelLock = new System.Windows.Forms.Button();
            this.bAbout = new System.Windows.Forms.Button();
            this.bRun = new System.Windows.Forms.Button();
            this.bLock = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bOpen = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.pgConfig = new System.Windows.Forms.PropertyGrid();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lComputer = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bUp = new System.Windows.Forms.Button();
            this.bDown = new System.Windows.Forms.Button();
            this.bCopy = new System.Windows.Forms.Button();
            this.bPaste = new System.Windows.Forms.Button();
            this.bCut = new System.Windows.Forms.Button();
            this.bTrash = new System.Windows.Forms.Button();
            this.bNewFolder = new System.Windows.Forms.Button();
            this.bNewComputer = new System.Windows.Forms.Button();
            this.bChangeAll = new System.Windows.Forms.Button();
            this.pCommands = new System.Windows.Forms.Panel();
            this.cmsComputerMap.SuspendLayout();
            this.pMain.SuspendLayout();
            this.panel9.SuspendLayout();
            this.pCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvComputerMap
            // 
            this.tvComputerMap.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvComputerMap.FullRowSelect = true;
            this.tvComputerMap.HideSelection = false;
            this.tvComputerMap.ImageIndex = 0;
            this.tvComputerMap.ImageList = this.imageList1;
            this.tvComputerMap.Location = new System.Drawing.Point(0, 60);
            this.tvComputerMap.Name = "tvComputerMap";
            this.tvComputerMap.PathSeparator = " - ";
            this.tvComputerMap.SelectedImageIndex = 0;
            this.tvComputerMap.Size = new System.Drawing.Size(436, 494);
            this.tvComputerMap.TabIndex = 1;
            this.tvComputerMap.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "close-circle.png");
            this.imageList1.Images.SetKeyName(1, "computer.png");
            this.imageList1.Images.SetKeyName(2, "folder.png");
            this.imageList1.Images.SetKeyName(3, "downloading.png");
            this.imageList1.Images.SetKeyName(4, "folder-open.png");
            this.imageList1.Images.SetKeyName(5, "open-book.png");
            this.imageList1.Images.SetKeyName(6, "grimoire.png");
            this.imageList1.Images.SetKeyName(7, "lock.png");
            this.imageList1.Images.SetKeyName(8, "unlock.png");
            // 
            // cmsComputerMap
            // 
            this.cmsComputerMap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFolderToolStripMenuItem,
            this.newComputerToolStripMenuItem,
            this.duplicateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsComputerMap.Name = "cmsComputerMap";
            this.cmsComputerMap.Size = new System.Drawing.Size(156, 92);
            this.cmsComputerMap.Opening += new System.ComponentModel.CancelEventHandler(this.cmsComputerMap_Opening);
            // 
            // newFolderToolStripMenuItem
            // 
            this.newFolderToolStripMenuItem.Name = "newFolderToolStripMenuItem";
            this.newFolderToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.newFolderToolStripMenuItem.Text = "New Folder";
            this.newFolderToolStripMenuItem.Click += new System.EventHandler(this.newFolderToolStripMenuItem_Click);
            // 
            // newComputerToolStripMenuItem
            // 
            this.newComputerToolStripMenuItem.Name = "newComputerToolStripMenuItem";
            this.newComputerToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.newComputerToolStripMenuItem.Text = "New Computer";
            this.newComputerToolStripMenuItem.Click += new System.EventHandler(this.newComputerToolStripMenuItem_Click);
            // 
            // duplicateToolStripMenuItem
            // 
            this.duplicateToolStripMenuItem.Name = "duplicateToolStripMenuItem";
            this.duplicateToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.duplicateToolStripMenuItem.Text = "Duplicate";
            this.duplicateToolStripMenuItem.Click += new System.EventHandler(this.duplicateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.Color.Khaki;
            this.pMain.Controls.Add(this.bSearch);
            this.pMain.Controls.Add(this.tSearch);
            this.pMain.Controls.Add(this.bModelUnlock);
            this.pMain.Controls.Add(this.bModelLock);
            this.pMain.Controls.Add(this.bAbout);
            this.pMain.Controls.Add(this.bRun);
            this.pMain.Controls.Add(this.bLock);
            this.pMain.Controls.Add(this.bSave);
            this.pMain.Controls.Add(this.bOpen);
            this.pMain.Controls.Add(this.bNew);
            this.pMain.Controls.Add(this.bClose);
            this.pMain.Controls.Add(this.panel2);
            this.pMain.Controls.Add(this.panel4);
            this.pMain.Controls.Add(this.panel3);
            this.pMain.Controls.Add(this.panel1);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(1027, 60);
            this.pMain.TabIndex = 0;
            // 
            // bSearch
            // 
            this.bSearch.AccessibleDescription = "About";
            this.bSearch.BackgroundImage = global::Grimorie.Properties.Resources.search;
            this.bSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSearch.ImageList = this.imageList1;
            this.bSearch.Location = new System.Drawing.Point(727, 10);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(40, 40);
            this.bSearch.TabIndex = 8;
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // tSearch
            // 
            this.tSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSearch.Location = new System.Drawing.Point(384, 10);
            this.tSearch.Name = "tSearch";
            this.tSearch.Size = new System.Drawing.Size(342, 40);
            this.tSearch.TabIndex = 7;
            this.tSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tSearch_KeyPress);
            // 
            // bModelUnlock
            // 
            this.bModelUnlock.AccessibleDescription = "Save";
            this.bModelUnlock.BackgroundImage = global::Grimorie.Properties.Resources.unlock;
            this.bModelUnlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bModelUnlock.Dock = System.Windows.Forms.DockStyle.Left;
            this.bModelUnlock.ImageList = this.imageList1;
            this.bModelUnlock.Location = new System.Drawing.Point(290, 10);
            this.bModelUnlock.Name = "bModelUnlock";
            this.bModelUnlock.Size = new System.Drawing.Size(40, 40);
            this.bModelUnlock.TabIndex = 9;
            this.bModelUnlock.Tag = "1";
            this.bModelUnlock.UseVisualStyleBackColor = true;
            this.bModelUnlock.Visible = false;
            // 
            // bModelLock
            // 
            this.bModelLock.AccessibleDescription = "Save";
            this.bModelLock.BackgroundImage = global::Grimorie.Properties.Resources._lock;
            this.bModelLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bModelLock.Dock = System.Windows.Forms.DockStyle.Left;
            this.bModelLock.ImageList = this.imageList1;
            this.bModelLock.Location = new System.Drawing.Point(250, 10);
            this.bModelLock.Name = "bModelLock";
            this.bModelLock.Size = new System.Drawing.Size(40, 40);
            this.bModelLock.TabIndex = 8;
            this.bModelLock.Tag = "1";
            this.bModelLock.UseVisualStyleBackColor = true;
            this.bModelLock.Visible = false;
            // 
            // bAbout
            // 
            this.bAbout.AccessibleDescription = "About";
            this.bAbout.BackgroundImage = global::Grimorie.Properties.Resources.grimoire;
            this.bAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAbout.Dock = System.Windows.Forms.DockStyle.Left;
            this.bAbout.ImageList = this.imageList1;
            this.bAbout.Location = new System.Drawing.Point(210, 10);
            this.bAbout.Name = "bAbout";
            this.bAbout.Size = new System.Drawing.Size(40, 40);
            this.bAbout.TabIndex = 6;
            this.bAbout.UseVisualStyleBackColor = true;
            this.bAbout.Click += new System.EventHandler(this.button5_Click);
            // 
            // bRun
            // 
            this.bRun.AccessibleDescription = "Save";
            this.bRun.BackgroundImage = global::Grimorie.Properties.Resources.play;
            this.bRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bRun.Dock = System.Windows.Forms.DockStyle.Left;
            this.bRun.ImageList = this.imageList1;
            this.bRun.Location = new System.Drawing.Point(170, 10);
            this.bRun.Name = "bRun";
            this.bRun.Size = new System.Drawing.Size(40, 40);
            this.bRun.TabIndex = 13;
            this.bRun.UseVisualStyleBackColor = true;
            this.bRun.Click += new System.EventHandler(this.bRun_Click);
            // 
            // bLock
            // 
            this.bLock.AccessibleDescription = "Save";
            this.bLock.BackgroundImage = global::Grimorie.Properties.Resources.unlock;
            this.bLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bLock.Dock = System.Windows.Forms.DockStyle.Left;
            this.bLock.ImageList = this.imageList1;
            this.bLock.Location = new System.Drawing.Point(130, 10);
            this.bLock.Name = "bLock";
            this.bLock.Size = new System.Drawing.Size(40, 40);
            this.bLock.TabIndex = 3;
            this.bLock.Tag = "1";
            this.bLock.UseVisualStyleBackColor = true;
            this.bLock.Click += new System.EventHandler(this.bLock_Click);
            // 
            // bSave
            // 
            this.bSave.AccessibleDescription = "Save";
            this.bSave.BackgroundImage = global::Grimorie.Properties.Resources.floppy_disk;
            this.bSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.bSave.ImageList = this.imageList1;
            this.bSave.Location = new System.Drawing.Point(90, 10);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(40, 40);
            this.bSave.TabIndex = 2;
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.button4_Click);
            // 
            // bOpen
            // 
            this.bOpen.AccessibleDescription = "Open";
            this.bOpen.BackgroundImage = global::Grimorie.Properties.Resources.folder_open;
            this.bOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bOpen.Dock = System.Windows.Forms.DockStyle.Left;
            this.bOpen.ImageList = this.imageList1;
            this.bOpen.Location = new System.Drawing.Point(50, 10);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(40, 40);
            this.bOpen.TabIndex = 1;
            this.bOpen.UseVisualStyleBackColor = true;
            this.bOpen.Click += new System.EventHandler(this.button3_Click);
            // 
            // bNew
            // 
            this.bNew.AccessibleDescription = "New";
            this.bNew.BackgroundImage = global::Grimorie.Properties.Resources.add_file;
            this.bNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bNew.Dock = System.Windows.Forms.DockStyle.Left;
            this.bNew.ImageList = this.imageList1;
            this.bNew.Location = new System.Drawing.Point(10, 10);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(40, 40);
            this.bNew.TabIndex = 0;
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.button2_Click);
            // 
            // bClose
            // 
            this.bClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bClose.BackgroundImage")));
            this.bClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.bClose.ImageKey = "(none)";
            this.bClose.ImageList = this.imageList1;
            this.bClose.Location = new System.Drawing.Point(977, 10);
            this.bClose.Margin = new System.Windows.Forms.Padding(0);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(40, 40);
            this.bClose.TabIndex = 7;
            this.bClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1007, 10);
            this.panel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Khaki;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(10, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1007, 10);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Khaki;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1017, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 60);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 60);
            this.panel1.TabIndex = 0;
            // 
            // ssStatus
            // 
            this.ssStatus.Location = new System.Drawing.Point(0, 554);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(1027, 22);
            this.ssStatus.TabIndex = 2;
            this.ssStatus.Text = "statusStrip1";
            // 
            // pgConfig
            // 
            this.pgConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgConfig.Location = new System.Drawing.Point(436, 160);
            this.pgConfig.Name = "pgConfig";
            this.pgConfig.Size = new System.Drawing.Size(591, 394);
            this.pgConfig.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.lComputer);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(436, 60);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(591, 40);
            this.panel9.TabIndex = 4;
            // 
            // lComputer
            // 
            this.lComputer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lComputer.Location = new System.Drawing.Point(0, 0);
            this.lComputer.Name = "lComputer";
            this.lComputer.Size = new System.Drawing.Size(591, 40);
            this.lComputer.TabIndex = 0;
            this.lComputer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sfd
            // 
            this.sfd.DefaultExt = "grim";
            this.sfd.FileName = "new_grimoire1";
            this.sfd.Filter = "Grimoire Files|*.grim";
            this.sfd.Title = "Save the computer inventory schema";
            this.sfd.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // ofd
            // 
            this.ofd.DefaultExt = "grim";
            this.ofd.Filter = "Grimoire Files|*.grim";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 60);
            this.panel8.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(581, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 60);
            this.panel7.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(10, 50);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(571, 10);
            this.panel6.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(571, 10);
            this.panel5.TabIndex = 8;
            // 
            // bUp
            // 
            this.bUp.AccessibleDescription = "New";
            this.bUp.BackgroundImage = global::Grimorie.Properties.Resources.arrow_up;
            this.bUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bUp.Dock = System.Windows.Forms.DockStyle.Left;
            this.bUp.ImageList = this.imageList1;
            this.bUp.Location = new System.Drawing.Point(10, 10);
            this.bUp.Name = "bUp";
            this.bUp.Size = new System.Drawing.Size(40, 40);
            this.bUp.TabIndex = 6;
            this.bUp.UseVisualStyleBackColor = true;
            this.bUp.Click += new System.EventHandler(this.bUp_Click);
            // 
            // bDown
            // 
            this.bDown.AccessibleDescription = "Open";
            this.bDown.BackgroundImage = global::Grimorie.Properties.Resources.arrow_down;
            this.bDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bDown.Dock = System.Windows.Forms.DockStyle.Left;
            this.bDown.ImageList = this.imageList1;
            this.bDown.Location = new System.Drawing.Point(50, 10);
            this.bDown.Name = "bDown";
            this.bDown.Size = new System.Drawing.Size(40, 40);
            this.bDown.TabIndex = 7;
            this.bDown.UseVisualStyleBackColor = true;
            this.bDown.Click += new System.EventHandler(this.button8_Click);
            // 
            // bCopy
            // 
            this.bCopy.AccessibleDescription = "Save";
            this.bCopy.BackgroundImage = global::Grimorie.Properties.Resources.copy_files;
            this.bCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bCopy.Dock = System.Windows.Forms.DockStyle.Left;
            this.bCopy.ImageList = this.imageList1;
            this.bCopy.Location = new System.Drawing.Point(90, 10);
            this.bCopy.Name = "bCopy";
            this.bCopy.Size = new System.Drawing.Size(40, 40);
            this.bCopy.TabIndex = 8;
            this.bCopy.UseVisualStyleBackColor = true;
            this.bCopy.Click += new System.EventHandler(this.bCopy_Click);
            // 
            // bPaste
            // 
            this.bPaste.AccessibleDescription = "Save";
            this.bPaste.BackgroundImage = global::Grimorie.Properties.Resources.past;
            this.bPaste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPaste.Dock = System.Windows.Forms.DockStyle.Left;
            this.bPaste.ImageList = this.imageList1;
            this.bPaste.Location = new System.Drawing.Point(130, 10);
            this.bPaste.Name = "bPaste";
            this.bPaste.Size = new System.Drawing.Size(40, 40);
            this.bPaste.TabIndex = 9;
            this.bPaste.UseVisualStyleBackColor = true;
            this.bPaste.Click += new System.EventHandler(this.bPaste_Click);
            // 
            // bCut
            // 
            this.bCut.AccessibleDescription = "Save";
            this.bCut.BackgroundImage = global::Grimorie.Properties.Resources.cut;
            this.bCut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bCut.Dock = System.Windows.Forms.DockStyle.Left;
            this.bCut.ImageList = this.imageList1;
            this.bCut.Location = new System.Drawing.Point(170, 10);
            this.bCut.Name = "bCut";
            this.bCut.Size = new System.Drawing.Size(40, 40);
            this.bCut.TabIndex = 10;
            this.bCut.UseVisualStyleBackColor = true;
            this.bCut.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // bTrash
            // 
            this.bTrash.AccessibleDescription = "Save";
            this.bTrash.BackgroundImage = global::Grimorie.Properties.Resources.trash_bin;
            this.bTrash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bTrash.Dock = System.Windows.Forms.DockStyle.Left;
            this.bTrash.ImageList = this.imageList1;
            this.bTrash.Location = new System.Drawing.Point(210, 10);
            this.bTrash.Name = "bTrash";
            this.bTrash.Size = new System.Drawing.Size(40, 40);
            this.bTrash.TabIndex = 11;
            this.bTrash.UseVisualStyleBackColor = true;
            this.bTrash.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bNewFolder
            // 
            this.bNewFolder.AccessibleDescription = "About";
            this.bNewFolder.BackgroundImage = global::Grimorie.Properties.Resources.folder;
            this.bNewFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bNewFolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.bNewFolder.ImageList = this.imageList1;
            this.bNewFolder.Location = new System.Drawing.Point(250, 10);
            this.bNewFolder.Name = "bNewFolder";
            this.bNewFolder.Size = new System.Drawing.Size(40, 40);
            this.bNewFolder.TabIndex = 12;
            this.bNewFolder.UseVisualStyleBackColor = true;
            this.bNewFolder.Click += new System.EventHandler(this.bNewFolder_Click);
            // 
            // bNewComputer
            // 
            this.bNewComputer.AccessibleDescription = "About";
            this.bNewComputer.BackgroundImage = global::Grimorie.Properties.Resources.computer;
            this.bNewComputer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bNewComputer.Dock = System.Windows.Forms.DockStyle.Left;
            this.bNewComputer.ImageList = this.imageList1;
            this.bNewComputer.Location = new System.Drawing.Point(290, 10);
            this.bNewComputer.Name = "bNewComputer";
            this.bNewComputer.Size = new System.Drawing.Size(40, 40);
            this.bNewComputer.TabIndex = 13;
            this.bNewComputer.UseVisualStyleBackColor = true;
            this.bNewComputer.Click += new System.EventHandler(this.bNewComputer_Click);
            // 
            // bChangeAll
            // 
            this.bChangeAll.AccessibleDescription = "About";
            this.bChangeAll.BackgroundImage = global::Grimorie.Properties.Resources.document_list;
            this.bChangeAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bChangeAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.bChangeAll.ImageList = this.imageList1;
            this.bChangeAll.Location = new System.Drawing.Point(330, 10);
            this.bChangeAll.Name = "bChangeAll";
            this.bChangeAll.Size = new System.Drawing.Size(40, 40);
            this.bChangeAll.TabIndex = 14;
            this.bChangeAll.UseVisualStyleBackColor = true;
            this.bChangeAll.Click += new System.EventHandler(this.bChangeAll_Click);
            // 
            // pCommands
            // 
            this.pCommands.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pCommands.Controls.Add(this.bChangeAll);
            this.pCommands.Controls.Add(this.bNewComputer);
            this.pCommands.Controls.Add(this.bNewFolder);
            this.pCommands.Controls.Add(this.bTrash);
            this.pCommands.Controls.Add(this.bCut);
            this.pCommands.Controls.Add(this.bPaste);
            this.pCommands.Controls.Add(this.bCopy);
            this.pCommands.Controls.Add(this.bDown);
            this.pCommands.Controls.Add(this.bUp);
            this.pCommands.Controls.Add(this.panel5);
            this.pCommands.Controls.Add(this.panel6);
            this.pCommands.Controls.Add(this.panel7);
            this.pCommands.Controls.Add(this.panel8);
            this.pCommands.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCommands.Location = new System.Drawing.Point(436, 100);
            this.pCommands.Name = "pCommands";
            this.pCommands.Size = new System.Drawing.Size(591, 60);
            this.pCommands.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 576);
            this.Controls.Add(this.pgConfig);
            this.Controls.Add(this.pCommands);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.tvComputerMap);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.ssStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Grimoire - Computer Inventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.cmsComputerMap.ResumeLayout(false);
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.pCommands.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvComputerMap;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.PropertyGrid pgConfig;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bAbout;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bOpen;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.ContextMenuStrip cmsComputerMap;
        private System.Windows.Forms.ToolStripMenuItem newFolderToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem newComputerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateToolStripMenuItem;
        private System.Windows.Forms.Button bLock;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lComputer;
        private System.Windows.Forms.Button bModelUnlock;
        private System.Windows.Forms.Button bModelLock;
        private System.Windows.Forms.Button bRun;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.TextBox tSearch;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button bUp;
        private System.Windows.Forms.Button bDown;
        private System.Windows.Forms.Button bCopy;
        private System.Windows.Forms.Button bPaste;
        private System.Windows.Forms.Button bCut;
        private System.Windows.Forms.Button bTrash;
        private System.Windows.Forms.Button bNewFolder;
        private System.Windows.Forms.Button bNewComputer;
        private System.Windows.Forms.Button bChangeAll;
        private System.Windows.Forms.Panel pCommands;
    }
}

