using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P.B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            double chiSoCu, chiSoMoi;

            if (!double.TryParse(txtChiSoCu.Text, out chiSoCu) ||
                !double.TryParse(txtChiSoMoi.Text, out chiSoMoi))
            {
                MessageBox.Show("Vui lòng nhập chỉ số điện hợp lệ!");
                return;
            }

            if (chiSoMoi < chiSoCu)
            {
                MessageBox.Show("Chỉ số mới phải lớn hơn hoặc bằng chỉ số cũ!");
                return;
            }

            double soKW = chiSoMoi - chiSoCu;
            double donGia;

            if (rdoCaNhan.Checked)
            {
                donGia = 5000;
            }
            else
            {
                donGia = 6000;
            }

            double thanhTien = soKW * donGia;
            double vat = thanhTien * 0.10;
            double tongCong = thanhTien + vat;

            txtSoKW.Text = soKW.ToString();
            txtThanhTien.Text = thanhTien.ToString("N0") + " đ";
            txtVAT.Text = vat.ToString("N0") + " đ";
            txtTongCong.Text = tongCong.ToString("N0") + " đ";
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            cboMaKhach.Text = "";
            txtTenKhach.Clear();
            txtChiSoCu.Clear();
            txtChiSoMoi.Clear();
            txtSoKW.Clear();
            txtThanhTien.Clear();
            txtVAT.Clear();
            txtTongCong.Clear();

            rdoCaNhan.Checked = true;

            txtTenKhach.Focus();
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

        private void bài3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void bài4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void bài5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void bài6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void bài7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }
    }
}
