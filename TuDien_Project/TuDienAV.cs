using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Collections;

namespace TuDien_Project
{
    public partial class TuDienAV : Form
    {
        public int SLNode = 0;
        public BinarySearchTree tree;
        public BinarySearchTree treeLike;
        public List<Word> DS = new List<Word>();


        public TuDienAV()
        {
            InitializeComponent();
            tree = new BinarySearchTree();
            //doctufile();
            //ListView English_ListView = new ListView();
           //tree= new BinarySearchTree();
            doctufile();
            LoadComboBox(tree.Root);

            treeLike = new BinarySearchTree();
            docfileLike();
            LoadComboBox(treeLike.Root);
        }



        DataTable sample;

        public void TuDienAV_Load(object sender, EventArgs e)
        {
            sample = new DataTable();
            sample.Columns.Add("Danh Sach Muc Tu", typeof(string));
            //LoadEngLishListView(tree.Root);
            TIP();

        }

        public void TIP()
        {
            ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.Them_Button, "Thêm từ");
            ToolTip ToolTip2 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.Xoa_button, "Xóa từ");
            ToolTip ToolTip3 = new System.Windows.Forms.ToolTip();
            //ToolTip1.SetToolTip(this.Sua_Button, "Sửa từ");
            ToolTip ToolTip4 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.SoundWord, "Cách phát âm");
            ToolTip ToolTip5 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.LikeWord, "Sửa từ");
            ToolTip ToolTip6 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.EditWord, "Yêu thích");
            ToolTip ToolTip7 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.SearchWeb, "Từ điển online");


        }

        //public void LoadEngLishListView(Node node)
        //{
        //    EngLishListView(node);

        //    English_ListView.View = View.Details;
        //    English_ListView.Columns.Add("Danh Sach Muc Tu").Width = 190;

        //    addItems();
        //    Search_TextBox.TextChanged += new EventHandler(Search_TextBox_TextChanged);

        //}

        public void EngLishListView(Node node)
        {
            if (node == null)
                return;
            EngLishListView(node.Left);

            sample.Rows.Add(node.English.ToString());

            EngLishListView(node.Right);
        }

        public void Search_TextBox_TextChanged(object sender, EventArgs e)
        {
            addItems();
        }

        public void addItems()
        {
            //English_ListView.Items.Clear(); //Clear all the Data in the ListView
            //foreach (DataRow row in sample.Rows)
            //{
            //    if (row["Danh Sach Muc Tu"].ToString().ToLower().StartsWith(Search_TextBox.Text.ToLower()))
            //    //If the cell value is start with the value in the TextBox
            //    {
            //        ListViewItem item = new ListViewItem(row["Danh Sach Muc Tu"].ToString());
            //        English_ListView.Items.Add(item); //Add this row to the ListView
            //    }
            //}
        }

        public void docfileLike()
        {
            FileStream file = new FileStream(@"D:\New folder\TuDien (4)\TuDien\TuDien_Project\Like.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(file);
            try
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    string name = null, meaning = null;
                    int i = 0;
                    while (i < line.Length && line[i] != '&')
                    {
                        name = name + line[i];
                        i++;
                    }
                    i++;
                    while (i < line.Length)
                    {
                        meaning = meaning + line[i];
                        i++;
                    }
                    treeLike.Insert(name, meaning);
  
                    line = sr.ReadLine();
                }
                treeLike.display();
                sr.Close();
                file.Close();
            }
            catch (Exception e)
            {

            }

        }

        public void doctufile()
        {
            FileStream file = new FileStream(Link.filepath, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(file);
            try
            {
                string line = sr.ReadLine();
                do
                {
                    string name = null, meaning = null;
                    int i = 0;
                    while (i < line.Length && line[i] != '&')
                    {
                        name = name + line[i];
                        i++;
                    }
                    i++;
                    while (i < line.Length)
                    {
                        meaning = meaning + line[i];
                        i++;
                    }
                    tree.Insert(name, meaning);
                    DS.Add(new Word(name, meaning));
                    line = sr.ReadLine();
                } while (line != null);
                tree.display();
                sr.Close();
                file.Close();
            }
            catch (Exception exception)
            {

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    About About = new About();
        //    About.Show();
        //}

        private void LoadComboBox(Node node)
        {
            if (node == null)
                return;
            LoadComboBox(node.Left);
            comboBox1.Items.Add(node.English);
            LoadComboBox(node.Right);
        }


        //public void English_ListView_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (English_ListView.SelectedItems.Count == 0)
        //        return;
        //    string namee = English_ListView.SelectedItems[0].Text;
        //    string s = tree.search(namee);
        //    Nghia_TextBox.Text = s;
        //}

        public void Them_Button_Click(object sender, EventArgs e)
        {
            ThemTu();
            HienThiTuDien();
        }
        
        public void HienThiTuDien()
        {
            tree = new BinarySearchTree();
            doctufile();
            sample = new DataTable();
            sample.Columns.Add("Danh Sach Muc Tu", typeof(string));
            //LoadEngLish(tree.Root);           
        }

        public void ThemTu()
        {
            ThemTu f = new ThemTu(this);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        public void Sua_Button_Click(object sender, EventArgs e)
        {

        }

        public void Xoa_button_Click(object sender, EventArgs e)
        {
            string s1 = comboBox1.Text;
            try
            {
                {
                    tree.del(s1);
                    MessageBox.Show("This Word has been Delete", "Congratulation", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    
                    for (int i = 0; i < DS.Count; i++)
                    {
                        if (DS[i].Eng == s1)
                            DS.RemoveAt(i);
                    }

                    comboBox1.Items.Remove(s1);

                    FileStream file = new FileStream(Link.filepath, FileMode.Open, FileAccess.Write);
                    StreamWriter write = new StreamWriter(file);

                    for (int i = 0; i < DS.Count; i++)
                    {
                        string j = DS[i].Eng + "&" + DS[i].Viet;
                        write.WriteLine(j);
                    }
                    write.Flush();
                    write.Close();
                    file.Close();

                }
            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SearchWeb_Click(object sender, EventArgs e)
        {
            SurfPage f = new SurfPage();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void LikeWord_Click(object sender, EventArgs e)
        {
            //FileStream file = new FileStream(Link.filepath, FileMode.Append, FileAccess.Write);
            //StreamWriter write = new StreamWriter(file);
            ////string a = English_ListView.SelectedItems[0].Text;
            //string u = Nghia_TextBox.Text;
            ////string k = a + "&" + u;
            //write.WriteLine(k);
            //write.Flush();
            //write.Close();
            //file.Close();
            FileStream file = new FileStream(@"D:\New folder\TuDien (4)\TuDien\TuDien_Project\Like.txt", FileMode.Append, FileAccess.Write);
            StreamWriter write = new StreamWriter(file);
            ComboBox cb = sender as ComboBox;
            string a = comboBox1.SelectedItem.ToString();
            string b = Nghia_TextBox.Text;
            string s = "";
            TimKiem_ComboBox.Items.Add(a);
            string[] allLines = Nghia_TextBox.Text.Split('\r', '\n');
            s = string.Join(s, allLines);
            s = s.Replace("(n)", "#(n)");
            s = s.Replace("(v)", "#(v)");
            s = s.Replace("(adj)", "#(adj)");
            s = s.Replace("(adv)", "#(adv)");

            string k = a + "&" + s;
            write.WriteLine(k);
            write.Flush();
            write.Close();
            file.Close();

            MessageBox.Show("Đã thêm từ " + a + " vào danh sách yêu thích!");
            docfileLike();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            string TA = cb.Text;
            string s = tree.search(TA);
            s = s.Replace("#", "\r" + "\n");
            s = s.Replace("&#", "&");
            Nghia_TextBox.Text = s;
        }

        private void TimKiem_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            string TA = cb.Text;
            string s = treeLike.search(TA);
            s = s.Replace("#", "\r" + "\n");
            s = s.Replace("&#", "&");
            Nghia_TextBox.Text = s;
        }

        private void EditWord_Click(object sender, EventArgs e)
        {

        }

        private void SoundWord_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
