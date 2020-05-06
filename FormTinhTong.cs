using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b1p1c4
{
    public partial class FormTinhTong : Form
    {
        int tong = 0;
        public FormTinhTong()
        {
            InitializeComponent();
        }

        private void txta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '-') || (e.KeyChar == '.') ||
                (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '-') || (e.KeyChar == '.') ||
                (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else e.Handled = true;
        }

        private void Ibtong_Click(object sender, EventArgs e)
        {
            if (txta.Text == "")
            {
                MessageBox.Show("Ban chua nhap so a!");
                txta.Focus();
                return;
            }
            if (txtb.Text == "")
            {
                MessageBox.Show("Ban chua nhap so b!");
                txtb.Focus();
                return;
            }
            int a = Convert.ToInt32(txta.Text);
            int b = Convert.ToInt32(txtb.Text);
            if (a < b)
            {
                for (int i=a; i<=b; i++)
                {
                    tong = tong + i;
                    txtkq.Text = tong.ToString();
                }    
            }
            if (a>b)
            {
                for (int i=b; i<=a; i++)
                {
                    tong = tong + i;
                    txtkq.Text = tong.ToString();
                }
            }
        }
        private void Iblamlai_Click(object sender, EventArgs e)
        {
            txta.ResetText();
            txtb.ResetText();
            txtkq.ResetText();
        }
        private void Ibthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
