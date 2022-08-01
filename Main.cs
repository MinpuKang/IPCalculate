using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace IPCalculate
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            textBox_ip_address.Text = "0.0.0.0/16";
            richTextBox_ip_result.ForeColor = Color.Black;
            ip_result(textBox_ip_address.Text);
        }

        //ip result

        public void ip_result(string ipadd)
        {
            //richTextBox_ip_result.Text += "Network Address: " + System.Net.IPNetwork.Parse(ipadd).Network + "\r\n\r\n";
            //richTextBox_ip_result.Text += "Netmask: " + System.Net.IPNetwork.Parse(ipadd).Netmask + "\r\n\r\n";
            //richTextBox_ip_result.Text += "Broadcast Address: " + System.Net.IPNetwork.Parse(ipadd).Broadcast + "\r\n\r\n";
            //richTextBox_ip_result.Text += "FirstUsable Address: " + System.Net.IPNetwork.Parse(ipadd).FirstUsable + "\r\n\r\n";
            //richTextBox_ip_result.Text += "LastUsable Address: " + System.Net.IPNetwork.Parse(ipadd).LastUsable + "\r\n\r\n";
            //richTextBox_ip_result.Text += "Usable: " + System.Net.IPNetwork.Parse(ipadd).Usable + "\r\n\r\n";
            //richTextBox_ip_result.Text += "Cidr: " + System.Net.IPNetwork.Parse(ipadd).Cidr + "\r\n\r\n";

            if (is_ipv4(ipadd) || is_ipv4_range(ipadd))
            {
                richTextBox_ip_result.ForeColor = Color.Black;
                //richTextBox_ip_result.Text += "网络地址: " + System.Net.IPNetwork.Parse(ipadd).Network + "/" + System.Net.IPNetwork.Parse(ipadd).Cidr + "\r\n\r\n";
                //richTextBox_ip_result.Text += "广播地址: " + System.Net.IPNetwork.Parse(ipadd).Broadcast + "/" + System.Net.IPNetwork.Parse(ipadd).Cidr + "\r\n\r\n";
                //richTextBox_ip_result.Text += "可用主机地址范围: " + System.Net.IPNetwork.Parse(ipadd).FirstUsable + "/" + System.Net.IPNetwork.Parse(ipadd).Cidr + "  -" + "  " + System.Net.IPNetwork.Parse(ipadd).LastUsable + "/" + System.Net.IPNetwork.Parse(ipadd).Cidr + "\r\n\r\n";
                //richTextBox_ip_result.Text += "可用主机地址数: " + System.Net.IPNetwork.Parse(ipadd).Usable + "\r\n\r\n";
                //richTextBox_ip_result.Text += "子网掩码: " + System.Net.IPNetwork.Parse(ipadd).Netmask + "\r\n\r\n";
                //richTextBox_ip_result.Text += "掩码位: " + System.Net.IPNetwork.Parse(ipadd).Cidr + "\r\n";

                richTextBox_ip_result.Text += "Network Address: " + System.Net.IPNetwork.Parse(ipadd).Network + "/" + System.Net.IPNetwork.Parse(ipadd).Cidr + "\r\n\r\n";
                richTextBox_ip_result.Text += "Broadcast Address: " + System.Net.IPNetwork.Parse(ipadd).Broadcast + "/" + System.Net.IPNetwork.Parse(ipadd).Cidr + "\r\n\r\n";
                richTextBox_ip_result.Text += "Usable Host Address Range: " + System.Net.IPNetwork.Parse(ipadd).FirstUsable + "/" + System.Net.IPNetwork.Parse(ipadd).Cidr + "  -" + "  " + System.Net.IPNetwork.Parse(ipadd).LastUsable + "/" + System.Net.IPNetwork.Parse(ipadd).Cidr + "\r\n\r\n";
                richTextBox_ip_result.Text += "No. of Usable Host Address: " + System.Net.IPNetwork.Parse(ipadd).Usable + "\r\n\r\n";
                richTextBox_ip_result.Text += "Netmask: " + System.Net.IPNetwork.Parse(ipadd).Netmask + "\r\n\r\n";
                richTextBox_ip_result.Text += "Netmask Length: " + System.Net.IPNetwork.Parse(ipadd).Cidr + "\r\n\r\n";

                //for wildcard mask
                string[] netwokrmask_array = System.Net.IPNetwork.Parse(ipadd).Netmask.ToString().Split('.');
                string wildcard_mask="";
                for (int i= 0;i< netwokrmask_array.Length;i++)
                {
                    if (i == (netwokrmask_array.Length - 1))
                    {
                        wildcard_mask += Convert.ToString(255-Convert.ToInt32(netwokrmask_array[i]));
                    }
                    else
                    {
                        wildcard_mask += Convert.ToString(255 - Convert.ToInt32(netwokrmask_array[i])) + ".";
                    }
                }
                richTextBox_ip_result.Text += "Wildcard Mask: " + wildcard_mask + "\r\n";

            }
            else if (is_ipv6(ipadd) || is_ipv6_range(ipadd))
            {
                richTextBox_ip_result.ForeColor = Color.Black;
                //richTextBox_ip_result.Text += "网络地址: " + System.Net.IPNetwork.Parse(ipadd).Network + "/" + System.Net.IPNetwork.Parse(ipadd).Cidr + "\r\n\r\n";
                //richTextBox_ip_result.Text += "地址范围: " + System.Net.IPNetwork.Parse(ipadd).FirstUsable + "/" + System.Net.IPNetwork.Parse(ipadd).Cidr + "  -" + "  " + System.Net.IPNetwork.Parse(ipadd).LastUsable + "/" + System.Net.IPNetwork.Parse(ipadd).Cidr + "\r\n\r\n";
                //richTextBox_ip_result.Text += "可用地址数: " + System.Net.IPNetwork.Parse(ipadd).Usable + "\r\n\r\n";
                //richTextBox_ip_result.Text += "前缀: " + System.Net.IPNetwork.Parse(ipadd).Netmask + "\r\n\r\n";
                //richTextBox_ip_result.Text += "前缀长度: " + System.Net.IPNetwork.Parse(ipadd).Cidr + "\r\n";

                richTextBox_ip_result.Text += "Network Address: " + System.Net.IPNetwork.Parse(ipadd).Network + "/" + System.Net.IPNetwork.Parse(ipadd).Cidr + "\r\n\r\n";
                richTextBox_ip_result.Text += "Address Range: " + System.Net.IPNetwork.Parse(ipadd).FirstUsable + "/" + System.Net.IPNetwork.Parse(ipadd).Cidr + "  -" + "  " + System.Net.IPNetwork.Parse(ipadd).LastUsable + "/" + System.Net.IPNetwork.Parse(ipadd).Cidr + "\r\n\r\n";
                richTextBox_ip_result.Text += "No. of Addresses: " + System.Net.IPNetwork.Parse(ipadd).Usable + "\r\n\r\n";
                richTextBox_ip_result.Text += "Prefix: " + System.Net.IPNetwork.Parse(ipadd).Netmask + "\r\n\r\n";
                richTextBox_ip_result.Text += "Prefix Length: " + System.Net.IPNetwork.Parse(ipadd).Cidr + "\r\n";
            }
            else
            {
                //MessageBox.Show("The IP is not a IPv4 or a IPv6!", "IPv4 or IPv6");
                //return;
                richTextBox_ip_result.ForeColor = Color.Red;
                //richTextBox_ip_result.Font = new Font(richTextBox_ip_result.Font, FontStyle.Bold);
                //richTextBox_ip_result.Font = new Font(richTextBox_ip_result.Font.Name, 10);
                richTextBox_ip_result.Text = "The IP is not a IPv4, IPv6, or IPv4 Range, IPv6 Range!";
            }
        }

        //验证IPv4
        public bool is_ipv4(string ip_v4)
        {
            //Regex reg = new Regex(@"(?n)^\s*(([1-9]?[0-9]|1[0-9]{2}|2([0-4][0-9]|5[0-5]))\.){3}([1-9]?[0-9]|1[0-9]{2}|2([0-4][0-9]|5[0-5]))\s*$");
            Regex reg = new Regex(@"^(((\d{1,2})|(1\d{2})|(2[0-4]\d)|(25[0-5]))\.){3}((\d{1,2})|(1\d{2})|(2[0-4]\d)|(25[0-5]))$");
            if (reg.IsMatch(ip_v4))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool is_ipv4_range(string ip_v4)
        {
            Regex reg = new Regex(@"^(((\d{1,2})|(1\d{2})|(2[0-4]\d)|(25[0-5]))\.){3}((\d{1,2})|(1\d{2})|(2[0-4]\d)|(25[0-5]))/([0-9]|[1,2][0-9]|3[0-2])$");
            if (reg.IsMatch(ip_v4))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //验证IPv6
        public bool is_ipv6(string ip_v6)
        {
            Regex reg = new Regex(@"^\s*((([0-9A-Fa-f]{1,4}:){7}([0-9A-Fa-f]{1,4}|:))|(([0-9A-Fa-f]{1,4}:){6}(:[0-9A-Fa-f]{1,4}|((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3})|:))|(([0-9A-Fa-f]{1,4}:){5}(((:[0-9A-Fa-f]{1,4}){1,2})|:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3})|:))|(([0-9A-Fa-f]{1,4}:){4}(((:[0-9A-Fa-f]{1,4}){1,3})|((:[0-9A-Fa-f]{1,4})?:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(([0-9A-Fa-f]{1,4}:){3}(((:[0-9A-Fa-f]{1,4}){1,4})|((:[0-9A-Fa-f]{1,4}){0,2}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(([0-9A-Fa-f]{1,4}:){2}(((:[0-9A-Fa-f]{1,4}){1,5})|((:[0-9A-Fa-f]{1,4}){0,3}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(([0-9A-Fa-f]{1,4}:){1}(((:[0-9A-Fa-f]{1,4}){1,6})|((:[0-9A-Fa-f]{1,4}){0,4}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(:(((:[0-9A-Fa-f]{1,4}){1,7})|((:[0-9A-Fa-f]{1,4}){0,5}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:)))(%.+)?\s*$");
            if (reg.IsMatch(ip_v6))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool is_ipv6_range(string ip_v6)
        {
            Regex reg = new Regex(@"^\s*((([0-9A-Fa-f]{1,4}:){7}([0-9A-Fa-f]{1,4}|:))|(([0-9A-Fa-f]{1,4}:){6}(:[0-9A-Fa-f]{1,4}|((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3})|:))|(([0-9A-Fa-f]{1,4}:){5}(((:[0-9A-Fa-f]{1,4}){1,2})|:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3})|:))|(([0-9A-Fa-f]{1,4}:){4}(((:[0-9A-Fa-f]{1,4}){1,3})|((:[0-9A-Fa-f]{1,4})?:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(([0-9A-Fa-f]{1,4}:){3}(((:[0-9A-Fa-f]{1,4}){1,4})|((:[0-9A-Fa-f]{1,4}){0,2}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(([0-9A-Fa-f]{1,4}:){2}(((:[0-9A-Fa-f]{1,4}){1,5})|((:[0-9A-Fa-f]{1,4}){0,3}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(([0-9A-Fa-f]{1,4}:){1}(((:[0-9A-Fa-f]{1,4}){1,6})|((:[0-9A-Fa-f]{1,4}){0,4}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(:(((:[0-9A-Fa-f]{1,4}){1,7})|((:[0-9A-Fa-f]{1,4}){0,5}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:)))(%.+)?\s*/([0-9]|[1-9][0-9]|1[0-1][0-9]|12[0-8])$");
            if (reg.IsMatch(ip_v6))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void textBox_ip_address_KeyUp(object sender, KeyEventArgs e)
        {
            richTextBox_ip_result.Text = "";

            if (textBox_ip_address.Text == "")
            {
                //MessageBox.Show("IPv4 or IPv6 cannot be empty!", "IPv4 or IPv6");
                //return;
                richTextBox_ip_result.ForeColor = Color.Red;
                //richTextBox_ip_result.Font = new Font(richTextBox_ip_result.Font, FontStyle.Bold);
                //richTextBox_ip_result.Font = new Font(richTextBox_ip_result.Font.Name, 10);
                richTextBox_ip_result.Text = "IPv4, IPv6, IPv4 Range or IPv6 Range cannot be empty!";
            }
            else if ((!is_ipv4(textBox_ip_address.Text)) && (!is_ipv4_range(textBox_ip_address.Text)) && (!is_ipv6(textBox_ip_address.Text)) && (!is_ipv6_range(textBox_ip_address.Text)))
            {
                //MessageBox.Show("The IP is not a IPv4 or a IPv6!", "IPv4 or IPv6");
                //return;
                richTextBox_ip_result.ForeColor = Color.Red;
                //richTextBox_ip_result.Font = new Font(richTextBox_ip_result.Font, FontStyle.Bold);
                //richTextBox_ip_result.Font = new Font(richTextBox_ip_result.Font.Name, 10);
                richTextBox_ip_result.Text = "The IP is not a IPv4, IPv6, or IPv4 Range, IPv6 Range!";

            }
            else
            {
                richTextBox_ip_result.ForeColor = Color.Black;
                ip_result(textBox_ip_address.Text);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["about"];  //查找是否打开过about窗体  
            if ((f == null) || (f.IsDisposed)) //没打开过  
            {
                about fa = new about();
                fa.Show();   //重新new一个Show出来
            }
            else
            {
                f.Activate();   //打开过就让其获得焦点  
                f.WindowState = FormWindowState.Normal;
            }
        }

        private void otherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["otherfunction"];  //查找是否打开过otherfunction窗体  
            if ((f == null) || (f.IsDisposed)) //没打开过  
            {
                otherfunction fa = new otherfunction();
                fa.Show();   //重新new一个Show出来
            }
            else
            {
                f.Activate();   //打开过就让其获得焦点  
                f.WindowState = FormWindowState.Normal;
            }
        }
    }
}
