using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Collections.Specialized;
using FileExplorer.Properties;

namespace WindowsPE
{
    public partial class File_explorer : Form
    {
        DirectoryInfo DirectoryList;
        int index = 0;
        List<Icon> icons = new List<Icon>();
        public File_explorer()
        {
             InitializeComponent();
             icons = AdaptiveMethods.getIcons(); 
        }
        
        List<string> Forward = new List<string>();
        string backup;

        void LoadFromSelectedDirectory(string data)
        {     
            ContentGrid.Rows.Clear();
            Location.Text = data;
            DirectoryList = new DirectoryInfo(data);
            FileInfo[] files = DirectoryList.GetFiles();
            DirectoryInfo[] directories = DirectoryList.GetDirectories();

            foreach (DirectoryInfo directory in directories)
            {
                try
                {
                    directory.GetDirectories();
                    DataGridViewImageCell nameCell = new DataGridViewImageCell
                    {
                        Value = icons[4],
                        ValueIsIcon = true
                    };
                    ContentGrid.Rows.Add(icons[4], directory.Name, directory.LastWriteTimeUtc, "");
                }
                catch
                {
                     continue; 
                }    
            }
            
            foreach (FileInfo fileInfo in files)
            {
                if(!fileInfo.IsReadOnly && !fileInfo.Attributes.HasFlag(FileAttributes.Hidden))
                SetupItem(fileInfo);
            }
            backup = Location.Text;
        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Location.Text.Length > 0)
                {
                    try 
                    {
                        LoadFromSelectedDirectory(Location.Text);
                    }
                    catch(DirectoryNotFoundException)
                    {
                        MessageBox.Show("Can not found the selected directory", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LoadFromSelectedDirectory(backup);
                    }
                    catch (IOException ioexception)
                    {
                        MessageBox.Show(ioexception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LoadFromSelectedDirectory(backup);
                    }
               }
            }
        }
      
        private void File_explorer_Load(object sender, EventArgs e)
        {
            TreeNode root = new TreeNode
            {
                Text = "This PC",
                ImageIndex = 0
            };
            foreach (DriveInfo driver in DriveInfo.GetDrives())
            {
                if(driver.IsReady == true) 
                {
                    
                    TreeNode treeNode = new TreeNode
                    {
                        Text = ((driver.VolumeLabel == "") ? "Local Disk" : driver.VolumeLabel) + " (" + driver.Name.Split('\\')[0] + ")",
                        Tag = driver.Name
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
                    
                    root.Nodes.Add(treeNode);
                }
            }
            fileTreeView.Nodes.Add(root);
            fileTreeView.NodeMouseClick += new TreeNodeMouseClickEventHandler(fileTreeView_NodeMouseClick);
            Location.Text = Path.GetPathRoot(Environment.SystemDirectory);
            index++;
            LoadFromSelectedDirectory(Location.Text);
        }

        private void fileTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode selected = e.Node;
            if(selected.Tag != null)
              LoadFromSelectedDirectory(selected.Tag as string);
        }

        void MovingNextDirectory()
        {
            string selected_document = ContentGrid.SelectedRows[0].Cells[1].Value.ToString();
            if ((File.GetAttributes(Location.Text + "\\" + selected_document) & FileAttributes.Directory) == FileAttributes.Directory)
            {
                if (Forward.IndexOf(Location.Text + "\\" + selected_document) == -1)
                {
                    Forward.Clear();
                }
                if (Location.Text[Location.Text.Length - 1] == '\\')
                {
                    LoadFromSelectedDirectory(Location.Text + selected_document);
                }
                else
                {
                    LoadFromSelectedDirectory(Location.Text + "\\" + selected_document);
                }
                index++;
            }
            else
            {
                string FilePath = Location.Text + "\\" + selected_document;
                if (File.Exists(FilePath))
                {
                    try
                    {
                        System.Diagnostics.Process.Start(FilePath);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            MemoryStream dropEffect = new MemoryStream();
            DragDropEffects dragDropEffect = (Move) ?  DragDropEffects.Move : DragDropEffects.Copy;
            byte[] aMoveEffect = BitConverter.GetBytes((int)dragDropEffect);
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (Forward.Count > 0)
            {
                if(!Forward[Forward.Count - 1].StartsWith("Search://"))
                {
                    LoadFromSelectedDirectory(Forward[Forward.Count - 1]);
                    Forward.RemoveAt(Forward.Count - 1);
                }
            }
        }

        string FileSizeConversion(long size)
        {
             if(size < 1024) return size.ToString() + " B";
             return (size / 1024).ToString() + " KB";
        }

        public void SetupItem(FileInfo fileInfo)
        {
            DataGridViewImageCell nameCell = new DataGridViewImageCell() { ValueIsIcon = true };
            if(fileInfo.Extension == ".dll") nameCell.Value = icons[72];       
            else 
            {
                try
                { 
                    nameCell.Value = ExternalMethods.GetSmallIcon(fileInfo.FullName);
                }
                catch
                {
                    nameCell.Value  = icons[0];
                }
            }
            ContentGrid.Rows.Add(nameCell.Value, fileInfo.Name, fileInfo.LastWriteTime.ToString(), FileSizeConversion(fileInfo.Length)); 
        }

        public void Search(string filename, string data)
        {
            Location.Text = "Search://" + filename;
            DirectoryList = new DirectoryInfo(data);
            FileInfo[] files = DirectoryList.GetFiles();
            DirectoryInfo[] directories = DirectoryList.GetDirectories();
            
            foreach (FileInfo fileInfo in files)
            {
                if(fileInfo.Name.ToLower().Contains(filename.ToLower())){
                    SetupItem(fileInfo);
                }
            }

            foreach (DirectoryInfo directory in directories)
            {
                Search(filename, directory.FullName);
            }
        }

        private void SearchBar_Click(object sender, EventArgs e) => SearchBar.Text = "";

        private void SearchBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string data = Location.Text;
            if(SearchBar.Text != "" && e.KeyChar == (char)13)
            {
                ContentGrid.Rows.Clear();
                try
                {
                   Search(SearchBar.Text, data);
                   backup = data;
                }
                catch(Exception){}
            }
            
        }

        private void ContentGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) => MovingNextDirectory();

        private void ContentGrid_MouseClick(object sender, MouseEventArgs e)
        {
           if (e.Button == MouseButtons.Right) 
           {
                ContextMenu contextmenu = new ContextMenu();
                string SelectedPath = Location.Text + "\\" + ContentGrid.SelectedRows[0].Cells[1].Value.ToString();
                contextmenu.MenuItems.Add(new MenuItem("Open", (object senderOpen, EventArgs eventArgs_open) => MovingNextDirectory()));
                contextmenu.MenuItems.Add(new MenuItem("-"));
                contextmenu.MenuItems.Add(new MenuItem("Copy", (object SenderCopy, EventArgs eventArgs_copy) => CopyOperation(SelectedPath, false)));
                contextmenu.MenuItems.Add(new MenuItem("Move", (object SenderMove, EventArgs eventArgs_move) => CopyOperation(SelectedPath, true)));
                if(Clipboard.ContainsFileDropList())
                {
                    contextmenu.MenuItems.Add(new MenuItem("Paste", (object SenderPaste, EventArgs eventArgs_move) => Paste(SelectedPath)));
                }
                contextmenu.MenuItems.Add(new MenuItem("Delete", (object SenderDelete, EventArgs eventArgs_delete) => Delete(SelectedPath)));
                contextmenu.MenuItems.Add(new MenuItem("Rename", (object SenderRename, EventArgs eventArgs_rename) => Rename(SelectedPath)));
                contextmenu.Show(this, new Point(e.X, e.Y + 10));
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

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}