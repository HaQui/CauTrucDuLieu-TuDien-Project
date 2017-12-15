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
namespace TuDien_Project
{
    public partial class ThemTu : Form
    {
        
        private TuDienAV _frmMainScreen;
        string ANH, tuloai, VIET, VIET2;
        public ThemTu(Form frmMainScreen)
        {
            _frmMainScreen = (TuDienAV)frmMainScreen;
            InitializeComponent();
        }

        public void them_bt_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream(@"D:\New folder\TuDien (4)\TuDien\TuDien_Project\Dictionary.txt", FileMode.Append, FileAccess.Write);
            StreamWriter write = new StreamWriter(file);
            ANH = Anh_txb.Text;
            VIET2 = Viet_txb.Text;
            string k = ANH + "&" + VIET + VIET2;
            write.WriteLine(k);
            write.Flush();
            write.Close();
            file.Close();
            MessageBox.Show("Đã thêm thành công");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tuloai = comboBox1.SelectedItem.ToString();
            VIET = VIET + tuloai + ": ";
        }

        private void ThemTu_Load(object sender, EventArgs e)
        {

        }

        private void Anh_txb_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemNghia_Click(object sender, EventArgs e)
        {
            VIET2 = Viet_txb.Text;
            Viet_txb.Text = "";
            VIET = VIET + VIET2 + "#";
        }
    }
}
