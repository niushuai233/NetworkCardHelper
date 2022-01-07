
namespace NetworkCardHelper.Forms
{
    partial class ConfigForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_configName = new System.Windows.Forms.TextBox();
            this.button_config_save = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "配置名称：";
            // 
            // textBox_configName
            // 
            this.textBox_configName.Location = new System.Drawing.Point(82, 21);
            this.textBox_configName.Name = "textBox_configName";
            this.textBox_configName.Size = new System.Drawing.Size(197, 21);
            this.textBox_configName.TabIndex = 1;
            // 
            // button_config_save
            // 
            this.button_config_save.Location = new System.Drawing.Point(204, 65);
            this.button_config_save.Name = "button_config_save";
            this.button_config_save.Size = new System.Drawing.Size(75, 23);
            this.button_config_save.TabIndex = 2;
            this.button_config_save.Text = "保存";
            this.button_config_save.UseVisualStyleBackColor = true;
            this.button_config_save.Click += new System.EventHandler(this.button_config_save_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(123, 65);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 3;
            this.button_close.Text = "取消";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 103);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_config_save);
            this.Controls.Add(this.textBox_configName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConfigForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_configName;
        private System.Windows.Forms.Button button_config_save;
        private System.Windows.Forms.Button button_close;
    }
}