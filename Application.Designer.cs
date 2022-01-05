
namespace NetworkCardHelper
{
    partial class Application
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1_TopOperate = new System.Windows.Forms.GroupBox();
            this.button_LoadNetwordCard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox_operate = new System.Windows.Forms.GroupBox();
            this.groupBox_IpInfo = new System.Windows.Forms.GroupBox();
            this.groupBox_IP = new System.Windows.Forms.GroupBox();
            this.label_ip_dns2_value = new System.Windows.Forms.Label();
            this.label_ip_dns1_value = new System.Windows.Forms.Label();
            this.label_ip_subnet_value = new System.Windows.Forms.Label();
            this.label_ip_gateway_value = new System.Windows.Forms.Label();
            this.label_ip_value = new System.Windows.Forms.Label();
            this.label_ip_dns2 = new System.Windows.Forms.Label();
            this.label_ip_dns1 = new System.Windows.Forms.Label();
            this.label_gateway = new System.Windows.Forms.Label();
            this.label_subnetmask = new System.Windows.Forms.Label();
            this.label_ip = new System.Windows.Forms.Label();
            this.label_CardDesc_Value = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_CardSpeed_Value = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_MAC_Value = new System.Windows.Forms.Label();
            this.label_Id = new System.Windows.Forms.Label();
            this.listBox_NetworkCard = new System.Windows.Forms.ListBox();
            this.button_trans_ip = new System.Windows.Forms.Button();
            this.button_trans_gateway = new System.Windows.Forms.Button();
            this.button_trans_subnet = new System.Windows.Forms.Button();
            this.button_trans_dns1 = new System.Windows.Forms.Button();
            this.button_trans_dns2 = new System.Windows.Forms.Button();
            this.textBox_ip_ip = new System.Windows.Forms.TextBox();
            this.textBox_ip_gateway = new System.Windows.Forms.TextBox();
            this.textBox_ip_subnet = new System.Windows.Forms.TextBox();
            this.textBox_ip_dns1 = new System.Windows.Forms.TextBox();
            this.textBox_ip_dns2 = new System.Windows.Forms.TextBox();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_ip_apply = new System.Windows.Forms.Button();
            this.button_dns_apply = new System.Windows.Forms.Button();
            this.button_all_apply = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1_TopOperate.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox_operate.SuspendLayout();
            this.groupBox_IpInfo.SuspendLayout();
            this.groupBox_IP.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1_TopOperate);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 58);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1_TopOperate
            // 
            this.groupBox1_TopOperate.Controls.Add(this.button_LoadNetwordCard);
            this.groupBox1_TopOperate.Location = new System.Drawing.Point(4, 4);
            this.groupBox1_TopOperate.Name = "groupBox1_TopOperate";
            this.groupBox1_TopOperate.Size = new System.Drawing.Size(769, 51);
            this.groupBox1_TopOperate.TabIndex = 1;
            this.groupBox1_TopOperate.TabStop = false;
            this.groupBox1_TopOperate.Text = "Tool";
            // 
            // button_LoadNetwordCard
            // 
            this.button_LoadNetwordCard.Location = new System.Drawing.Point(688, 17);
            this.button_LoadNetwordCard.Name = "button_LoadNetwordCard";
            this.button_LoadNetwordCard.Size = new System.Drawing.Size(75, 23);
            this.button_LoadNetwordCard.TabIndex = 0;
            this.button_LoadNetwordCard.Text = "加载网卡";
            this.button_LoadNetwordCard.UseVisualStyleBackColor = true;
            this.button_LoadNetwordCard.Click += new System.EventHandler(this.LoadNetworkCardInfoList_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox_operate);
            this.panel2.Controls.Add(this.groupBox_IpInfo);
            this.panel2.Controls.Add(this.listBox_NetworkCard);
            this.panel2.Location = new System.Drawing.Point(12, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 362);
            this.panel2.TabIndex = 1;
            // 
            // groupBox_operate
            // 
            this.groupBox_operate.Controls.Add(this.button_all_apply);
            this.groupBox_operate.Controls.Add(this.button_dns_apply);
            this.groupBox_operate.Controls.Add(this.button_ip_apply);
            this.groupBox_operate.Controls.Add(this.button_exit);
            this.groupBox_operate.Location = new System.Drawing.Point(222, 303);
            this.groupBox_operate.Name = "groupBox_operate";
            this.groupBox_operate.Size = new System.Drawing.Size(551, 52);
            this.groupBox_operate.TabIndex = 2;
            this.groupBox_operate.TabStop = false;
            this.groupBox_operate.Text = "操作区";
            // 
            // groupBox_IpInfo
            // 
            this.groupBox_IpInfo.Controls.Add(this.groupBox_IP);
            this.groupBox_IpInfo.Controls.Add(this.label_CardDesc_Value);
            this.groupBox_IpInfo.Controls.Add(this.label3);
            this.groupBox_IpInfo.Controls.Add(this.label_CardSpeed_Value);
            this.groupBox_IpInfo.Controls.Add(this.label1);
            this.groupBox_IpInfo.Controls.Add(this.label_MAC_Value);
            this.groupBox_IpInfo.Controls.Add(this.label_Id);
            this.groupBox_IpInfo.Location = new System.Drawing.Point(222, 3);
            this.groupBox_IpInfo.Name = "groupBox_IpInfo";
            this.groupBox_IpInfo.Size = new System.Drawing.Size(551, 293);
            this.groupBox_IpInfo.TabIndex = 1;
            this.groupBox_IpInfo.TabStop = false;
            this.groupBox_IpInfo.Text = "信息区";
            // 
            // groupBox_IP
            // 
            this.groupBox_IP.Controls.Add(this.textBox_ip_dns2);
            this.groupBox_IP.Controls.Add(this.textBox_ip_dns1);
            this.groupBox_IP.Controls.Add(this.textBox_ip_subnet);
            this.groupBox_IP.Controls.Add(this.textBox_ip_gateway);
            this.groupBox_IP.Controls.Add(this.textBox_ip_ip);
            this.groupBox_IP.Controls.Add(this.button_trans_dns2);
            this.groupBox_IP.Controls.Add(this.button_trans_dns1);
            this.groupBox_IP.Controls.Add(this.button_trans_subnet);
            this.groupBox_IP.Controls.Add(this.button_trans_gateway);
            this.groupBox_IP.Controls.Add(this.button_trans_ip);
            this.groupBox_IP.Controls.Add(this.label_ip_dns2_value);
            this.groupBox_IP.Controls.Add(this.label_ip_dns1_value);
            this.groupBox_IP.Controls.Add(this.label_ip_subnet_value);
            this.groupBox_IP.Controls.Add(this.label_ip_gateway_value);
            this.groupBox_IP.Controls.Add(this.label_ip_value);
            this.groupBox_IP.Controls.Add(this.label_ip_dns2);
            this.groupBox_IP.Controls.Add(this.label_ip_dns1);
            this.groupBox_IP.Controls.Add(this.label_gateway);
            this.groupBox_IP.Controls.Add(this.label_subnetmask);
            this.groupBox_IP.Controls.Add(this.label_ip);
            this.groupBox_IP.Location = new System.Drawing.Point(9, 81);
            this.groupBox_IP.Name = "groupBox_IP";
            this.groupBox_IP.Size = new System.Drawing.Size(536, 206);
            this.groupBox_IP.TabIndex = 8;
            this.groupBox_IP.TabStop = false;
            this.groupBox_IP.Text = "IP信息";
            // 
            // label_ip_dns2_value
            // 
            this.label_ip_dns2_value.AutoSize = true;
            this.label_ip_dns2_value.Location = new System.Drawing.Point(77, 160);
            this.label_ip_dns2_value.Name = "label_ip_dns2_value";
            this.label_ip_dns2_value.Size = new System.Drawing.Size(11, 12);
            this.label_ip_dns2_value.TabIndex = 9;
            this.label_ip_dns2_value.Text = " ";
            // 
            // label_ip_dns1_value
            // 
            this.label_ip_dns1_value.AutoSize = true;
            this.label_ip_dns1_value.Location = new System.Drawing.Point(77, 130);
            this.label_ip_dns1_value.Name = "label_ip_dns1_value";
            this.label_ip_dns1_value.Size = new System.Drawing.Size(11, 12);
            this.label_ip_dns1_value.TabIndex = 8;
            this.label_ip_dns1_value.Text = " ";
            // 
            // label_ip_subnet_value
            // 
            this.label_ip_subnet_value.AutoSize = true;
            this.label_ip_subnet_value.Location = new System.Drawing.Point(77, 100);
            this.label_ip_subnet_value.Name = "label_ip_subnet_value";
            this.label_ip_subnet_value.Size = new System.Drawing.Size(11, 12);
            this.label_ip_subnet_value.TabIndex = 7;
            this.label_ip_subnet_value.Text = " ";
            // 
            // label_ip_gateway_value
            // 
            this.label_ip_gateway_value.AutoSize = true;
            this.label_ip_gateway_value.Location = new System.Drawing.Point(77, 70);
            this.label_ip_gateway_value.Name = "label_ip_gateway_value";
            this.label_ip_gateway_value.Size = new System.Drawing.Size(11, 12);
            this.label_ip_gateway_value.TabIndex = 6;
            this.label_ip_gateway_value.Text = " ";
            // 
            // label_ip_value
            // 
            this.label_ip_value.AutoSize = true;
            this.label_ip_value.Location = new System.Drawing.Point(77, 40);
            this.label_ip_value.Name = "label_ip_value";
            this.label_ip_value.Size = new System.Drawing.Size(11, 12);
            this.label_ip_value.TabIndex = 5;
            this.label_ip_value.Text = " ";
            // 
            // label_ip_dns2
            // 
            this.label_ip_dns2.AutoSize = true;
            this.label_ip_dns2.Location = new System.Drawing.Point(29, 160);
            this.label_ip_dns2.Name = "label_ip_dns2";
            this.label_ip_dns2.Size = new System.Drawing.Size(41, 12);
            this.label_ip_dns2.TabIndex = 4;
            this.label_ip_dns2.Text = "DNS2：";
            // 
            // label_ip_dns1
            // 
            this.label_ip_dns1.AutoSize = true;
            this.label_ip_dns1.Location = new System.Drawing.Point(29, 130);
            this.label_ip_dns1.Name = "label_ip_dns1";
            this.label_ip_dns1.Size = new System.Drawing.Size(41, 12);
            this.label_ip_dns1.TabIndex = 3;
            this.label_ip_dns1.Text = "DNS1：";
            // 
            // label_gateway
            // 
            this.label_gateway.AutoSize = true;
            this.label_gateway.Location = new System.Drawing.Point(30, 70);
            this.label_gateway.Name = "label_gateway";
            this.label_gateway.Size = new System.Drawing.Size(41, 12);
            this.label_gateway.TabIndex = 2;
            this.label_gateway.Text = "网关：";
            // 
            // label_subnetmask
            // 
            this.label_subnetmask.AutoSize = true;
            this.label_subnetmask.Location = new System.Drawing.Point(6, 100);
            this.label_subnetmask.Name = "label_subnetmask";
            this.label_subnetmask.Size = new System.Drawing.Size(65, 12);
            this.label_subnetmask.TabIndex = 1;
            this.label_subnetmask.Text = "子网掩码：";
            // 
            // label_ip
            // 
            this.label_ip.AutoSize = true;
            this.label_ip.Location = new System.Drawing.Point(42, 40);
            this.label_ip.Name = "label_ip";
            this.label_ip.Size = new System.Drawing.Size(29, 12);
            this.label_ip.TabIndex = 0;
            this.label_ip.Text = "IP：";
            // 
            // label_CardDesc_Value
            // 
            this.label_CardDesc_Value.AutoSize = true;
            this.label_CardDesc_Value.Location = new System.Drawing.Point(66, 50);
            this.label_CardDesc_Value.Name = "label_CardDesc_Value";
            this.label_CardDesc_Value.Size = new System.Drawing.Size(11, 12);
            this.label_CardDesc_Value.TabIndex = 7;
            this.label_CardDesc_Value.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "网卡描述: ";
            // 
            // label_CardSpeed_Value
            // 
            this.label_CardSpeed_Value.AutoSize = true;
            this.label_CardSpeed_Value.Location = new System.Drawing.Point(419, 21);
            this.label_CardSpeed_Value.Name = "label_CardSpeed_Value";
            this.label_CardSpeed_Value.Size = new System.Drawing.Size(11, 12);
            this.label_CardSpeed_Value.TabIndex = 5;
            this.label_CardSpeed_Value.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "网络速率: ";
            // 
            // label_MAC_Value
            // 
            this.label_MAC_Value.AutoSize = true;
            this.label_MAC_Value.Location = new System.Drawing.Point(66, 21);
            this.label_MAC_Value.Name = "label_MAC_Value";
            this.label_MAC_Value.Size = new System.Drawing.Size(11, 12);
            this.label_MAC_Value.TabIndex = 1;
            this.label_MAC_Value.Text = " ";
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Location = new System.Drawing.Point(7, 21);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(65, 12);
            this.label_Id.TabIndex = 0;
            this.label_Id.Text = "网卡地址: ";
            // 
            // listBox_NetworkCard
            // 
            this.listBox_NetworkCard.FormattingEnabled = true;
            this.listBox_NetworkCard.HorizontalScrollbar = true;
            this.listBox_NetworkCard.ItemHeight = 12;
            this.listBox_NetworkCard.Location = new System.Drawing.Point(3, 3);
            this.listBox_NetworkCard.Name = "listBox_NetworkCard";
            this.listBox_NetworkCard.Size = new System.Drawing.Size(213, 352);
            this.listBox_NetworkCard.TabIndex = 0;
            this.listBox_NetworkCard.SelectedValueChanged += new System.EventHandler(this.NetworkCard_SelectedValueChanged);
            // 
            // button_trans_ip
            // 
            this.button_trans_ip.Location = new System.Drawing.Point(236, 35);
            this.button_trans_ip.Name = "button_trans_ip";
            this.button_trans_ip.Size = new System.Drawing.Size(30, 21);
            this.button_trans_ip.TabIndex = 10;
            this.button_trans_ip.Text = ">";
            this.button_trans_ip.UseVisualStyleBackColor = true;
            this.button_trans_ip.Click += new System.EventHandler(this.button_trans_ip_Click);
            // 
            // button_trans_gateway
            // 
            this.button_trans_gateway.Location = new System.Drawing.Point(236, 65);
            this.button_trans_gateway.Name = "button_trans_gateway";
            this.button_trans_gateway.Size = new System.Drawing.Size(30, 21);
            this.button_trans_gateway.TabIndex = 11;
            this.button_trans_gateway.Text = ">";
            this.button_trans_gateway.UseVisualStyleBackColor = true;
            this.button_trans_gateway.Click += new System.EventHandler(this.button_trans_gateway_Click);
            // 
            // button_trans_subnet
            // 
            this.button_trans_subnet.Location = new System.Drawing.Point(236, 95);
            this.button_trans_subnet.Name = "button_trans_subnet";
            this.button_trans_subnet.Size = new System.Drawing.Size(30, 21);
            this.button_trans_subnet.TabIndex = 12;
            this.button_trans_subnet.Text = ">";
            this.button_trans_subnet.UseVisualStyleBackColor = true;
            this.button_trans_subnet.Click += new System.EventHandler(this.button_trans_subnet_Click);
            // 
            // button_trans_dns1
            // 
            this.button_trans_dns1.Location = new System.Drawing.Point(236, 125);
            this.button_trans_dns1.Name = "button_trans_dns1";
            this.button_trans_dns1.Size = new System.Drawing.Size(30, 21);
            this.button_trans_dns1.TabIndex = 13;
            this.button_trans_dns1.Text = ">";
            this.button_trans_dns1.UseVisualStyleBackColor = true;
            this.button_trans_dns1.Click += new System.EventHandler(this.button_trans_dns1_Click);
            // 
            // button_trans_dns2
            // 
            this.button_trans_dns2.Location = new System.Drawing.Point(236, 155);
            this.button_trans_dns2.Name = "button_trans_dns2";
            this.button_trans_dns2.Size = new System.Drawing.Size(30, 21);
            this.button_trans_dns2.TabIndex = 14;
            this.button_trans_dns2.Text = ">";
            this.button_trans_dns2.UseVisualStyleBackColor = true;
            this.button_trans_dns2.Click += new System.EventHandler(this.button_trans_dns2_Click);
            // 
            // textBox_ip_ip
            // 
            this.textBox_ip_ip.Location = new System.Drawing.Point(280, 35);
            this.textBox_ip_ip.Name = "textBox_ip_ip";
            this.textBox_ip_ip.Size = new System.Drawing.Size(247, 21);
            this.textBox_ip_ip.TabIndex = 15;
            // 
            // textBox_ip_gateway
            // 
            this.textBox_ip_gateway.Location = new System.Drawing.Point(280, 65);
            this.textBox_ip_gateway.Name = "textBox_ip_gateway";
            this.textBox_ip_gateway.Size = new System.Drawing.Size(247, 21);
            this.textBox_ip_gateway.TabIndex = 16;
            // 
            // textBox_ip_subnet
            // 
            this.textBox_ip_subnet.Location = new System.Drawing.Point(280, 95);
            this.textBox_ip_subnet.Name = "textBox_ip_subnet";
            this.textBox_ip_subnet.Size = new System.Drawing.Size(247, 21);
            this.textBox_ip_subnet.TabIndex = 17;
            // 
            // textBox_ip_dns1
            // 
            this.textBox_ip_dns1.Location = new System.Drawing.Point(280, 125);
            this.textBox_ip_dns1.Name = "textBox_ip_dns1";
            this.textBox_ip_dns1.Size = new System.Drawing.Size(247, 21);
            this.textBox_ip_dns1.TabIndex = 18;
            // 
            // textBox_ip_dns2
            // 
            this.textBox_ip_dns2.Location = new System.Drawing.Point(280, 155);
            this.textBox_ip_dns2.Name = "textBox_ip_dns2";
            this.textBox_ip_dns2.Size = new System.Drawing.Size(247, 21);
            this.textBox_ip_dns2.TabIndex = 19;
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(461, 20);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 0;
            this.button_exit.Text = "退出";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_ip_apply
            // 
            this.button_ip_apply.Location = new System.Drawing.Point(89, 20);
            this.button_ip_apply.Name = "button_ip_apply";
            this.button_ip_apply.Size = new System.Drawing.Size(75, 23);
            this.button_ip_apply.TabIndex = 1;
            this.button_ip_apply.Text = "设置IP";
            this.button_ip_apply.UseVisualStyleBackColor = true;
            this.button_ip_apply.Click += new System.EventHandler(this.button_ip_apply_Click);
            // 
            // button_dns_apply
            // 
            this.button_dns_apply.Location = new System.Drawing.Point(169, 20);
            this.button_dns_apply.Name = "button_dns_apply";
            this.button_dns_apply.Size = new System.Drawing.Size(75, 23);
            this.button_dns_apply.TabIndex = 2;
            this.button_dns_apply.Text = "设置DNS";
            this.button_dns_apply.UseVisualStyleBackColor = true;
            this.button_dns_apply.Click += new System.EventHandler(this.button_dns_apply_Click);
            // 
            // button_all_apply
            // 
            this.button_all_apply.Location = new System.Drawing.Point(9, 19);
            this.button_all_apply.Name = "button_all_apply";
            this.button_all_apply.Size = new System.Drawing.Size(75, 23);
            this.button_all_apply.TabIndex = 3;
            this.button_all_apply.Text = "一键应用";
            this.button_all_apply.UseVisualStyleBackColor = true;
            this.button_all_apply.Click += new System.EventHandler(this.button_all_apply_Click);
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Application";
            this.Text = "Network Card  Tools v1.0 @niushuai233";
            this.panel1.ResumeLayout(false);
            this.groupBox1_TopOperate.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox_operate.ResumeLayout(false);
            this.groupBox_IpInfo.ResumeLayout(false);
            this.groupBox_IpInfo.PerformLayout();
            this.groupBox_IP.ResumeLayout(false);
            this.groupBox_IP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox_operate;
        private System.Windows.Forms.GroupBox groupBox_IpInfo;
        private System.Windows.Forms.ListBox listBox_NetworkCard;
        private System.Windows.Forms.GroupBox groupBox1_TopOperate;
        private System.Windows.Forms.Button button_LoadNetwordCard;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Label label_MAC_Value;
        private System.Windows.Forms.Label label_CardDesc_Value;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_CardSpeed_Value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_IP;
        private System.Windows.Forms.Label label_ip;
        private System.Windows.Forms.Label label_subnetmask;
        private System.Windows.Forms.Label label_gateway;
        private System.Windows.Forms.Label label_ip_dns2;
        private System.Windows.Forms.Label label_ip_dns1;
        private System.Windows.Forms.Label label_ip_dns2_value;
        private System.Windows.Forms.Label label_ip_dns1_value;
        private System.Windows.Forms.Label label_ip_subnet_value;
        private System.Windows.Forms.Label label_ip_gateway_value;
        private System.Windows.Forms.Label label_ip_value;
        private System.Windows.Forms.Button button_trans_dns2;
        private System.Windows.Forms.Button button_trans_dns1;
        private System.Windows.Forms.Button button_trans_subnet;
        private System.Windows.Forms.Button button_trans_gateway;
        private System.Windows.Forms.Button button_trans_ip;
        private System.Windows.Forms.TextBox textBox_ip_dns2;
        private System.Windows.Forms.TextBox textBox_ip_dns1;
        private System.Windows.Forms.TextBox textBox_ip_subnet;
        private System.Windows.Forms.TextBox textBox_ip_gateway;
        private System.Windows.Forms.TextBox textBox_ip_ip;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_ip_apply;
        private System.Windows.Forms.Button button_dns_apply;
        private System.Windows.Forms.Button button_all_apply;
    }
}

