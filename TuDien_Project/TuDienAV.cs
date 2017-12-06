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
            LoadComboBox(tree.Root);
            ListView English_ListView = new ListView();
            LoadEngLishListView(tree.Root);
            LoadTextBoxSearch();
        }
        public void doctufile()
        {
            FileStream file = new FileStream
                (@"E:\HocTap_HK1_NAM2\_CauTrucProject\TuDien_Project\Dictionary_Source.txt",
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
        private void LoadEngLishListView(Node node)
        {
            if (node == null)
                return;
            LoadEngLishListView(node.Left);
            English_ListView.Items.Add(node.English);
            LoadEngLishListView(node.Right);
        }

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
     

        private void LoadTextBoxSearch()
        {
            Search_TextBox.BackColor = Color.DimGray;
            Search_TextBox.ForeColor = Color.White;

        }

        private void Search_TextBox_TextChanged(object sender, EventArgs e)
        {
                if (Search_TextBox.Text != "")
                {
                    for (int i = English_ListView.Items.Count - 1; i >= 0; i--)
                    {
                        var item = English_ListView.Items[i];
                        if (item.Text.ToLower().Contains(Search_TextBox.Text.ToLower()))
                        {
                            item.BackColor = SystemColors.Highlight;
                            item.ForeColor = SystemColors.HighlightText;
                        }
                        else
                        {
                        English_ListView.Items.Remove(item);
                        }
                    }
                    if (English_ListView.SelectedItems.Count == 1)
                    {
                    English_ListView.Focus();
                    }
                }

        }
    }
}
