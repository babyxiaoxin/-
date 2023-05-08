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
    public partial class Dengluchengg : Form
    {
        public Dengluchengg()
        {
            InitializeComponent();
        }

        private void Dengluchengg_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LiuLang manager = new LiuLang();
            manager.Show();
            this.Close();
        }
    }
}
