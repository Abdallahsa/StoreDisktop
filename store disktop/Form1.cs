using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace store_disktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Category f1 = new Category();
            f1.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Product p1 = new Product();
            p1.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Staff s1 = new Staff();
            s1.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Oredr o1 = new Oredr();
            o1.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Customer c1 = new Customer();
            c1.ShowDialog();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Brand b1 = new Brand();
            b1.ShowDialog();
        }
    }
}
