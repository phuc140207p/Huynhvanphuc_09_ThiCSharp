using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Huynhvanphuc_09_ThiCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = ("Họ và tên: Huỳnh Văn phúc" + "\nMSSV:1223360160" + "\nNgay" + DateTime.Now + "\nMôn thi: lập trình windows 2 - C#");
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("chương trình tiện ích", "thông tin");
        }

        private void giảiPhươngTrìnhBật2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giaiphuongtrinhbac2 giaiphuongtrinhbac_=new Giaiphuongtrinhbac2();
            giaiphuongtrinhbac_.ShowDialog();
        }
    }
}
