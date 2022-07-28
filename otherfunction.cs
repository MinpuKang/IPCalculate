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
    public partial class otherfunction : Form
    {
        public otherfunction()
        {
            InitializeComponent();

            textBox_ip_range.Text = "1.1.1.0/24";
            textBox_ip_address.Text = "1.1.1.1";
            ip_contain_or_overlap(textBox_ip_range.Text, textBox_ip_address.Text);


            textBox_ip_range1_merge.Text = "2.2.0.0/29";
            textBox_ip_range2_merge.Text = "2.2.0.8/29";
            ip_range_merge(textBox_ip_range1_merge.Text, textBox_ip_range2_merge.Text);

            textBox_ip_range_subnetted.Text = "0.0.0.0/16";
            textBox_new_cidr.Text = "20";
            ip_range_subnetted(textBox_ip_range_subnetted.Text, textBox_new_cidr.Text);
        }

        //验证输入的数据是不是正整数,传入字符串,返回true或者false
        static bool is_integer(string str)
        {
            System.Text.RegularExpressions.Regex reg1 = new System.Text.RegularExpressions.Regex(@"^[0-9]\d*$");
            return reg1.IsMatch(str);
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

        // to check if ip contain or overlap
        public void ip_contain_or_overlap(string iprange, string iprang_or_address)
        {
            if (is_ipv4_range(iprange))
            {
                if (is_ipv4(iprang_or_address))
                {
                    System.Net.IPNetwork ipnetwork = System.Net.IPNetwork.Parse(iprange);
                    System.Net.IPAddress ipaddress = System.Net.IPAddress.Parse(iprang_or_address);
                    bool contains = ipnetwork.Contains(ipaddress);
                    richTextBox_ip_result.Text = iprange + " contains " + iprang_or_address + ": " + contains.ToString();
                }
                else if (is_ipv4_range(iprang_or_address))
                {
                    System.Net.IPNetwork ipnetwork = System.Net.IPNetwork.Parse(iprange);
                    System.Net.IPNetwork ipnetwork2 = System.Net.IPNetwork.Parse(iprang_or_address);
                    bool overlap = ipnetwork.Overlap(ipnetwork2);
                    richTextBox_ip_result.Text = iprange + " overlap " + iprang_or_address + ": " + overlap.ToString();
                }
                else
                {
                    richTextBox_ip_result.Text = iprang_or_address + " is not a correct IPv4 or IPv6 range!";
                }
            }
            else if (is_ipv6_range(iprange))
            {
                if (is_ipv6(iprang_or_address))
                {
                    System.Net.IPNetwork ipnetwork = System.Net.IPNetwork.Parse(iprange);
                    System.Net.IPAddress ipaddress = System.Net.IPAddress.Parse(iprang_or_address);
                    bool contains = ipnetwork.Contains(ipaddress);
                    richTextBox_ip_result.Text = iprange + " contains " + iprang_or_address + ": " + contains.ToString();
                }
                else if (is_ipv6_range(iprang_or_address))
                {
                    System.Net.IPNetwork ipnetwork = System.Net.IPNetwork.Parse(iprange);
                    System.Net.IPNetwork ipnetwork2 = System.Net.IPNetwork.Parse(iprang_or_address);
                    bool overlap = ipnetwork.Overlap(ipnetwork2);
                    richTextBox_ip_result.Text = iprange + " overlap " + iprang_or_address + ": " + overlap.ToString();
                }
                else
                {
                    richTextBox_ip_result.Text = iprang_or_address + " is not a correct IPv6 or IPv6 range!";
                }
            }
            else
            {
                richTextBox_ip_result.Text = iprange + " is not a correct IPv4 or IPv6 range!";
            }
        }

        private void textBox_ip_range_KeyUp(object sender, KeyEventArgs e)
        {
            if ((textBox_ip_range.Text != "") && (textBox_ip_address.Text != ""))
            {
                ip_contain_or_overlap(textBox_ip_range.Text, textBox_ip_address.Text);
            }
            else
            {
                richTextBox_ip_result.Text = "The IP address or IP range canot be empty!";
            }
        }

        private void textBox_ip_address_KeyUp(object sender, KeyEventArgs e)
        {
            if ((textBox_ip_range.Text != "") && (textBox_ip_address.Text != ""))
            {
                ip_contain_or_overlap(textBox_ip_range.Text, textBox_ip_address.Text);
            }
            else
            {
                richTextBox_ip_result.Text = "The IP address or IP range cannot be empty!";
            }
        }

        //for ip merge
        public void ip_range_merge(string iprange1, string iprange2)
        {
            if (((is_ipv4_range(iprange1)) && (is_ipv4_range(iprange2))) || ((is_ipv6_range(iprange1)) && (is_ipv6_range(iprange2))))
            {
                System.Net.IPNetwork ipnetwork1 = System.Net.IPNetwork.Parse(iprange1);
                System.Net.IPNetwork ipnetwork2 = System.Net.IPNetwork.Parse(iprange2);

                if (Convert.ToInt32(System.Net.IPNetwork.Parse(iprange1).Cidr) == Convert.ToInt32(System.Net.IPNetwork.Parse(iprange2).Cidr))
                {
                    if (ipnetwork1.CompareTo(ipnetwork2) == -1)
                    {
                        System.Net.IPNetwork[] ipnetwork_merge = System.Net.IPNetwork.Supernet(new[] { ipnetwork1, ipnetwork2 });

                        if (iprange1 == Convert.ToString(ipnetwork_merge[0]))
                        {
                            richTextBox_ip_merge_result.Text = iprange1 + " and " + iprange2 + " cannot be merged as they are not belong to a new range cover these two range only";
                        }
                        else
                        {
                            richTextBox_ip_merge_result.Text = iprange1 + " + " + iprange2 + " = " + ipnetwork_merge[0];
                        }

                        //richTextBox_ip_merge_result.Text += "\r\n" + ipnetwork1.CompareTo(ipnetwork2);
                    }
                    else if (ipnetwork1.CompareTo(ipnetwork2) == 0)
                    {
                        System.Net.IPNetwork[] ipnetwork_merge = System.Net.IPNetwork.Supernet(new[] { ipnetwork2, ipnetwork1 });
                        richTextBox_ip_merge_result.Text = iprange2 + " + " + iprange1 + " = " + ipnetwork_merge[0];

                        //richTextBox_ip_merge_result.Text += "\r\n" + ipnetwork1.CompareTo(ipnetwork2);
                    }
                    else
                    {
                        System.Net.IPNetwork[] ipnetwork_merge = System.Net.IPNetwork.Supernet(new[] { ipnetwork2, ipnetwork1 });

                        if (iprange2 == Convert.ToString(ipnetwork_merge[0]))
                        {
                            richTextBox_ip_merge_result.Text = iprange2 + " and " + iprange1 + " cannot be merged as they are not belong to a new range cover these two range only";
                        }
                        else
                        {
                            richTextBox_ip_merge_result.Text = iprange2 + " + " + iprange1 + " = " + ipnetwork_merge[0];
                        }

                        //richTextBox_ip_merge_result.Text += "\r\n" + ipnetwork1.CompareTo(ipnetwork2);
                    }
                }
                else
                {
                    richTextBox_ip_merge_result.Text = "The two IP range have different netmask length, then cannot be merged!";
                }
            }
            else if (((is_ipv4(iprange1)) && (is_ipv4(iprange2))) || ((is_ipv6(iprange1)) && (is_ipv6(iprange2))))
            {
                System.Net.IPNetwork ipnetwork1 = System.Net.IPNetwork.Parse(iprange1);
                System.Net.IPNetwork ipnetwork2 = System.Net.IPNetwork.Parse(iprange2);

                if (Convert.ToInt32(System.Net.IPNetwork.Parse(iprange1).Cidr) == Convert.ToInt32(System.Net.IPNetwork.Parse(iprange2).Cidr))
                {
                    if (ipnetwork1.CompareTo(ipnetwork2) == -1)
                    {
                        System.Net.IPNetwork[] ipnetwork_merge = System.Net.IPNetwork.Supernet(new[] { ipnetwork1, ipnetwork2 });
                        richTextBox_ip_merge_result.Text = iprange1 + " + " + iprange2 + " = " + ipnetwork_merge[0];
                    }
                    else
                    {
                        System.Net.IPNetwork[] ipnetwork_merge = System.Net.IPNetwork.Supernet(new[] { ipnetwork2, ipnetwork1 });
                        richTextBox_ip_merge_result.Text = iprange2 + " + " + iprange1 + " = " + ipnetwork_merge[0];
                    }
                }
                else
                {
                    richTextBox_ip_merge_result.Text = "The two IP range have different netmask length, then cannot be merged!";
                }
            }
            else
            {
                richTextBox_ip_merge_result.Text = "The two IP ranges are not both IPv4 or IPv6 format!";
            }
        }

        private void textBox_ip_range1_merge_KeyUp(object sender, KeyEventArgs e)
        {
            if ((textBox_ip_range1_merge.Text != "") && (textBox_ip_range2_merge.Text != ""))
            {
                ip_range_merge(textBox_ip_range1_merge.Text, textBox_ip_range2_merge.Text);
            }
            else
            {
                richTextBox_ip_merge_result.Text = "The two IP ranges canot be empty!";
            }
        }

        private void textBox_ip_range2_merge_KeyUp(object sender, KeyEventArgs e)
        {
            if ((textBox_ip_range1_merge.Text != "") && (textBox_ip_range2_merge.Text != ""))
            {
                ip_range_merge(textBox_ip_range1_merge.Text, textBox_ip_range2_merge.Text);
            }
            else
            {
                richTextBox_ip_merge_result.Text = "The two IP ranges cannot be empty!";
            }
        }

        //for ip subnetted
        public void ip_range_subnetted(string iprange, string cidr_string)
        {
            if ((iprange != "") && (cidr_string != ""))
            {
                if (is_integer(cidr_string))
                {
                    int cidr = Convert.ToInt32(cidr_string);

                    if (is_ipv4_range(iprange) || is_ipv4(iprange))
                    {
                        int current_cidr = System.Net.IPNetwork.Parse(iprange).Cidr;
                        if ((0 <= cidr) && (cidr <= 32))
                        {
                            if (current_cidr <= cidr)
                            {
                                System.Net.IPNetwork wholeIPnetwork = System.Net.IPNetwork.Parse(iprange);
                                System.Net.IPNetworkCollection subneted = wholeIPnetwork.Subnet(Convert.ToByte(cidr));
                                richTextBox_ip_subnetted_result.Text = wholeIPnetwork + " is subnetted into " + subneted.Count + " subnets. \r\n";
                                richTextBox_ip_subnetted_result.Text += "First subnet: " + subneted[0] + "\r\n";
                                richTextBox_ip_subnetted_result.Text += "Last subnet: " + subneted[subneted.Count - 1] + "\r\n";

                                if (subneted.Count > 10)
                                {
                                    richTextBox_ip_subnetted_result.Text += "The top ten subnets: " + "\r\n";
                                    for (int i = 0; i < 10; i++)
                                    {
                                        richTextBox_ip_subnetted_result.Text += "     " + subneted[i] + "\r\n";
                                    }
                                }
                                else
                                {
                                    richTextBox_ip_subnetted_result.Text += "All subnets: " + "\r\n";
                                    foreach (System.Net.IPNetwork ipnetwork in subneted)
                                    {
                                        richTextBox_ip_subnetted_result.Text += "     " + ipnetwork + "\r\n";
                                    }
                                }
                            }
                            else
                            {
                                richTextBox_ip_subnetted_result.Text = "The new CIDR need a higher value than current " + current_cidr + " in IP range!";
                            }
                        }
                        else
                        {
                            richTextBox_ip_subnetted_result.Text = "The new CIDR should be in range 0 to 32 when IP range is IPv4 format!";
                        }
                    }
                    else if (is_ipv6_range(iprange) || is_ipv6(iprange))
                    {
                        int current_cidr = System.Net.IPNetwork.Parse(iprange).Cidr;
                        if ((0 <= cidr) && (cidr <= 128))
                        {
                            if (current_cidr <= cidr)
                            {
                                System.Net.IPNetwork wholeIPnetwork = System.Net.IPNetwork.Parse(iprange);
                                System.Net.IPNetworkCollection subneted = wholeIPnetwork.Subnet(Convert.ToByte(cidr));
                                richTextBox_ip_subnetted_result.Text = wholeIPnetwork + " is subnetted into " + subneted.Count + " subnets. \r\n";
                                richTextBox_ip_subnetted_result.Text += "First subnet: " + subneted[0] + "\r\n";
                                richTextBox_ip_subnetted_result.Text += "Last subnet: " + subneted[subneted.Count - 1] + "\r\n";

                                if (subneted.Count > 10)
                                {
                                    richTextBox_ip_subnetted_result.Text += "The top ten subnets: " + "\r\n";
                                    for (int i = 0; i < 10; i++)
                                    {
                                        richTextBox_ip_subnetted_result.Text += "     " + subneted[i] + "\r\n";
                                    }
                                }
                                else
                                {
                                    richTextBox_ip_subnetted_result.Text += "All subnets: " + "\r\n";
                                    foreach (System.Net.IPNetwork ipnetwork in subneted)
                                    {
                                        richTextBox_ip_subnetted_result.Text += "     " + ipnetwork + "\r\n";
                                    }
                                }
                            }
                            else
                            {
                                richTextBox_ip_subnetted_result.Text = "The new CIDR need a higher value than current " + current_cidr + " in IP range!";
                            }
                        }
                        else
                        {
                            richTextBox_ip_subnetted_result.Text = "The new CIDR should be in range 0 to 128 when IP range is IPv6 format!";
                        }
                    }
                    else
                    {
                        richTextBox_ip_subnetted_result.Text = "The IP range is not IPv4 or IPv6 format!";
                    }
                }
                else
                {
                    richTextBox_ip_subnetted_result.Text = "The new CIDR should be an integer!";
                }
            }
            else
            {
                richTextBox_ip_subnetted_result.Text = "The IP ranges or new CIDR cannot be empty!";
            }
        }

        private void textBox_ip_range_subnetted_KeyUp(object sender, KeyEventArgs e)
        {
            ip_range_subnetted(textBox_ip_range_subnetted.Text, textBox_new_cidr.Text);
        }

        private void textBox_new_cidr_KeyUp(object sender, KeyEventArgs e)
        {
            ip_range_subnetted(textBox_ip_range_subnetted.Text, textBox_new_cidr.Text);
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
