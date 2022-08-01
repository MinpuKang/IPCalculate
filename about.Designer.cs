namespace IPCalculate
{
    partial class about
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(about));
            this.pictureBox_qiheyehk = new System.Windows.Forms.PictureBox();
            this.author_label = new System.Windows.Forms.Label();
            this.mail_linkLabel = new System.Windows.Forms.LinkLabel();
            this.richTextBox_description = new System.Windows.Forms.RichTextBox();
            this.back_button = new System.Windows.Forms.Button();
            this.label_scan = new System.Windows.Forms.Label();
            this.version_label = new System.Windows.Forms.Label();
            this.versionlabel = new System.Windows.Forms.Label();
            this.pictureBox_ico = new System.Windows.Forms.PictureBox();
            this.toolTip_about = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_qiheyehk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ico)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_qiheyehk
            // 
            this.pictureBox_qiheyehk.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_qiheyehk.Image")));
            this.pictureBox_qiheyehk.Location = new System.Drawing.Point(-9, 5);
            this.pictureBox_qiheyehk.Name = "pictureBox_qiheyehk";
            this.pictureBox_qiheyehk.Size = new System.Drawing.Size(197, 168);
            this.pictureBox_qiheyehk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_qiheyehk.TabIndex = 0;
            this.pictureBox_qiheyehk.TabStop = false;
            this.toolTip_about.SetToolTip(this.pictureBox_qiheyehk, "Scan QR code to follow qiheyehk Wechat Official Acccount, phtogoraphy, networking" +
        " and so on.");
            // 
            // author_label
            // 
            this.author_label.AutoSize = true;
            this.author_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.author_label.Location = new System.Drawing.Point(192, 58);
            this.author_label.Name = "author_label";
            this.author_label.Size = new System.Drawing.Size(94, 18);
            this.author_label.TabIndex = 6;
            this.author_label.Text = "Copyright  @";
            // 
            // mail_linkLabel
            // 
            this.mail_linkLabel.AutoSize = true;
            this.mail_linkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mail_linkLabel.Location = new System.Drawing.Point(286, 58);
            this.mail_linkLabel.Name = "mail_linkLabel";
            this.mail_linkLabel.Size = new System.Drawing.Size(86, 18);
            this.mail_linkLabel.TabIndex = 7;
            this.mail_linkLabel.TabStop = true;
            this.mail_linkLabel.Text = "Minpu Kang";
            this.toolTip_about.SetToolTip(this.mail_linkLabel, "https://hk314.top/");
            this.mail_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.mail_linkLabel_LinkClicked);
            // 
            // richTextBox_description
            // 
            this.richTextBox_description.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox_description.Cursor = System.Windows.Forms.Cursors.Hand;
            this.richTextBox_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox_description.Location = new System.Drawing.Point(195, 131);
            this.richTextBox_description.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox_description.Name = "richTextBox_description";
            this.richTextBox_description.ReadOnly = true;
            this.richTextBox_description.Size = new System.Drawing.Size(396, 193);
            this.richTextBox_description.TabIndex = 8;
            this.richTextBox_description.Text = resources.GetString("richTextBox_description.Text");
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(516, 329);
            this.back_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 26);
            this.back_button.TabIndex = 9;
            this.back_button.Text = "OK";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // label_scan
            // 
            this.label_scan.AutoSize = true;
            this.label_scan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_scan.Location = new System.Drawing.Point(192, 86);
            this.label_scan.Name = "label_scan";
            this.label_scan.Size = new System.Drawing.Size(402, 36);
            this.label_scan.TabIndex = 10;
            this.label_scan.Text = "WeChat Official Account: qiheyehk (Scan QR code to follow\r\nfor bug feedback)";
            // 
            // version_label
            // 
            this.version_label.AutoSize = true;
            this.version_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.version_label.ForeColor = System.Drawing.Color.Black;
            this.version_label.Location = new System.Drawing.Point(192, 9);
            this.version_label.Name = "version_label";
            this.version_label.Size = new System.Drawing.Size(190, 18);
            this.version_label.TabIndex = 5;
            this.version_label.Text = "Product Name: IP Calculate";
            // 
            // versionlabel
            // 
            this.versionlabel.AutoSize = true;
            this.versionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.versionlabel.Location = new System.Drawing.Point(192, 33);
            this.versionlabel.Name = "versionlabel";
            this.versionlabel.Size = new System.Drawing.Size(86, 18);
            this.versionlabel.TabIndex = 11;
            this.versionlabel.Text = "Version: 1.1";
            // 
            // pictureBox_ico
            // 
            this.pictureBox_ico.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_ico.Image")));
            this.pictureBox_ico.Location = new System.Drawing.Point(-8, 176);
            this.pictureBox_ico.Name = "pictureBox_ico";
            this.pictureBox_ico.Size = new System.Drawing.Size(197, 171);
            this.pictureBox_ico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_ico.TabIndex = 12;
            this.pictureBox_ico.TabStop = false;
            // 
            // about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(603, 360);
            this.Controls.Add(this.pictureBox_ico);
            this.Controls.Add(this.versionlabel);
            this.Controls.Add(this.label_scan);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.richTextBox_description);
            this.Controls.Add(this.mail_linkLabel);
            this.Controls.Add(this.author_label);
            this.Controls.Add(this.version_label);
            this.Controls.Add(this.pictureBox_qiheyehk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "about";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_qiheyehk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_qiheyehk;
        private System.Windows.Forms.Label author_label;
        private System.Windows.Forms.LinkLabel mail_linkLabel;
        private System.Windows.Forms.RichTextBox richTextBox_description;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label_scan;
        private System.Windows.Forms.Label version_label;
        private System.Windows.Forms.Label versionlabel;
        private System.Windows.Forms.PictureBox pictureBox_ico;
        private System.Windows.Forms.ToolTip toolTip_about;
    }
}