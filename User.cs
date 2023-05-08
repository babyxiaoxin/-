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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //跳转用户登录界面
            Usdenglu usdenglu = new Usdenglu();
            usdenglu.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {  //跳转登录界面
            Down down = new Down();
            down.Show();
            this.Close();
        }
    }
}
