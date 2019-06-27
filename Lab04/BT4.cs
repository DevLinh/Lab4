using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class BT4 : Form
    {
        public BT4()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Control ctrSoNguyen = (Control)sender;
           // if (ctrSoNguyen.Text.Length > 0)
                //if (!char.IsDigit(ctrSoNguyen.Text[ctrSoNguyen.Text.Length - 1]))
                    //this.errSoNguyen.SetError(ctrSoNguyen, "Vui lòng nhập số nguyên");
               // else
                   // this.errSoNguyen.Clear();
        }

        private void Bai4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
                Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            lstResult.Items.Add(txtInput.Text);
            txtInput.Text = "";
            txtInput.Focus();
        }

        private void BtnIncre2_Click(object sender, EventArgs e)
        {
            int n = lstResult.Items.Count;
            for (int i = 0; i < n; i++)
            {
                int temp = int.Parse(lstResult.Items[i].ToString()) + 2;
                lstResult.Items.RemoveAt(i);
                lstResult.Items.Insert(i, temp.ToString());
            }
        }


        private void BtnSelFirstEven_Click(object sender, EventArgs e)
        {
            int n = lstResult.Items.Count;
            for (int i = 0; i < n - 1; i++)
            {
                if (int.Parse(lstResult.Items[i].ToString()) % 2 == 0)
                {
                    string s = lstResult.Items[i].ToString();
                    lstResult.SelectedItem = s;
                    break;
                } 
            }
        }

        private void BtnSelLastOdd_Click(object sender, EventArgs e)
        {
            int n = lstResult.Items.Count;
            for (int i = n - 1; i >= 0; i--)
            {
                if (int.Parse(lstResult.Items[i].ToString()) % 2 == 1)
                {
                    string s = lstResult.Items[i].ToString();
                    lstResult.SelectedItem = s;
                    break;
                }
            }
        }

        private void BtnDeleHere_Click(object sender, EventArgs e)
        {
            int n = lstResult.SelectedItems.Count;
            if (n == 0)
            {
                
            }
            for (int i = n - 1; i >= 0; i--)
                lstResult.Items.Remove(lstResult.SelectedItems[i].ToString());
        }

        private void BtnDeleFirst_Click(object sender, EventArgs e)
        {
            int n = lstResult.SelectedItems.Count;
            if (n == 0)
            {
                return;
            }
            lstResult.Items.Remove(lstResult.Items[0].ToString());
        }

        private void BtnDeleLast_Click(object sender, EventArgs e)
        {
            int n = lstResult.Items.Count;
            if (n == 0)
            {
                return;
            }
            lstResult.Items.Remove(lstResult.Items[n - 1].ToString());
        }

        private void TxtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }
    }
}
