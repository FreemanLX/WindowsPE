using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;


namespace WindowsPE
{
    public partial class File_explorer : Form
    {
        DirectoryInfo directory_list;
        int index = 0;
        public File_explorer() => InitializeComponent();
        
        System.Collections.Generic.List<string> forward = new System.Collections.Generic.List<string>();
        string backup;
        Thread personalization;
        void load_from_selected_directory(string data)
        {
            
            listView1.Clear();
            textBox1.Text = data;
            directory_list = new DirectoryInfo(data);
            FileInfo[] files = directory_list.GetFiles();
            DirectoryInfo[] directories = directory_list.GetDirectories();

            ColumnHeader Name = new ColumnHeader
            {
                Name = "Name",
                Text = "Name",
                TextAlign = HorizontalAlignment.Center,
                Width = 360
            };
            ColumnHeader list = new ColumnHeader
            {
                Name = "Date",
                Text = "Date modified",
                TextAlign = HorizontalAlignment.Center,
                Width = -2
            };
            listView1.AutoArrange = true;
            listView1.Columns.Add(Name);
            listView1.Columns.Add(list);
           


            foreach (DirectoryInfo directory in directories)
            {
                try
                {
                    directory.GetDirectories();
                    ListViewItem item = new ListViewItem(directory.Name, 0);
                    item.SubItems.Add(directory.LastAccessTime.Date.ToString());
                    listView1.Items.Add(item);
                }
                catch
                {
             
                }    
            }
            
            foreach (FileInfo fileInfo in files)
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
                    default:
                        { item = new ListViewItem(fileInfo.Name, 3); break; }     
                }
                item.SubItems.Add(fileInfo.LastAccessTime.Date.ToString());
                listView1.Items.Add(item);
                backup = textBox1.Text;
            }
            
        }

        protected override void OnClosed(EventArgs e)
        {
            personalization.Abort();
            base.OnClosed(e);
        }


        private void Theme()
        {
            while (true)
            {
                Invoke(new Action(() =>
                {
                    listView1.BackColor = Data.theme;
                    listView1.ForeColor = Data.fortheme;
                }));
                Thread.Sleep(100);
            }

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text.Length > 0)
                {
                    try {
                        load_from_selected_directory(textBox1.Text);
                    }
                    catch(DirectoryNotFoundException) {
                        MessageBox.Show("Can not found the selected directory", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        load_from_selected_directory(backup);
                    }
                    catch (IOException ioexception)
                    {
                        MessageBox.Show(ioexception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        load_from_selected_directory(backup);
                    }
               }
            }
        }

      
        private void button4_Click(object sender, EventArgs e) => this.Close();

        private void File_explorer_Load(object sender, EventArgs e)
        {
            textBox1.Text = Path.GetPathRoot(Environment.SystemDirectory);
            index++;
            load_from_selected_directory(textBox1.Text);
            this.listView1.OwnerDraw = true;
            personalization = new Thread(() => Theme());
            personalization.Start();
        }


        void moving_next_directory()
        {
            string selected_document = listView1.SelectedItems[0].Text;
            if ((File.GetAttributes(textBox1.Text + "\\" + selected_document) & FileAttributes.Directory) == FileAttributes.Directory)
            {
                if (forward.IndexOf(textBox1.Text + "\\" + selected_document) == -1)
                {
                    forward.Clear();
                }
                if (textBox1.Text[textBox1.Text.Length - 1] == '\\')
                {
                    load_from_selected_directory(textBox1.Text + selected_document);
                }
                else
                {
                    load_from_selected_directory(textBox1.Text + "\\" + selected_document);
                }
                index++;
            }
            else
            {
                string s = textBox1.Text + "\\" + selected_document;
                if (File.Exists(s))
                {
                    try
                    {
                        System.Diagnostics.Process.Start(s);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
        
        private void refresh(string selected_path)
        {
            listView1.Clear();
            load_from_selected_directory(selected_path);
        }

        Pair<string, bool> move;

        private void move_a_file(string selected_path, bool save_last_location)
        {
            move = new Pair<string, bool>(selected_path, save_last_location);
        }

        private void delete(string selected_path)
        {
                try
                {
                    if (MessageBox.Show("Do you really want to permanently delete the selected file", "Delete request", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (Directory.Exists(selected_path)) Directory.Delete(selected_path);
                        if (File.Exists(selected_path)) File.Delete(selected_path);
                        refresh(new DirectoryInfo(selected_path).Parent.FullName);
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
                    MessageBox.Show("You do not have access to delete the selected file", "Not access", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (IOException)
                {
                    MessageBox.Show("You do not have access to delete the selected directory", "Not access", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void paste(string selected_path)
        {
            try
            {
                string file = Path.GetFileName(move.get_first());
                bool overriden = false;
                if (File.Exists(selected_path + "\\" + file) &&
                    MessageBox.Show("The file " + selected_path + "\\" + file + " exists, do you want to overwrite it?", "Overwrite file", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    == DialogResult.Yes)
                    overriden = true;
                    else
                    {
                        move = null;
                        return;
                    }

                if (move.get_second() == true)
                {
                     File.Copy(move.get_first(), selected_path + "\\" + file, overriden);
                }
                else
                {
                    if (overriden == true)
                    {
                        File.Delete(selected_path + "\\" + file);
                    }
                    File.Move(move.get_first(), selected_path + "\\" + file);
                }
                refresh(selected_path);
            }
            catch (UnauthorizedAccessException)
            { 
                MessageBox.Show("You do not have access to move / copy the selected file", "No access", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("I can not find the selected file", "File not found", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
            move = null;
        }

        private void rename(string selected_path)
        {
            new rename(selected_path).ShowDialog();
            refresh(Directory.GetParent(selected_path).FullName);
        }

        private void right_click(MouseEventArgs mouseEventArgs, bool list)
        {

            
            ContextMenu m = new ContextMenu();
                        
            
            if (list == true)
            {
                string selected_path = textBox1.Text + "\\" + listView1.SelectedItems[0].Text;
                m.MenuItems.Add(new MenuItem("Open", (object sender_open, EventArgs eventArgs_open) => moving_next_directory()));
                m.MenuItems.Add(new MenuItem("-"));
                if (File.Exists(selected_path))
                {
                    m.MenuItems.Add(new MenuItem("Copy", (object sender_open, EventArgs eventArgs_copy) => move_a_file(selected_path, true)));
                    m.MenuItems.Add(new MenuItem("Move", (object sender_open, EventArgs eventArgs_move) => move_a_file(selected_path, false)));
                }
                else if(move != null)
                {
                    m.MenuItems.Add(new MenuItem("Paste", (object sender_open, EventArgs eventArgs_move) => paste(selected_path)));
                }
                m.MenuItems.Add(new MenuItem("Delete", (object sender_open, EventArgs eventArgs_delete) => delete(selected_path)));
                m.MenuItems.Add(new MenuItem("Rename", (object sender_rename, EventArgs eventArgs_rename) => rename(selected_path)));
            }
            else
            {
                string selected_path = textBox1.Text;
                m.MenuItems.Add(new MenuItem("Create a folder", (object sender_open, EventArgs eventArgs_Folder) => { }));
                if (move != null)
                    m.MenuItems.Add(new MenuItem("Paste", (object sender_open, EventArgs eventArgs_move) => paste(selected_path)));
                m.MenuItems.Add(new MenuItem("Refresh", (object sender, EventArgs eventArgs_Refresh) => refresh(selected_path)));
            }
            m.MenuItems.Add(new MenuItem("-"));
            m.MenuItems.Add(new MenuItem("Proprietes"));
            m.Show(listView1, new System.Drawing.Point(mouseEventArgs.X, mouseEventArgs.Y));
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                moving_next_directory();
            }
            if(MouseButtons.Right == e.Button)
            {
                right_click(e, true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                forward.Add(textBox1.Text);
                load_from_selected_directory(new DirectoryInfo(textBox1.Text).Parent.FullName);
            }
            catch { forward.RemoveAt(forward.LastIndexOf(textBox1.Text)); }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (forward.Count > 0)
            {
                load_from_selected_directory(forward[forward.Count - 1]);
                forward.RemoveAt(forward.Count - 1);
            }
        }



        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            System.Drawing.Point mousePosition = listView1.PointToClient(Control.MousePosition);
            try
            {
                ListViewHitTestInfo hit = listView1.HitTest(mousePosition);
                int columnindex = hit.Item.SubItems.IndexOf(hit.SubItem);
                if(columnindex != 0)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                if (e.Button == MouseButtons.Right)
                    right_click(e, false);
            }
        }

        private void listView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(new System.Drawing.SolidBrush(Data.theme), e.Bounds);
            using (System.Drawing.SolidBrush foreBrush = new System.Drawing.SolidBrush(Data.fortheme))
            {
                StringFormat sf = new StringFormat
                {
                    LineAlignment = StringAlignment.Center,
                    Alignment = StringAlignment.Center
                };
                e.Graphics.DrawString(e.Header.Text, e.Font, foreBrush, e.Bounds, sf);
                
            }
        }

        private void listView1_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;

        }

        private void listView1_DrawSubItem(object sender, DrawListViewSubItemEventArgs e) => e.DrawDefault = true;
    }
}
