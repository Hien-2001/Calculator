using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            if (txtA.Text!=String.Empty && txtB.Text!= String.Empty)
            {
                a = int.Parse(txtA.Text);
                b = int.Parse(txtB.Text);
                ketqua = a + b;
                txtKetQua.Text = ketqua.ToString(); 
            }
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            a = int.Parse(txtA.Text);
            b = int.Parse(txtB.Text);
            ketqua = a - b;
            txtKetQua.Text = ketqua.ToString();
        }
    }
}
