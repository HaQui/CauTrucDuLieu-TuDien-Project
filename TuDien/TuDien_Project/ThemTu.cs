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
        public ThemTu()
        {
            InitializeComponent();
        }

        private void them_bt_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream(@"E:\Github\CauTrucDuLieu-TuDien-Project\TuDien\TuDien_Project\Dictionary.txt", FileMode.Append, FileAccess.Write);
            StreamWriter write = new StreamWriter(file);
            string a = Anh_txb.Text;
            string u = Viet_txb.Text;
            string k = a + "&" + u;
            write.WriteLine(k);
            write.Flush();
            write.Close();
            file.Close();
            MessageBox.Show("Đã thêm thành công");

        }
    }
}
