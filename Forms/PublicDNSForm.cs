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
        private Application parentForm;
        public PublicDNSForm(Application form)
        {
            // 父窗体对象
            parentForm = form;
            InitializeComponent();
        }


        private void doubleTest_Click(object sender, EventArgs e)
        {
            string val = this.listBox1.SelectedItem.ToString();

            if (CommonUtil.isEmpty(val))
            {
                return;
            }

            int start= val.IndexOf("(");
            int end = val.IndexOf(")");
            int length = val.Length;

            string fVal = val.Substring(start + 1).Replace(")", "");

            Application.publicDNS = fVal;
            this.Close();
        }
    }
}
