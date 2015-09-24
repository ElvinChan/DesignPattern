using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleFactory
{
    public partial class Form1 : Form
    {
        bool bOperate = false;
        Operation oper;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (bOperate)
            {
                txtShow.Text = "";
                bOperate = false;
            }

            string number = ((Button)sender).Text;
            txtShow.Text = Operation.checkNumberInput(txtShow.Text, number);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtShow.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtShow.Text != "")
            {
                oper = OperationFactory.createOperate(((Button)sender).Text);

                oper.NumberA = Convert.ToDouble(txtShow.Text);
                bOperate = true;
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (txtShow.Text != "")
            {
                if (((Button)sender).Text != "=")
                {
                    oper = OperationFactory.createOperate(((Button)sender).Text);
                }

                oper.NumberB = Convert.ToDouble(txtShow.Text);
                txtShow.Text = oper.GetResult().ToString();
                bOperate = true;
            }
        }

        
    }
}
