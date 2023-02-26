using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if ((txtUsername.Text == "") || (txtpassword.Text == ""))
            {
                MessageBox.Show("Nhập thông tin", "Thông báo");
            }
            else
            {
                if ((txtUsername.Text == "admin") && (txtpassword.Text == "admin"))
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                    //Form2 f = new Form2();
                    //f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo");
                }
            }
        }
    }
}
