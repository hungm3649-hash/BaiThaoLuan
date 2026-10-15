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
    public partial class Form1 : Form
    {
        int[] a = new int[100];
        int n = 10;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            n = 10;

            for (int i = 0; i < n; i++)
            {
                a[i] = random.Next(1, 100);
            }

            txtMangGoc.Text = string.Join(" ", a, 0, n);
            txtKetQua.Clear();
        }

        private void btnDemLe_Click(object sender, EventArgs e)
        {
            int dem = 0;

            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 != 0)
                {
                    dem++;
                }
            }

            txtKetQua.Text = "So luong so le = " + dem;
        }

        private void btnTongLe_Click(object sender, EventArgs e)
        {
            int tong = 0;

            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 != 0)
                {
                    tong += a[i];
                }
            }

            txtKetQua.Text = "Tong cac so le = " + tong;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            int kq = a[0];

            for (int i = 1; i < n; i++)
            {
                if (rdoMin.Checked && a[i] < kq)
                {
                    kq = a[i];
                }

                if (rdoMax.Checked && a[i] > kq)
                {
                    kq = a[i];
                }
            }

            if (rdoMin.Checked)
            {
                txtKetQua.Text = "Min = " + kq;
            }
            else
            {
                txtKetQua.Text = "Max = " + kq;
            }
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    bool doiCho;

                    if (rdoTang.Checked)
                    {
                        doiCho = a[i] > a[j];
                    }
                    else
                    {
                        doiCho = a[i] < a[j];
                    }

                    if (doiCho)
                    {
                        int tam = a[i];
                        a[i] = a[j];
                        a[j] = tam;
                    }
                }
            }

            txtKetQua.Text = string.Join(" ", a, 0, n);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bài1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void bài2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
