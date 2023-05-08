using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Usdenglu : Form
    {
        public Usdenglu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {  //跳转user用户功能界面
            User user = new User();
            user.Show();
            this.Close();
        }

        private void Usdenglu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {   //账号正确，跳转下一界面
                MessageBox.Show("账号密码正确，登录成功！");
                Dengluchengg dengluchengg = new Dengluchengg();
                dengluchengg.Show();
                this.Close();
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("请输入账号");
                textBox1.Text = "";
            }
            else if (textBox2.Text == "") {
                MessageBox.Show("请输入密码");
                textBox2.Text = "";
            }
            else
            {
                MessageBox.Show("账号或密码不正确，请重新输入");
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
    }
}
