using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace Browser
{
    public partial class File_explorer : Form
    {
        struct RenameFiles
        {
            public string oldpath;
            public string newpath;
        }

        struct CopyFiles
        {
            public string oldpath;
            public bool paste;
            public bool move;
        }

        RenameFiles renameFiles;
        CopyFiles copyFiles;

        DirectoryInfo DirectoryList;
        int index = 0;
        public File_explorer() => InitializeComponent();
        
        System.Collections.Generic.List<string> Forward = new System.Collections.Generic.List<string>();
        string backup;

        void LoadFromSelectedDirectory(string data)
        {
            
            ContentList.Clear();
            Location.Text = data;
            DirectoryList = new DirectoryInfo(data);
            FileInfo[] files = DirectoryList.GetFiles();
            DirectoryInfo[] directories = DirectoryList.GetDirectories();

            ColumnHeader Name = new ColumnHeader
            {
                Name = "Name",
                Text = "Name",
                TextAlign = HorizontalAlignment.Center,
                Width = 360
            };
            ContentList.AutoArrange = true;
            ContentList.Columns.Add(Name);           


            foreach (DirectoryInfo directory in directories)
            {
                try
                {
                    directory.GetDirectories();
                    ListViewItem item = new ListViewItem(directory.Name, 0);
                    item.SubItems.Add(directory.LastAccessTime.Date.ToString());
                    ContentList.Items.Add(item);
                }
                catch
                {
             
                }    
            }
            
            foreach (FileInfo fileInfo in files)
            {
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
                    try {
                        LoadFromSelectedDirectory(Location.Text);
                    }
                    catch(DirectoryNotFoundException) {
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
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            Location.Text = Path.GetPathRoot(Environment.SystemDirectory);
            index++;
            LoadFromSelectedDirectory(Location.Text);
            this.ContentList.OwnerDraw = true;
        }


        void MovingNextDirectory()
        {
            string selected_document = ContentList.SelectedItems[0].Text;
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
            ContentList.Clear();
            LoadFromSelectedDirectory(SelectedPath);
        }


        private void CopyOperation(string SelectedPath, bool Move)
        {
             copyFiles.move = Move;
             copyFiles.paste = true; 
             copyFiles.oldpath = SelectedPath;
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
            try
            {
                SelectedPath += "\\" + Path.GetFileName(copyFiles.oldpath);
                bool overriden = false;
                if (SelectedPath.Equals(copyFiles.oldpath))
                    if (MessageBox.Show("The file " + SelectedPath + " exists, do you want to overwrite it?", "Overwrite file", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    == DialogResult.Yes)
                         overriden = true;
                    else
                    {
                        copyFiles.paste = false;
                        return;
                    }

                if (copyFiles.paste == true)
                {
                     File.Copy(copyFiles.oldpath, SelectedPath, overriden);
                }
                else
                {
                    if (overriden == true)
                    {
                        File.Delete(SelectedPath);
                    }
                    File.Move(copyFiles.oldpath, SelectedPath);
                }
                Refresh(Directory.GetParent(SelectedPath).FullName);
            }
            catch (UnauthorizedAccessException)
            { 
                MessageBox.Show("You do not have access to move / copy the selected file", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("I can not find the selected file", "File not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception exception)
            {
                MessageBox.Show("Unable to copy the selected file " + exception.Message);
            }
        }

        
        private void Rename(string SelectedPath)
        {
            ContentList.LabelEdit = true; 
            renameFiles.oldpath = SelectedPath;
            ContentList.SelectedItems[0].BeginEdit();
        }
 
         private void RightClick(MouseEventArgs mouseEventArgs, bool list)
         {
            ContextMenu contextmenu = new ContextMenu();
            if (list == true)
            {
                string SelectedPath = Location.Text + "\\" + ContentList.SelectedItems[0].Text;
                contextmenu.MenuItems.Add(new MenuItem("Open", (object sender_open, EventArgs eventArgs_open) => MovingNextDirectory()));
                contextmenu.MenuItems.Add(new MenuItem("-"));
                if (File.Exists(SelectedPath))
                {
                    contextmenu.MenuItems.Add(new MenuItem("Copy", (object SenderCopy, EventArgs eventArgs_copy) => CopyOperation(SelectedPath, true)));
                    contextmenu.MenuItems.Add(new MenuItem("Move", (object SenderMove, EventArgs eventArgs_move) => CopyOperation(SelectedPath, false)));
                }
                if(copyFiles.paste == true)
                {
                    contextmenu.MenuItems.Add(new MenuItem("Paste", (object SenderPaste, EventArgs eventArgs_move) => Paste(SelectedPath)));
                }
                contextmenu.MenuItems.Add(new MenuItem("Delete", (object SenderOpen, EventArgs eventArgs_delete) => Delete(SelectedPath)));
                contextmenu.MenuItems.Add(new MenuItem("Rename", (object SenderRename, EventArgs eventArgs_rename) => Rename(SelectedPath)));
            }
            else
            {
                string selected_path = Location.Text;
                contextmenu.MenuItems.Add(new MenuItem("Create a folder", (object sender_open, EventArgs eventArgs_Folder) => { }));
                if (copyFiles.paste == true)
                    contextmenu.MenuItems.Add(new MenuItem("Paste", (object sender_open, EventArgs eventArgs_move) => Paste(selected_path)));
                contextmenu.MenuItems.Add(new MenuItem("Refresh", (object sender, EventArgs eventArgs_Refresh) => Refresh(selected_path)));
            }
            contextmenu.Show(ContentList, new Point(mouseEventArgs.X, mouseEventArgs.Y));
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ContentList.SelectedItems[0].Selected = true;
            }
            if(MouseButtons.Right == e.Button)
            {
                RightClick(e, true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
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



        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            Point mousePosition = ContentList.PointToClient(Control.MousePosition);
            try
            {
                ListViewHitTestInfo hit = ContentList.HitTest(mousePosition);
                int columnindex = hit.Item.SubItems.IndexOf(hit.SubItem);
                if(columnindex != 0)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                if (e.Button == MouseButtons.Right)
                    RightClick(e, false);
            }
        }

        private void listView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Data.theme), e.Bounds);
            using (SolidBrush foreBrush = new SolidBrush(Data.fortheme))
            {
                StringFormat sf = new StringFormat
                {
                    LineAlignment = StringAlignment.Center,
                    Alignment = StringAlignment.Center
                };
                e.Graphics.DrawString(e.Header.Text, e.Font, foreBrush, e.Bounds, sf);
            }
        }

        private void listView1_DrawItem(object sender, DrawListViewItemEventArgs e) => e.DrawDefault = true;

        private void listView1_DrawSubItem(object sender, DrawListViewSubItemEventArgs e) => e.DrawDefault = true;

        public void SetupItem(FileInfo fileInfo)
        {
              ListViewItem item;
              switch (fileInfo.Extension)
              {
                        case ".exe": { item = new ListViewItem(fileInfo.Name, 1); break; }
                        case ".inf":
                        case ".txt":
                        case ".ini":
                        case ".log":
                        case ".xml":
                        case ".dat":
                            { item = new ListViewItem(fileInfo.Name, 2); break; }
                        case ".bmp":
                        case ".jpg":
                        case ".png":
                        case ".gif":
                        case ".tiff":
                            { item = new ListViewItem(fileInfo.Name, 4); break; }
                        case ".dll":
                        case ".sys":
                            { item = new ListViewItem(fileInfo.Name, 3); break; }
                        default:
                            { item = new ListViewItem(fileInfo.Name, 6); break; }     
              }
              ContentList.Items.Add(item); 
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
            if(SearchBar.Text != "" && e.KeyChar == (char)13){
                ContentList.Clear();
                ColumnHeader Name = new ColumnHeader
                {
                    Name = "Name",
                    Text = "Name",
                    TextAlign = HorizontalAlignment.Center,
                    Width = 360
                };
                ContentList.AutoArrange = true;
                ContentList.Columns.Add(Name);   
                try
                {
                   Search(SearchBar.Text, data);
                   backup = data;
                }
                catch(Exception){}
            }
        }

        private void button3_Click(object sender, EventArgs e) => this.Close();

        private void ContentList_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            renameFiles.newpath  = Directory.GetParent(renameFiles.oldpath) + "\\" + e.Label.ToString();
            bool RenameCheck = true;
            try{
               File.Move(renameFiles.oldpath, renameFiles.newpath);
            }
            catch(Exception exception)
            {
                MessageBox.Show("Could not rename the selected file. Error message: " + exception.Message);
                RenameCheck = false;
            }
            renameFiles.newpath = null;
            renameFiles.oldpath = null;
            if(RenameCheck == false) Refresh();
        }

        private void ContentList_MouseDoubleClick(object sender, MouseEventArgs e) => MovingNextDirectory();
    }
}
