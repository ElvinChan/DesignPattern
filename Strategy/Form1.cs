using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Strategy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double total = 0.0d;
        private void btnOk_Click(object sender, EventArgs e)
        {
            CashSuper csuper = CashFactory.createCashAccept(cbxType.SelectedItem.ToString());
            double totalPrices = 0d;
            totalPrices = csuper.acceptCash(Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text));
            total = total + totalPrices;
            lbxList.Items.Add("单价："+ txtPrice.Text+"数量："+txtNum.Text+" "+ cbxType.SelectedItem + "合计："+totalPrices.ToString());
            lblResult.Text = total.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            total = 0d;
            txtPrice.Text = "0.00";
            txtNum.Text = "0";
            lbxList.Items.Clear();
            lblResult.Text = "0.00";
        }
    }
}
