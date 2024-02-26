using Grimorie;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml;
using System.IO;
using System.Threading;


namespace Grimoire
{
    public partial class Main : Form
    {
        public TreeNode Copied = null;
        public TreeNode Cuted = null;
        public TreeNode CutedParent = null;
        bool firstActivate = true;

        public Main()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (((ClassObjGrimoire)e.Node.Tag).isComputer)
            {
                pgConfig.SelectedObject = e.Node.Tag as object;

                string textParent = e.Node.Parent == null ? "" : e.Node.Parent.FullPath + " - ";
                lComputer.Text = textParent + e.Node.Text;
            }
            else
            {
                pgConfig.SelectedObject = (new ClassGrimoireFolder(((ClassObjGrimoire)e.Node.Tag))) as object;

                string textParent = e.Node.Parent == null ? "" : e.Node.Parent.FullPath + " - ";
                lComputer.Text = textParent + e.Node.Text;

            }
        }

        private void Lock()
        {
            bLock.Tag = "1";
            bLock_Click(null, null);
        }


        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmsComputerMap_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tvComputerMap.Nodes.Clear();

            ClassObjGrimoire folder = new ClassObjGrimoire();
            folder.Name = "Root";
            folder.isComputer = false;

            TreeNode iItem = new TreeNode();
            iItem.Text = folder.Name;
            iItem.ImageIndex = 2;
            iItem.SelectedImageIndex = 2;
            iItem.ContextMenuStrip = cmsComputerMap;
            iItem.Tag = folder;
            folder.Owner = iItem;

            tvComputerMap.Nodes.Add(iItem);
            tvComputerMap.SelectedNode = iItem;
        }

        private ClassObjGrimoire RecursiveCreateList(TreeNode nd)
        {
            ClassObjGrimoire itemGirmoire = ((ClassObjGrimoire)nd.Tag).Duplicate();

            foreach (TreeNode item in nd.Nodes)
                itemGirmoire.Children.Add(RecursiveCreateList(item));

            return itemGirmoire;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = sfd.ShowDialog();

                if (dr != DialogResult.OK)
                    return;

                List<ClassObjGrimoire> json = new List<ClassObjGrimoire>();

                json.Add(RecursiveCreateList(tvComputerMap.Nodes[0]));

                string ret = JsonConvert.SerializeObject(json);

                File.WriteAllText(sfd.FileName, ret);

                Grimorie.Properties.Settings.Default.PathFile = sfd.FileName;
                Grimorie.Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return;
        }

        private void RecursiveCreateTreeView(ClassObjGrimoire grim)
        {
            tvComputerMap.Nodes.Clear();

            if (grim.isComputer)
                return;

            TreeNode iItem = new TreeNode();
            iItem.Text = grim.Name;
            iItem.ImageIndex = 2;
            iItem.SelectedImageIndex = 2;
            iItem.ContextMenuStrip = cmsComputerMap;
            iItem.Tag = grim;
            grim.Owner = iItem;

            tvComputerMap.Nodes.Add(iItem);
            tvComputerMap.SelectedNode = iItem;

            foreach (ClassObjGrimoire item in grim.Children)
            {
                RecursiveCreateTreeView(iItem, item);
            }
        }

        private void RecursiveCreateTreeView(TreeNode nodeParent, ClassObjGrimoire grim)
        {
            TreeNode iItem;

            if (grim.isComputer)
                iItem = AddComputer(nodeParent, (ClassObjGrimoire)grim);
            else
                iItem = AddFolder(nodeParent, grim);

            foreach (ClassObjGrimoire item in grim.Children)
            {
                RecursiveCreateTreeView(iItem, item);
            }
        }

        private void Open(string path)
        {
            try
            {
                string js = File.ReadAllText(path);

                List<ClassObjGrimoire> json = JsonConvert.DeserializeObject<List<ClassObjGrimoire>>(js);

                if (json.Count < 1)
                    return;

                RecursiveCreateTreeView(json[0]);
                Lock();

                if (tvComputerMap.Nodes.Count >= 1)
                {
                    tvComputerMap.Nodes[0].Collapse(false);
                    tvComputerMap.Nodes[0].Expand();
                }
            }
            catch (Exception ex)
            {
                int x = 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = ofd.ShowDialog();

            if (dr != DialogResult.OK)
                return;

            Open(ofd.FileName);

            Grimorie.Properties.Settings.Default.PathFile = ofd.FileName;
            Grimorie.Properties.Settings.Default.Save();

            return;
        }

        private TreeNode AddComputer(TreeNode Position, ClassObjGrimoire computer)
        {
            TreeNode iItem = new TreeNode();
            iItem.Text = computer.Name;
            iItem.ImageIndex = 1;
            iItem.SelectedImageIndex = 1;
            iItem.ContextMenuStrip = cmsComputerMap;
            iItem.Tag = computer;
            computer.Owner = iItem;

            Position.Nodes.Add(iItem);
            Position.Expand();

            tvComputerMap.SelectedNode = iItem;

            return iItem;
        }

        private TreeNode AddFolder(TreeNode Position, ClassObjGrimoire folder)
        {
            TreeNode iItem = new TreeNode();
            iItem.Text = folder.Name;
            iItem.ImageIndex = 2;
            iItem.SelectedImageIndex = 2;
            iItem.ContextMenuStrip = cmsComputerMap;
            iItem.Tag = folder;
            folder.Owner = iItem;

            Position.Nodes.Add(iItem);
            Position.Expand();

            tvComputerMap.SelectedNode = iItem;

            return iItem;
        }

        private TreeNode CopyNode(TreeNode CopedOne)
        {
            TreeNode iItem = new TreeNode();
            iItem.Text = CopedOne.Text;
            iItem.ImageIndex = CopedOne.ImageIndex;
            iItem.SelectedImageIndex = CopedOne.SelectedImageIndex;
            iItem.ContextMenuStrip = cmsComputerMap;
            iItem.Tag = ((ClassObjGrimoire)CopedOne.Tag).Duplicate();
            ((ClassObjGrimoire)iItem.Tag).Owner = iItem;

            foreach (TreeNode Node in CopedOne.Nodes)
                iItem.Nodes.Add(CopyNode(Node));

            return iItem;
        }

        private void DuplicateNode(TreeNode Position)
        {
            DuplicateNode(Position, Position.Parent);
        }

        private void DuplicateNode(TreeNode Position, TreeNode Parent)
        {
            TreeNode iItem = new TreeNode();
            iItem.Text = Position.Text;
            iItem.ImageIndex = Position.ImageIndex;
            iItem.SelectedImageIndex = Position.SelectedImageIndex;
            iItem.ContextMenuStrip = cmsComputerMap;
            iItem.Tag = ((ClassObjGrimoire)Position.Tag).Duplicate();
            ((ClassObjGrimoire)iItem.Tag).Owner = iItem;

            Parent.Nodes.Add(iItem);
            Parent.Expand();
            tvComputerMap.SelectedNode = iItem;

            foreach (TreeNode item in Position.Nodes)
                DuplicateNode(item, iItem);
        }

        private void newFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tvComputerMap.SelectedNode == null)
                return;

            ClassObjGrimoire nFolder = new ClassObjGrimoire();
            nFolder.Name = "New Folder";
            nFolder.isComputer = false;

            if (((ClassObjGrimoire)(tvComputerMap.SelectedNode.Tag)).isComputer)
                AddFolder(tvComputerMap.SelectedNode.Parent, nFolder);
            else
                AddFolder(tvComputerMap.SelectedNode, nFolder);
        }

        private void newComputerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tvComputerMap.SelectedNode == null)
                return;

            ClassObjGrimoire computer = new ClassObjGrimoire();
            computer.Name = "New Computer";
            computer.isComputer = true;

            if (((ClassObjGrimoire)(tvComputerMap.SelectedNode.Tag)).isComputer)
                AddComputer(tvComputerMap.SelectedNode.Parent, computer);
            else
                AddComputer(tvComputerMap.SelectedNode, computer);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tvComputerMap.SelectedNode == null)
                return;

            if (tvComputerMap.SelectedNode.Parent == null)
                return;

            tvComputerMap.SelectedNode.Parent.Nodes.Remove(tvComputerMap.SelectedNode);

        }

        private void duplicateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tvComputerMap.SelectedNode == null)
                return;

            if (tvComputerMap.SelectedNode.Parent == null)
                return;

            DuplicateNode(tvComputerMap.SelectedNode);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (tvComputerMap.SelectedNode == null)
                return;

            if (tvComputerMap.SelectedNode.Parent == null)
                return;

            TreeNode Selected = tvComputerMap.SelectedNode;

            int index = Selected.Parent.Nodes.IndexOf(Selected);

            if (index >= Selected.Parent.Nodes.Count - 1)
                return;

            TreeNode Parent = Selected.Parent;

            Parent.Nodes.Remove(Selected);
            Parent.Nodes.Insert(index + 1, Selected);

            tvComputerMap.SelectedNode = Selected;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Copied = tvComputerMap.SelectedNode;
            Cuted = tvComputerMap.SelectedNode;
            CutedParent = tvComputerMap.SelectedNode.Parent;
        }

        private void bUp_Click(object sender, EventArgs e)
        {
            if (tvComputerMap.SelectedNode == null)
                return;

            if (tvComputerMap.SelectedNode.Parent == null)
                return;

            TreeNode Selected = tvComputerMap.SelectedNode;

            int index = Selected.Parent.Nodes.IndexOf(Selected);

            if (index < 1)
                return;

            TreeNode Parent = Selected.Parent;

            Parent.Nodes.Remove(Selected);
            Parent.Nodes.Insert(index - 1, Selected);

            tvComputerMap.SelectedNode = Selected;
        }

        private void bCopy_Click(object sender, EventArgs e)
        {
            Copied = CopyNode(tvComputerMap.SelectedNode);
        }

        private void bPaste_Click(object sender, EventArgs e)
        {
            if (Copied == null)
                return;

            if (Cuted == null)
            {
                if (((ClassObjGrimoire)(tvComputerMap.SelectedNode.Tag)).isComputer)
                    tvComputerMap.SelectedNode.Parent.Nodes.Add(CopyNode(Copied));
                else
                    tvComputerMap.SelectedNode.Nodes.Add(CopyNode(Copied));
            }
            else
            {
                Cuted = null;

                if (CutedParent == null)
                    return;

                CutedParent.Nodes.Remove(Copied);
                CutedParent = null;

                if (((ClassObjGrimoire)(tvComputerMap.SelectedNode.Tag)).isComputer)
                    tvComputerMap.SelectedNode.Parent.Nodes.Add(Copied);
                else
                    tvComputerMap.SelectedNode.Nodes.Add(Copied);

                Copied = null;
            }
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            if (firstActivate)
            {
                button2_Click(null, null);
                firstActivate = false;

                toolTip1.SetToolTip(bNew, "Create a new computer inventory schema");
                toolTip1.SetToolTip(bOpen, "Open an existing computer inventory schema");
                toolTip1.SetToolTip(bSave, "Save the current computer inventory schema");
                toolTip1.SetToolTip(bLock, "Lock/Unlock the current computer inventory schema");
                toolTip1.SetToolTip(bRun, "Run a saved script for the current computer");
                toolTip1.SetToolTip(bAbout, "Show information about this software");
                toolTip1.SetToolTip(bUp, "Move the current folder/computer up");
                toolTip1.SetToolTip(bDown, "Move the current folder/computer down");
                toolTip1.SetToolTip(bCopy, "Copy the current folder/computer and its child items");
                toolTip1.SetToolTip(bPaste, "Paste the last copied/cut folder/computer");
                toolTip1.SetToolTip(bCut, "Cut the current folder/computer and its child items");
                toolTip1.SetToolTip(bTrash, "Delete the current folder/computer and its child items");
                toolTip1.SetToolTip(bNewFolder, "Create a new folder");
                toolTip1.SetToolTip(bNewComputer, "Create a new computer");
                toolTip1.SetToolTip(bClose, "Close this application");
                toolTip1.SetToolTip(bChangeAll, "Change values of all computers inside this folder");
                toolTip1.SetToolTip(bSearch, "Search for a specific computer");


                if (File.Exists(Grimorie.Properties.Settings.Default.PathFile))
                {
                    Open(Grimorie.Properties.Settings.Default.PathFile);
                }                
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            deleteToolStripMenuItem_Click(null, null);
        }

        private void bLock_Click(object sender, EventArgs e)
        {
            bool bEnabled = bLock.Tag.ToString() == "1";
            bEnabled = !bEnabled;

            bLock.Tag = bEnabled ? "1" : "0";

            pCommands.Enabled = bEnabled;

            if (bEnabled)
                bLock.BackgroundImage = bModelUnlock.BackgroundImage;
            else
                bLock.BackgroundImage = bModelLock.BackgroundImage;
        }

        private void bNewFolder_Click(object sender, EventArgs e)
        {
            newFolderToolStripMenuItem_Click(null, null);
        }

        private void bNewComputer_Click(object sender, EventArgs e)
        {
            newComputerToolStripMenuItem_Click(null, null);
        }

        private void bRun_Click(object sender, EventArgs e)
        {
            if (!((ClassObjGrimoire)(tvComputerMap.SelectedNode.Tag)).isComputer)
                return;

            Execute exc = new Execute();

            exc.data.DataSource = ((ClassObjGrimoire)(tvComputerMap.SelectedNode.Tag)).GetScripts();

            exc.ShowDialog();

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void RecursiveChange(TreeNode current, ClassObjGrimoire model)
        {
            ClassObjGrimoire _current = (ClassObjGrimoire)current.Tag;

            if (_current.isComputer)
                _current.Copy(model);

            foreach (TreeNode item in current.Nodes)
                RecursiveChange(item, model);
        }

        private void bChangeAll_Click(object sender, EventArgs e)
        {
            if (((ClassObjGrimoire)(tvComputerMap.SelectedNode.Tag)).isComputer)
                return;

            ChangeAll frm = new ChangeAll();
            frm.pgChangeAll.SelectedObject = new ClassObjGrimoire() as object;
            frm.ShowDialog();

            if (!frm.Canceled)
                RecursiveChange(tvComputerMap.SelectedNode, (ClassObjGrimoire)frm.pgChangeAll.SelectedObject);
        }

        TreeNode RecursiveSearch(TreeNode current, string search)
        {
            if (current == null) return null;

            ClassObjGrimoire _current = (ClassObjGrimoire)current.Tag;

            if (_current.Name != null) if (_current.Name.ToUpper().Contains(search)) return current;
            if (_current.Description != null) if (_current.Description.ToUpper().Contains(search)) return current;
            if (_current.Host != null) if (_current.Host.ToUpper().Contains(search)) return current;
            if (_current.IP != null) if (_current.IP.ToUpper().Contains(search)) return current;
            if (_current.Observation1 != null) if (_current.Observation1.ToUpper().Contains(search)) return current;
            if (_current.Observation2 != null) if (_current.Observation2.ToUpper().Contains(search)) return current;
            if (_current.Observation3 != null) if (_current.Observation3.ToUpper().Contains(search)) return current;

            TreeNode child = null;

            foreach (TreeNode item in current.Nodes)
            {
                child = RecursiveSearch(item, search);

                if (child != null)
                    break;
            }

            return child;
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            if (tSearch.Text.Trim() == "")
                return;

            string sSearch = tSearch.Text.ToUpper();

            if (tvComputerMap.Nodes.Count < 1) 
                return;

            TreeNode Find = RecursiveSearch(tvComputerMap.Nodes[0], sSearch);

            if (Find != null)
            {
                tvComputerMap.SelectedNode = Find;
            }
        }

        private void tSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                bSearch_Click(null, null);
        }
    }
}
