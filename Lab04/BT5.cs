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
    public partial class BT5 : Form
    {
        public BT5()
        {
            InitializeComponent();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            lstA.Items.Add(txtName.Text);
            txtName.Text = "";
            txtName.Focus();
        }

        private void BtnLtR_Click(object sender, EventArgs e)
        {
            int n = lstA.SelectedItems.Count;
            for (int i = 0; i < n; i++)
                lstB.Items.Add(lstA.SelectedItems[i].ToString());
            for (int j = n - 1; j >= 0; j--)
                lstA.Items.RemoveAt(j);
        }

        private void BtnAllLtR_Click(object sender, EventArgs e)
        {
            int n = lstA.Items.Count;
            for (int i = 0; i < n; i++)
                lstB.Items.Add(lstA.Items[i].ToString());
            for (int j = n - 1; j >= 0; j--)
                lstA.Items.RemoveAt(j);

        }

        private void BT5_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int n = lstA.SelectedItems.Count;
            if (n == 0)
            {
                return;
            }
            for (int i = n - 1; i >= 0; i--)
                lstA.Items.Remove(lstA.SelectedItems[i].ToString());
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnRtL_Click(object sender, EventArgs e)
        {
            int n = lstB.SelectedItems.Count;
            for (int i = 0; i < n; i++)
                lstA.Items.Add(lstB.SelectedItems[i].ToString());
            for (int j = n - 1; j >= 0; j--)
                lstB.Items.RemoveAt(j);
        }

        private void BtnAllRtL_Click(object sender, EventArgs e)
        {
            int n = lstB.Items.Count;
            for (int i = 0; i < n; i++)
                lstA.Items.Add(lstB.Items[i].ToString());
            for (int j = n - 1; j >= 0; j--)
                lstB.Items.RemoveAt(j);
        }
    }
}
