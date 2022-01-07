
namespace NetworkCardHelper.Forms
{
    partial class PublicDNSForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_public_dns_confrim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Items.AddRange(new object[] {
            "114 DNS(114.114.114.114)",
            "114 DNS(114.114.115.115)",
            "",
            "百度 DNS(180.76.76.76)",
            "",
            "阿里 DNS(223.5.5.5)",
            "阿里 DNS(223.6.6.6)",
            "",
            "腾讯 DNS(119.28.28.28)",
            "腾讯 DNS(119.29.29.29)",
            "",
            "Google DNS (8.8.8.8)",
            "Google DNS (8.8.4.4)",
            "",
            "CloudFlare DNS(1.1.1.1)",
            "CloudFlare DNS(1.0.0.1)",
            "",
            "Open DNS (208.67.222.220)",
            "Open DNS (208.67.220.222)"});
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(460, 232);
            this.listBox1.TabIndex = 0;
            this.listBox1.DoubleClick += new System.EventHandler(this.doubleTest_Click);
            // 
            // button_public_dns_confrim
            // 
            this.button_public_dns_confrim.Location = new System.Drawing.Point(397, 250);
            this.button_public_dns_confrim.Name = "button_public_dns_confrim";
            this.button_public_dns_confrim.Size = new System.Drawing.Size(75, 23);
            this.button_public_dns_confrim.TabIndex = 1;
            this.button_public_dns_confrim.Text = "确认";
            this.button_public_dns_confrim.UseVisualStyleBackColor = true;
            this.button_public_dns_confrim.Click += new System.EventHandler(this.button_public_dns_confrim_Click);
            // 
            // PublicDNSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 279);
            this.Controls.Add(this.button_public_dns_confrim);
            this.Controls.Add(this.listBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PublicDNSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "公共DNS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_public_dns_confrim;
    }
}