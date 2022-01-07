using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkCardHelper.Forms
{
    public partial class PublicDNSForm : Form
    {
        private TextBox tmpBox;
        public PublicDNSForm(TextBox textBox)
        {
            tmpBox = textBox;
            InitializeComponent();
        }


        private void doubleTest_Click(object sender, EventArgs e)
        {
            confirm();
        }

        private void confirm()
        {
            string val = this.listBox1.SelectedItem.ToString();

            if (CommonUtil.isEmpty(val))
            {
                return;
            }

            int start = val.IndexOf("(");
            int end = val.IndexOf(")");
            int length = val.Length;

            string fVal = val.Substring(start + 1).Replace(")", "");

            //this.Controls[""]
            tmpBox.Text = fVal;

            this.Close();
        }

        private void button_public_dns_confrim_Click(object sender, EventArgs e)
        {
            if (CommonUtil.isEmpty(this.listBox1.SelectedItem.ToString()))
            {
                MessageBox.Show("请先选择一条数据");
                return;
            }
            confirm();
        }
    }
}
