using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuDien_Project
{
    public partial class XoaTu : Form
    {
        private TuDienAV td;
        public XoaTu(Form td)
        {

            this.td = (TuDienAV)td;
            InitializeComponent();
        }

        private void txt_DelName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Anh_txb.Focus();
        }

        private void Anh_txb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void them_bt_Click(object sender, EventArgs e)
        {
            string s1 = Anh_txb.Text;
            try
            {
                if (s1 == "" || s1 == null)
                    throw new Exception("You have to fill enough word");
                else
                {
                    //td.tree.del(s1);
                    //MessageBox.Show("This Word has been Delete", "Congratulation", MessageBoxButtons.OK,
                    //    MessageBoxIcon.Information);

                    ////td.EngLish_ListView.Items.Remove(s1);


                    //for (int i = 0; i < td.DS.Count; i++)
                    //{
                    //    if (td.DS[i].Eng == s1)
                    //        td.DS.RemoveAt(i);
                    //}

                    //FileStream file = new FileStream(
                    //    @"D:\Trung Kiên\TuDien\TuDien_Project\output.txt", FileMode.Create, FileAccess.Write);
                    //StreamWriter write = new StreamWriter(file);

                    //for (int i = 0; i < td.DS.Count; i++)
                    //{
                    //    string k = td.DS[i].Eng + '@' + td.DS[i].Viet;
                    //    write.WriteLine(k);
                    //}
                    //write.Flush();
                    //write.Close();
                    //file.Close();

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Viet_txb_TextChanged(object sender, EventArgs e)
        {

        }

        private void XoaTu_Load(object sender, EventArgs e)
        {

        }
    }
}
