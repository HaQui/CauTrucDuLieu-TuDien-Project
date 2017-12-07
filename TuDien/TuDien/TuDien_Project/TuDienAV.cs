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

namespace TuDien_Project
{
    public partial class TuDienAV : Form
    {
        public BinarySearchTree tree;
        public TuDienAV()
        {
            InitializeComponent();
            tree = new BinarySearchTree();
            doctufile();
            ListView English_ListView = new ListView();
            LoadComboBox(tree.Root);
            
        }

        DataTable sample;
        private void TuDienAV_Load(object sender, EventArgs e)
        {
            sample = new DataTable();
            sample.Columns.Add("Danh Sach Muc Tu", typeof(string));
            LoadEngLishListView(tree.Root);
        }
        private void LoadEngLishListView(Node node)
        {
            EngLishListView(node);

            English_ListView.View = View.Details;
            English_ListView.Columns.Add("Danh Sach Muc Tu").Width=190;

            addItems();
            Search_TextBox.TextChanged += new EventHandler(Search_TextBox_TextChanged);

        }
        private void EngLishListView(Node node)
        {
            if (node == null)
                return;
            EngLishListView(node.Left);

            sample.Rows.Add(node.English.ToString());

            EngLishListView(node.Right);
        }
        private void Search_TextBox_TextChanged(object sender, EventArgs e)
        {
            addItems();
        }
        private void addItems()
        {
            English_ListView.Items.Clear(); //Clear all the Data in the ListView
            foreach (DataRow row in sample.Rows)
            {
                if (row["Danh Sach Muc Tu"].ToString().ToLower().StartsWith(Search_TextBox.Text.ToLower()))
                //If the cell value is start with the value in the TextBox
                {
                    ListViewItem item = new ListViewItem(row["Danh Sach Muc Tu"].ToString());
                    English_ListView.Items.Add(item); //Add this row to the ListView
                }
            }
        }

        public void doctufile()
        {
            FileStream file = new FileStream
                (@"E:\Github\CauTrucDuLieu-TuDien-Project\TuDien\TuDien_Project\Dictionary_Source.txt",
                FileMode.Open, FileAccess.Read);
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
                    tree.Insert(name, meaning);
                    line = sr.ReadLine();
                }
                tree.display();
            }
            catch (Exception e)
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
            TimKiem_ComboBox.Items.Add(node.English);
            LoadComboBox(node.Right);
        }

        private void TimKiem_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            string name = cb.Text;
            string s = tree.search(name);
            Nghia_TextBox.Text = s;
        }

        private void English_ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (English_ListView.SelectedItems.Count == 0)
                return;
            string namee = English_ListView.SelectedItems[0].Text;
            string s = tree.search(namee);
            Nghia_TextBox.Text = s;
        }
    }
}
