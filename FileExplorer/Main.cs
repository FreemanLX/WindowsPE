using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace WindowsPE
{
    public partial class FileExplorer : Form
    {
        List<string> Forward = new List<string>();

        Icon folderIcon = AdaptiveMethods.GetIcon("shell32.dll", 3);
        Icon dllIcon = AdaptiveMethods.GetIcon("shell32.dll", 72);

        string backup;

        private void BackwardButton_Click(object sender, EventArgs e)
        {
            if (Forward.Count > 0)
            {
                if (!Forward[Forward.Count - 1].StartsWith("Search://"))
                {
                    LoadFromSelectedDirectory(Forward[Forward.Count - 1]);
                    Forward.RemoveAt(Forward.Count - 1);
                }
            }
        }

        string FileSizeConversion(long size)
        {
            if (size < 1024) return size.ToString() + " B";
            return (size / 1024).ToString() + " KB";
        }
        public FileExplorer()
        {
             InitializeComponent();
             fileImageTreeList.Images.Add(folderIcon);
             ContentGrid.MouseClick += ContentGrid_MouseClick;
        }

        private void SetFileInfo(FileInfo selectedFile)
        {
            DataGridViewImageCell nameCell = new DataGridViewImageCell() { ValueIsIcon = true };
            nameCell.Value = (selectedFile.Extension != ".dll") ? ExternalMethods.GetSmallIcon(selectedFile.FullName) : dllIcon;
            ContentGrid.Rows.Add(nameCell.Value, selectedFile.Name, selectedFile.LastWriteTime.ToString(), FileSizeConversion(selectedFile.Length));
        }

        void LoadFromSelectedDirectory(string data)
        {     
            ContentGrid.Rows.Clear();
            Location.Text = data;
            DirectoryInfo DirectoryList = new DirectoryInfo(data);

            foreach (DirectoryInfo directory in DirectoryList.GetDirectories())
            {
                if(!directory.Attributes.HasFlag(FileAttributes.Hidden))
                ContentGrid.Rows.Add(folderIcon, directory.Name, directory.LastWriteTimeUtc, "");
            }

            foreach (FileInfo fileInfo in DirectoryList.GetFiles())
            {
                 if (!fileInfo.IsReadOnly && !fileInfo.Attributes.HasFlag(FileAttributes.Hidden))
                 {
                     SetFileInfo(fileInfo);
                 }
            }
            
            backup = Location.Text;
        }


        private void locationBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Location.Text.Length > 0 && Directory.Exists(Location.Text))
                {
                     LoadFromSelectedDirectory(Location.Text);
                }
                else
                {
                    MessageBox.Show(this, $"Windows can't find '{Location.Text}'. Check the spelling and try again.", "File Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void GenerateTreeNode()
        {
            TreeNode root = new TreeNode
            {
                Text = "This PC", ImageIndex = 0
            };
            foreach (DriveInfo driver in DriveInfo.GetDrives())
            {
                if (driver.IsReady == true)
                {
                    TreeNode treeNode = new TreeNode
                    {
                        Text = ((driver.VolumeLabel == "") ? "Local Disk" : driver.VolumeLabel) + " (" + driver.Name.Split('\\')[0] + ")", Tag = driver.Name
                    };
                    switch (driver.DriveType)
                    {
                        case DriveType.CDRom:
                            treeNode.SelectedImageIndex = treeNode.ImageIndex = 2;
                            break;

                        case DriveType.Network:
                            treeNode.SelectedImageIndex = treeNode.ImageIndex = 3;
                            break;

                        default:
                            treeNode.SelectedImageIndex = treeNode.ImageIndex = 1;
                            break;

                    }
                    treeNode.Nodes.Add("Dummy");
                    root.Nodes.Add(treeNode);
                }
            }
            fileTreeView.Nodes.Add(root);


            fileTreeView.BeforeExpand += fileTreeView_BeforeExpand;
            fileTreeView.NodeMouseClick += new TreeNodeMouseClickEventHandler(fileTreeView_NodeMouseClick);
        }

        private void fileTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode selected = e.Node;
            if (selected.Tag != null)
                CreateDirectoryNode(new DirectoryInfo(selected.Tag as string), selected);
        }

        private void CreateDirectoryNode(DirectoryInfo directoryInfo, TreeNode directoryNode)
        {
            directoryNode.Nodes.Clear();
            try
            {
                DirectoryInfo[] directoriesInfo = directoryInfo.GetDirectories();
                foreach (var directory in directoriesInfo)
                {
                    if (directory.Exists && !directory.Attributes.HasFlag(FileAttributes.Hidden))
                    {
                        TreeNode treeNode = new TreeNode { Text = directory.Name, Tag = directory.FullName, SelectedImageIndex = 5 };
                        treeNode.ImageIndex = 5;
                        treeNode.Nodes.Add("Dummy");
                        directoryNode.Nodes.Add(treeNode);
                    }
                }
            }
            catch
            {
                return;
            }
        }


        private void fileTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode selected = e.Node;
            if (selected.Tag != null)
                LoadFromSelectedDirectory(selected.Tag as string);
        }

        private void FileExplorer_Load(object sender, EventArgs e)
        {
            GenerateTreeNode();
            Location.Text = Path.GetPathRoot(Environment.SystemDirectory);
            LoadFromSelectedDirectory(Location.Text);
        }

        public void Search(string filename, string locationPath)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(locationPath);
            try
            {
                foreach (FileInfo fileInfo in directoryInfo.GetFiles())
                {
                    if (fileInfo.Name.ToLower().Contains(filename))
                    {
                        Invoke(new Action(() => SetFileInfo(fileInfo)));
                    }
                }
            }
            catch
            {

            }

            try
            {
                foreach (DirectoryInfo directory in directoryInfo.GetDirectories())
                {
                    Search(filename, directory.FullName);
                }
            }
            catch
            {

            }
        }

        private void SearchBar_Click(object sender, EventArgs e) => SearchBar.Text = "";

        private void SearchBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string data = Location.Text;
            if (SearchBar.Text != "" && e.KeyChar == (char)13)
            {
                ContentGrid.Rows.Clear();
                Task.Run(() => Search(SearchBar.Text, data));
                backup = data;
            }
        }

        void MovingNextDirectory(string selectedPath)
        {
            if (File.GetAttributes(selectedPath).HasFlag(FileAttributes.Directory))
            {
                LoadFromSelectedDirectory(selectedPath);
            }
            else
            {
                if (File.Exists(selectedPath))
                {
                    try
                    {
                        System.Diagnostics.Process.Start(selectedPath);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Unable to open file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
        
        private void Refresh(string SelectedPath)
        {
            ContentGrid.Rows.Clear();
            LoadFromSelectedDirectory(SelectedPath);
        }

        private void CopyOperation(string SelectedPath, bool Move)
        {
            using (MemoryStream dropEffect = new MemoryStream())
            {
                byte[] aMoveEffect = BitConverter.GetBytes((Move) ? 2 : 1);
                dropEffect.Write(aMoveEffect, 0, aMoveEffect.Length);
                DataObject data = new DataObject();
                StringCollection paths = new StringCollection
                {
                    SelectedPath
                };
                data.SetFileDropList(paths);
                data.SetData("Preferred DropEffect", dropEffect);
                Clipboard.Clear();
                Clipboard.SetDataObject(data, true);
            }
        }

        private void Delete(string SelectedPath)
        {
              try
              {
                    if (MessageBox.Show("Do you really want to permanently delete the selected file", "Delete request", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (Directory.Exists(SelectedPath)) Directory.Delete(SelectedPath);
                        if (File.Exists(SelectedPath)) File.Delete(SelectedPath);
                        Refresh(new DirectoryInfo(SelectedPath).Parent.FullName);
                    }
              }
              catch(FileNotFoundException)
              {
                    MessageBox.Show("I can't delete the selected file", "File not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
              catch (DirectoryNotFoundException)
              {
                    MessageBox.Show("I can not delete the selected directory", "Directory not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
              catch (UnauthorizedAccessException)
              {
                    MessageBox.Show("You do not have access to delete the selected file", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
              catch (IOException)
              {
                    MessageBox.Show("You do not have access to delete the selected directory", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
        }

        private void Paste(string SelectedPath)
        {
            StringCollection files = Clipboard.GetFileDropList();

            bool move = false;

            var dataDropEffect = Clipboard.GetData("Preferred DropEffect");
            if (dataDropEffect != null)
            {
                 MemoryStream dropEffect = (MemoryStream)dataDropEffect;
                 byte[] aMoveEffect = new byte[4];
                 dropEffect.Read(aMoveEffect, 0, aMoveEffect.Length);
                 var aDragDropEffects = (DragDropEffects)BitConverter.ToInt32(aMoveEffect, 0);
                 move = aDragDropEffects.HasFlag(DragDropEffects.Move);
            }

            foreach (string file in files)
            {
                if (move) { } // Move File ...
                else { } // Copy File ...
            }
        }

        
        private void Rename(string SelectedPath)
        {
           
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (Location.Text.StartsWith("Search://"))
            {
                Forward.Add(Location.Text);
                SearchBar.Text = "Search";
                LoadFromSelectedDirectory(backup);
            }
            try
            {
                Forward.Add(backup);
                LoadFromSelectedDirectory(new DirectoryInfo(backup).Parent.FullName);
            }
            catch { Forward.RemoveAt(Forward.LastIndexOf(backup)); }
        }

        private void ContentGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) => MovingNextDirectory(Location.Text + "\\" + ContentGrid.SelectedRows[0].Cells[1].Value.ToString());

        private void ContentGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) {

                ContextMenu contextmenu = new ContextMenu();
                {
                    string SelectedPath = Location.Text + "\\" + ContentGrid.SelectedRows[0].Cells[1].Value.ToString();
                    contextmenu.MenuItems.Add(new MenuItem("Open", (object senderOpen, EventArgs eventArgs_open) => MovingNextDirectory(SelectedPath)));
                    contextmenu.MenuItems.Add(new MenuItem("-"));
                    contextmenu.MenuItems.Add(new MenuItem("Copy", (object SenderCopy, EventArgs eventArgs_copy) => CopyOperation(SelectedPath, false)));
                    contextmenu.MenuItems.Add(new MenuItem("Move", (object SenderMove, EventArgs eventArgs_move) => CopyOperation(SelectedPath, true)));
                    if (Clipboard.ContainsFileDropList())
                    {
                        contextmenu.MenuItems.Add(new MenuItem("Paste", (object SenderPaste, EventArgs eventArgs_move) => Paste(SelectedPath)));
                    }
                    contextmenu.MenuItems.Add(new MenuItem("Delete", (object SenderDelete, EventArgs eventArgs_delete) => Delete(SelectedPath)));
                    contextmenu.MenuItems.Add(new MenuItem("Rename", (object SenderRename, EventArgs eventArgs_rename) => Rename(SelectedPath)));
                    contextmenu.Show(this.ContentGrid, new Point(e.X, e.Y + 10));
                }
            }
        }

        private void ContentGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContentGrid.CurrentCell = ContentGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                ContentGrid.Rows[e.RowIndex].Selected = true;
                ContentGrid.Focus();   
            }
        }
    }
}