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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnNhapSo_Click(object sender, EventArgs e)
        {
            int n;

            if (!int.TryParse(txtNhapSoNguyen.Text, out n))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
                return;
            }

            lstbDaySo.Items.Add(n);
            txtNhapSoNguyen.Clear();
            txtNhapSoNguyen.Focus();
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstbDaySo.Items.Count; i++)
            {
                int n = Convert.ToInt32(lstbDaySo.Items[i]);
                lstbDaySo.Items[i] = n + 2;
            }
        }

        private void btnChanDau_Click(object sender, EventArgs e)
        {
            lstbDaySo.ClearSelected();

            for (int i = 0; i < lstbDaySo.Items.Count; i++)
            {
                int n = Convert.ToInt32(lstbDaySo.Items[i]);

                if (n % 2 == 0)
                {
                    lstbDaySo.SelectedIndex = i;
                    return;
                }
            }
            MessageBox.Show("Không có số chẵn!");
        }

        private void btnLeCuoi_Click(object sender, EventArgs e)
        {
            lstbDaySo.ClearSelected();

            for (int i = lstbDaySo.Items.Count - 1; i >= 0; i--)
            {
                int n = Convert.ToInt32(lstbDaySo.Items[i]);

                if (n % 2 != 0)
                {
                    lstbDaySo.SelectedIndex = i;
                    return;
                }
            }

            MessageBox.Show("Không có số lẻ!");
        }

        private void btnXoaChon_Click(object sender, EventArgs e)
        {
            if (lstbDaySo.SelectedIndex != -1)
            {
                lstbDaySo.Items.RemoveAt(lstbDaySo.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phần tử cần xóa!");
            }
        }

        private void btnXoaDau_Click(object sender, EventArgs e)
        {
            if (lstbDaySo.Items.Count > 0)
            {
                lstbDaySo.Items.RemoveAt(0);
            }
            else
            {
                MessageBox.Show("Dãy số đang trống!");
            }
        }

        private void btnXoaCuoi_Click(object sender, EventArgs e)
        {
            if (lstbDaySo.Items.Count > 0)
            {
                lstbDaySo.Items.RemoveAt(lstbDaySo.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("Dãy số đang trống!");
            }
        }

        private void btnXoaDaySo_Click(object sender, EventArgs e)
        {
            lstbDaySo.Items.Clear();
            txtNhapSoNguyen.Clear();
            txtNhapSoNguyen.Focus();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
