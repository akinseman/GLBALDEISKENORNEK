using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace globldeşken1504
{
    public partial class Form1 : Form
    {
        double bakiye = 300;
     

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblBakiye.Text =" bakiye:" + bakiye.ToString();
        }

        private void buttopla_Click(object sender, EventArgs e)
        {
            bakiye = bakiye + 50;
            lblBakiye.Text ="bakiye:" +bakiye.ToString();
        }

        private void bntOde_Click(object sender, EventArgs e)
        {
            bakiye = bakiye - 8;
            lblBakiye.Text= "ode"+bakiye.ToString();
        }
    }
}
