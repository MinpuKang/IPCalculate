namespace IPCalculate
{
    partial class otherfunction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(otherfunction));
            this.groupBox_ip_in_range = new System.Windows.Forms.GroupBox();
            this.richTextBox_ip_result = new System.Windows.Forms.RichTextBox();
            this.textBox_ip_address = new System.Windows.Forms.TextBox();
            this.label_ip_address = new System.Windows.Forms.Label();
            this.textBox_ip_range = new System.Windows.Forms.TextBox();
            this.label_ip_range = new System.Windows.Forms.Label();
            this.groupBox_ip_merge = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ip_range2_merge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox_ip_merge_result = new System.Windows.Forms.RichTextBox();
            this.textBox_ip_range1_merge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_ip_subnetted = new System.Windows.Forms.GroupBox();
            this.textBox_new_cidr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox_ip_subnetted_result = new System.Windows.Forms.RichTextBox();
            this.textBox_ip_range_subnetted = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.toolTip_otherFuntion = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox_ip_in_range.SuspendLayout();
            this.groupBox_ip_merge.SuspendLayout();
            this.groupBox_ip_subnetted.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_ip_in_range
            // 
            this.groupBox_ip_in_range.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox_ip_in_range.Controls.Add(this.richTextBox_ip_result);
            this.groupBox_ip_in_range.Controls.Add(this.textBox_ip_address);
            this.groupBox_ip_in_range.Controls.Add(this.label_ip_address);
            this.groupBox_ip_in_range.Controls.Add(this.textBox_ip_range);
            this.groupBox_ip_in_range.Controls.Add(this.label_ip_range);
            this.groupBox_ip_in_range.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_ip_in_range.Location = new System.Drawing.Point(12, 12);
            this.groupBox_ip_in_range.Name = "groupBox_ip_in_range";
            this.groupBox_ip_in_range.Size = new System.Drawing.Size(330, 206);
            this.groupBox_ip_in_range.TabIndex = 1;
            this.groupBox_ip_in_range.TabStop = false;
            this.groupBox_ip_in_range.Text = "IP in Range";
            // 
            // richTextBox_ip_result
            // 
            this.richTextBox_ip_result.BackColor = System.Drawing.Color.Linen;
            this.richTextBox_ip_result.Cursor = System.Windows.Forms.Cursors.Hand;
            this.richTextBox_ip_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox_ip_result.Location = new System.Drawing.Point(13, 118);
            this.richTextBox_ip_result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox_ip_result.Name = "richTextBox_ip_result";
            this.richTextBox_ip_result.ReadOnly = true;
            this.richTextBox_ip_result.Size = new System.Drawing.Size(305, 81);
            this.richTextBox_ip_result.TabIndex = 6;
            this.richTextBox_ip_result.Text = "";
            // 
            // textBox_ip_address
            // 
            this.textBox_ip_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_ip_address.Location = new System.Drawing.Point(157, 75);
            this.textBox_ip_address.Name = "textBox_ip_address";
            this.textBox_ip_address.Size = new System.Drawing.Size(161, 24);
            this.textBox_ip_address.TabIndex = 5;
            this.toolTip_otherFuntion.SetToolTip(this.textBox_ip_address, "Fill in a IPv4 or IPv6 address or range");
            this.textBox_ip_address.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_ip_address_KeyUp);
            // 
            // label_ip_address
            // 
            this.label_ip_address.AutoSize = true;
            this.label_ip_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ip_address.Location = new System.Drawing.Point(10, 78);
            this.label_ip_address.Name = "label_ip_address";
            this.label_ip_address.Size = new System.Drawing.Size(148, 18);
            this.label_ip_address.TabIndex = 4;
            this.label_ip_address.Text = "IP Address or Range:";
            // 
            // textBox_ip_range
            // 
            this.textBox_ip_range.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_ip_range.Location = new System.Drawing.Point(96, 37);
            this.textBox_ip_range.Name = "textBox_ip_range";
            this.textBox_ip_range.Size = new System.Drawing.Size(222, 24);
            this.textBox_ip_range.TabIndex = 3;
            this.toolTip_otherFuntion.SetToolTip(this.textBox_ip_range, "Fill in a IPv4 or IPv6 range");
            this.textBox_ip_range.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_ip_range_KeyUp);
            // 
            // label_ip_range
            // 
            this.label_ip_range.AutoSize = true;
            this.label_ip_range.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ip_range.Location = new System.Drawing.Point(10, 38);
            this.label_ip_range.Name = "label_ip_range";
            this.label_ip_range.Size = new System.Drawing.Size(72, 18);
            this.label_ip_range.TabIndex = 2;
            this.label_ip_range.Text = "IP Range:";
            // 
            // groupBox_ip_merge
            // 
            this.groupBox_ip_merge.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox_ip_merge.Controls.Add(this.label5);
            this.groupBox_ip_merge.Controls.Add(this.textBox_ip_range2_merge);
            this.groupBox_ip_merge.Controls.Add(this.label1);
            this.groupBox_ip_merge.Controls.Add(this.richTextBox_ip_merge_result);
            this.groupBox_ip_merge.Controls.Add(this.textBox_ip_range1_merge);
            this.groupBox_ip_merge.Controls.Add(this.label2);
            this.groupBox_ip_merge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_ip_merge.Location = new System.Drawing.Point(12, 237);
            this.groupBox_ip_merge.Name = "groupBox_ip_merge";
            this.groupBox_ip_merge.Size = new System.Drawing.Size(330, 211);
            this.groupBox_ip_merge.TabIndex = 7;
            this.groupBox_ip_merge.TabStop = false;
            this.groupBox_ip_merge.Text = "IP Merge";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(10, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(325, 51);
            this.label5.TabIndex = 13;
            this.label5.Text = "Note: not all can be merged.\r\n   At least two range filled and followed each othe" +
    "r.\r\n   e.g.: 10.1.0.0/24 and 10.1.1.0/24";
            // 
            // textBox_ip_range2_merge
            // 
            this.textBox_ip_range2_merge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_ip_range2_merge.Location = new System.Drawing.Point(97, 66);
            this.textBox_ip_range2_merge.Name = "textBox_ip_range2_merge";
            this.textBox_ip_range2_merge.Size = new System.Drawing.Size(222, 24);
            this.textBox_ip_range2_merge.TabIndex = 11;
            this.toolTip_otherFuntion.SetToolTip(this.textBox_ip_range2_merge, "Fill in a IPv4 or IPv6 address or range");
            this.textBox_ip_range2_merge.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_ip_range2_merge_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(11, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "IP Range 2:";
            // 
            // richTextBox_ip_merge_result
            // 
            this.richTextBox_ip_merge_result.BackColor = System.Drawing.Color.Linen;
            this.richTextBox_ip_merge_result.Cursor = System.Windows.Forms.Cursors.Hand;
            this.richTextBox_ip_merge_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox_ip_merge_result.Location = new System.Drawing.Point(13, 141);
            this.richTextBox_ip_merge_result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox_ip_merge_result.Name = "richTextBox_ip_merge_result";
            this.richTextBox_ip_merge_result.ReadOnly = true;
            this.richTextBox_ip_merge_result.Size = new System.Drawing.Size(305, 63);
            this.richTextBox_ip_merge_result.TabIndex = 12;
            this.richTextBox_ip_merge_result.Text = "";
            // 
            // textBox_ip_range1_merge
            // 
            this.textBox_ip_range1_merge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_ip_range1_merge.Location = new System.Drawing.Point(96, 37);
            this.textBox_ip_range1_merge.Name = "textBox_ip_range1_merge";
            this.textBox_ip_range1_merge.Size = new System.Drawing.Size(222, 24);
            this.textBox_ip_range1_merge.TabIndex = 9;
            this.toolTip_otherFuntion.SetToolTip(this.textBox_ip_range1_merge, "Fill in a IPv4 or IPv6 address or range");
            this.textBox_ip_range1_merge.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_ip_range1_merge_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "IP Range 1: ";
            // 
            // groupBox_ip_subnetted
            // 
            this.groupBox_ip_subnetted.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox_ip_subnetted.Controls.Add(this.textBox_new_cidr);
            this.groupBox_ip_subnetted.Controls.Add(this.label3);
            this.groupBox_ip_subnetted.Controls.Add(this.richTextBox_ip_subnetted_result);
            this.groupBox_ip_subnetted.Controls.Add(this.textBox_ip_range_subnetted);
            this.groupBox_ip_subnetted.Controls.Add(this.label4);
            this.groupBox_ip_subnetted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_ip_subnetted.Location = new System.Drawing.Point(364, 12);
            this.groupBox_ip_subnetted.Name = "groupBox_ip_subnetted";
            this.groupBox_ip_subnetted.Size = new System.Drawing.Size(330, 410);
            this.groupBox_ip_subnetted.TabIndex = 13;
            this.groupBox_ip_subnetted.TabStop = false;
            this.groupBox_ip_subnetted.Text = "IP Subnetted";
            // 
            // textBox_new_cidr
            // 
            this.textBox_new_cidr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_new_cidr.Location = new System.Drawing.Point(97, 79);
            this.textBox_new_cidr.Name = "textBox_new_cidr";
            this.textBox_new_cidr.Size = new System.Drawing.Size(221, 24);
            this.textBox_new_cidr.TabIndex = 17;
            this.toolTip_otherFuntion.SetToolTip(this.textBox_new_cidr, "Fill in an integer, 0-32 for IPv4, and 0-128 for IPv6");
            this.textBox_new_cidr.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_new_cidr_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(11, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "New CIDR:";
            // 
            // richTextBox_ip_subnetted_result
            // 
            this.richTextBox_ip_subnetted_result.BackColor = System.Drawing.Color.Linen;
            this.richTextBox_ip_subnetted_result.Cursor = System.Windows.Forms.Cursors.Hand;
            this.richTextBox_ip_subnetted_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox_ip_subnetted_result.Location = new System.Drawing.Point(13, 118);
            this.richTextBox_ip_subnetted_result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox_ip_subnetted_result.Name = "richTextBox_ip_subnetted_result";
            this.richTextBox_ip_subnetted_result.ReadOnly = true;
            this.richTextBox_ip_subnetted_result.Size = new System.Drawing.Size(305, 278);
            this.richTextBox_ip_subnetted_result.TabIndex = 19;
            this.richTextBox_ip_subnetted_result.Text = "";
            // 
            // textBox_ip_range_subnetted
            // 
            this.textBox_ip_range_subnetted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_ip_range_subnetted.Location = new System.Drawing.Point(96, 37);
            this.textBox_ip_range_subnetted.Name = "textBox_ip_range_subnetted";
            this.textBox_ip_range_subnetted.Size = new System.Drawing.Size(222, 24);
            this.textBox_ip_range_subnetted.TabIndex = 15;
            this.toolTip_otherFuntion.SetToolTip(this.textBox_ip_range_subnetted, "Fill in a IPv4 or IPv6 address or range");
            this.textBox_ip_range_subnetted.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_ip_range_subnetted_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(10, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "IP Range: ";
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(608, 425);
            this.back_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 26);
            this.back_button.TabIndex = 20;
            this.back_button.Text = "OK";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // otherfunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 460);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.groupBox_ip_subnetted);
            this.Controls.Add(this.groupBox_ip_merge);
            this.Controls.Add(this.groupBox_ip_in_range);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "otherfunction";
            this.Text = "More Function";
            this.groupBox_ip_in_range.ResumeLayout(false);
            this.groupBox_ip_in_range.PerformLayout();
            this.groupBox_ip_merge.ResumeLayout(false);
            this.groupBox_ip_merge.PerformLayout();
            this.groupBox_ip_subnetted.ResumeLayout(false);
            this.groupBox_ip_subnetted.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_ip_in_range;
        private System.Windows.Forms.TextBox textBox_ip_range;
        private System.Windows.Forms.Label label_ip_range;
        private System.Windows.Forms.TextBox textBox_ip_address;
        private System.Windows.Forms.Label label_ip_address;
        private System.Windows.Forms.RichTextBox richTextBox_ip_result;
        private System.Windows.Forms.GroupBox groupBox_ip_merge;
        private System.Windows.Forms.RichTextBox richTextBox_ip_merge_result;
        private System.Windows.Forms.TextBox textBox_ip_range1_merge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ip_range2_merge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_ip_subnetted;
        private System.Windows.Forms.TextBox textBox_new_cidr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox_ip_subnetted_result;
        private System.Windows.Forms.TextBox textBox_ip_range_subnetted;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip_otherFuntion;
    }
}