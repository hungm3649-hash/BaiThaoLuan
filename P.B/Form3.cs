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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double soLuong, donGia;
            double thanhTien, vat, giamGia, tongCong;

            if (!double.TryParse(txtSoLuong.Text, out soLuong) ||
                !double.TryParse(txtDonGia.Text, out donGia))
            {
                MessageBox.Show("Vui lòng nhập số lượng và đơn giá hợp lệ!");
                return;
            }

            if (soLuong <= 0 || donGia <= 0)
            {
                MessageBox.Show("Số lượng và đơn giá phải lớn hơn 0!");
                return;
            }

            if (!rdoCaNhan.Checked && !rdoDonViKhac.Checked)
            {
                MessageBox.Show("Vui lòng chọn loại khách hàng!");
                return;
            }

            thanhTien = soLuong * donGia;
            vat = thanhTien * 0.10;

            if (rdoCaNhan.Checked)
                giamGia = thanhTien * 0.03;
            else
                giamGia = thanhTien * 0.05;

            tongCong = thanhTien + vat - giamGia;

            txtThanhTien.Text = thanhTien.ToString("N0");
            txtThueVAT.Text = vat.ToString("N0");
            txtGiamGia.Text = giamGia.ToString("N0");
            txtTongCong.Text = tongCong.ToString("N0");
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtTenKhachHang.Clear();
            txtDiaChi.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();

            txtThanhTien.Clear();
            txtThueVAT.Clear();
            txtGiamGia.Clear();
            txtTongCong.Clear();

            rdoCaNhan.Checked = false;
            rdoDonViKhac.Checked = false;

            txtTenKhachHang.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
