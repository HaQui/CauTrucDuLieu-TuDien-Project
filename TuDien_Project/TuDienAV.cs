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
        }
        public void doctufile()
        {
            FileStream file = new FileStream
                (@"E:\Github\CauTrucDuLieu-TuDien-Project\TuDien_Project\Dictionary_Source.txt",
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

    }
}
