namespace IPCalculate
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label_ip_address = new System.Windows.Forms.Label();
            this.textBox_ip_address = new System.Windows.Forms.TextBox();
            this.menuStrip_main = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox_ip_result = new System.Windows.Forms.RichTextBox();
            this.toolTip_main = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_ip_address
            // 
            this.label_ip_address.AutoSize = true;
            this.label_ip_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ip_address.Location = new System.Drawing.Point(6, 14);
            this.label_ip_address.Name = "label_ip_address";
            this.label_ip_address.Size = new System.Drawing.Size(83, 18);
            this.label_ip_address.TabIndex = 0;
            this.label_ip_address.Text = "IP Address:";
            // 
            // textBox_ip_address
            // 
            this.textBox_ip_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_ip_address.Location = new System.Drawing.Point(92, 11);
            this.textBox_ip_address.Name = "textBox_ip_address";
            this.textBox_ip_address.Size = new System.Drawing.Size(222, 24);
            this.textBox_ip_address.TabIndex = 1;
            this.toolTip_main.SetToolTip(this.textBox_ip_address, "Fill an available IPv4 or IPv6 address or range");
            this.textBox_ip_address.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_ip_address_KeyUp);
            // 
            // menuStrip_main
            // 
            this.menuStrip_main.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip_main.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip_main.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip_main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.otherToolStripMenuItem});
            this.menuStrip_main.Location = new System.Drawing.Point(306, 4);
            this.menuStrip_main.Name = "menuStrip_main";
            this.menuStrip_main.Size = new System.Drawing.Size(135, 28);
            this.menuStrip_main.TabIndex = 3;
            this.menuStrip_main.Text = "menuStrip_ipc";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.ToolTipText = "Check about for help";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.otherToolStripMenuItem.Text = "More";
            this.otherToolStripMenuItem.ToolTipText = "More functions including IP in IP range check, IP range merge, or IP subnetted.";
            this.otherToolStripMenuItem.Click += new System.EventHandler(this.otherToolStripMenuItem_Click);
            // 
            // richTextBox_ip_result
            // 
            this.richTextBox_ip_result.BackColor = System.Drawing.Color.Linen;
            this.richTextBox_ip_result.Cursor = System.Windows.Forms.Cursors.Hand;
            this.richTextBox_ip_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox_ip_result.Location = new System.Drawing.Point(9, 42);
            this.richTextBox_ip_result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox_ip_result.Name = "richTextBox_ip_result";
            this.richTextBox_ip_result.ReadOnly = true;
            this.richTextBox_ip_result.Size = new System.Drawing.Size(432, 281);
            this.richTextBox_ip_result.TabIndex = 9;
            this.richTextBox_ip_result.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 337);
            this.Controls.Add(this.richTextBox_ip_result);
            this.Controls.Add(this.textBox_ip_address);
            this.Controls.Add(this.label_ip_address);
            this.Controls.Add(this.menuStrip_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_main;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "IP Calculate";
            this.menuStrip_main.ResumeLayout(false);
            this.menuStrip_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ip_address;
        private System.Windows.Forms.TextBox textBox_ip_address;
        private System.Windows.Forms.MenuStrip menuStrip_main;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox_ip_result;
        private System.Windows.Forms.ToolTip toolTip_main;
    }
}

