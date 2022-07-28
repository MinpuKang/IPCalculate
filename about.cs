using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPCalculate
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void mail_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://hk314.top/");
            //System.Diagnostics.Process.Start("https://weixin.sogou.com/weixin?type=1&s_from=input&query=qiheyehk&ie=utf8&_sug_=n&_sug_type_=");
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
