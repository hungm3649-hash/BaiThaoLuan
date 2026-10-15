using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P.D_C_._2
{
    public partial class Form2 : Form
    {
        int[] a;
        Random rd = new Random();
        public Form2()
        {
            InitializeComponent();
            rdTang.Checked = true;
            rdMax.Checked = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnTaoMang_Click(object sender, EventArgs e)
        {
            int n;

            if (!int.TryParse(txtN.Text, out n) || n <= 0)
            {
                MessageBox.Show("Nhap N hop le!");
                return;
            }

            a = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = rd.Next(1, 100);
            }

            txtDaySo.Text = string.Join(" ", a);
            txtMinMax.Clear();
            txtSapXep.Clear();
        }

        private void btnMinMax_Click(object sender, EventArgs e)
        {
            if (a == null)
            {
                MessageBox.Show("Hay tao mang truoc!");
                return;
            }

            if (rdMax.Checked)
            {
                txtMinMax.Text = a.Max().ToString();
            }
            else if (rdMin.Checked)
            {
                txtMinMax.Text = a.Min().ToString();
            }
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            if (a == null)
            {
                MessageBox.Show("Hay tao mang truoc!");
                return;
            }

            int[] b = (int[])a.Clone();

            if (rdTang.Checked)
            {
                Array.Sort(b);
            }
            else if (rdGiam.Checked)
            {
                Array.Sort(b);
                Array.Reverse(b);
            }

            txtSapXep.Text = string.Join(" ", b);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
