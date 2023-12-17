namespace client
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.IF_logs = new System.Windows.Forms.RichTextBox();
            this.IF_messageBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IF_send = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SPS_logs = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IF_sub = new System.Windows.Forms.Button();
            this.SPS_sub = new System.Windows.Forms.Button();
            this.logs = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SPS_messageBox = new System.Windows.Forms.TextBox();
            this.SPS_send = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(29, 10);
            this.textBox_ip.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(88, 20);
            this.textBox_ip.TabIndex = 2;
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(156, 10);
            this.textBox_port.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(88, 20);
            this.textBox_port.TabIndex = 3;
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(413, 8);
            this.button_connect.Margin = new System.Windows.Forms.Padding(2);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(61, 22);
            this.button_connect.TabIndex = 4;
            this.button_connect.Text = "connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // IF_logs
            // 
            this.IF_logs.Location = new System.Drawing.Point(9, 73);
            this.IF_logs.Margin = new System.Windows.Forms.Padding(2);
            this.IF_logs.Name = "IF_logs";
            this.IF_logs.Size = new System.Drawing.Size(245, 119);
            this.IF_logs.TabIndex = 5;
            this.IF_logs.Text = "";
            // 
            // IF_messageBox
            // 
            this.IF_messageBox.Enabled = false;
            this.IF_messageBox.Location = new System.Drawing.Point(64, 202);
            this.IF_messageBox.Margin = new System.Windows.Forms.Padding(2);
            this.IF_messageBox.Name = "IF_messageBox";
            this.IF_messageBox.Size = new System.Drawing.Size(98, 20);
            this.IF_messageBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Message:";
            // 
            // IF_send
            // 
            this.IF_send.Enabled = false;
            this.IF_send.Location = new System.Drawing.Point(170, 200);
            this.IF_send.Margin = new System.Windows.Forms.Padding(2);
            this.IF_send.Name = "IF_send";
            this.IF_send.Size = new System.Drawing.Size(41, 21);
            this.IF_send.TabIndex = 8;
            this.IF_send.Text = "send";
            this.IF_send.UseVisualStyleBackColor = true;
            this.IF_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "IF100:";
            // 
            // SPS_logs
            // 
            this.SPS_logs.Location = new System.Drawing.Point(10, 261);
            this.SPS_logs.Margin = new System.Windows.Forms.Padding(2);
            this.SPS_logs.Name = "SPS_logs";
            this.SPS_logs.Size = new System.Drawing.Size(244, 119);
            this.SPS_logs.TabIndex = 10;
            this.SPS_logs.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 241);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "SPS101:";
            // 
            // IF_sub
            // 
            this.IF_sub.Enabled = false;
            this.IF_sub.Location = new System.Drawing.Point(261, 111);
            this.IF_sub.Margin = new System.Windows.Forms.Padding(2);
            this.IF_sub.Name = "IF_sub";
            this.IF_sub.Size = new System.Drawing.Size(62, 41);
            this.IF_sub.TabIndex = 12;
            this.IF_sub.Text = "subscribe";
            this.IF_sub.UseVisualStyleBackColor = true;
            this.IF_sub.Click += new System.EventHandler(this.IF_sub_Click);
            // 
            // SPS_sub
            // 
            this.SPS_sub.Enabled = false;
            this.SPS_sub.Location = new System.Drawing.Point(263, 300);
            this.SPS_sub.Margin = new System.Windows.Forms.Padding(2);
            this.SPS_sub.Name = "SPS_sub";
            this.SPS_sub.Size = new System.Drawing.Size(60, 40);
            this.SPS_sub.TabIndex = 13;
            this.SPS_sub.Text = "subscribe";
            this.SPS_sub.UseVisualStyleBackColor = true;
            this.SPS_sub.Click += new System.EventHandler(this.SPS_sub_Click);
            // 
            // logs
            // 
            this.logs.Location = new System.Drawing.Point(371, 73);
            this.logs.Margin = new System.Windows.Forms.Padding(2);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(152, 331);
            this.logs.TabIndex = 14;
            this.logs.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Logs:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 388);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Message:";
            // 
            // SPS_messageBox
            // 
            this.SPS_messageBox.Enabled = false;
            this.SPS_messageBox.Location = new System.Drawing.Point(64, 388);
            this.SPS_messageBox.Margin = new System.Windows.Forms.Padding(2);
            this.SPS_messageBox.Name = "SPS_messageBox";
            this.SPS_messageBox.Size = new System.Drawing.Size(98, 20);
            this.SPS_messageBox.TabIndex = 17;
            // 
            // SPS_send
            // 
            this.SPS_send.Enabled = false;
            this.SPS_send.Location = new System.Drawing.Point(170, 386);
            this.SPS_send.Margin = new System.Windows.Forms.Padding(2);
            this.SPS_send.Name = "SPS_send";
            this.SPS_send.Size = new System.Drawing.Size(41, 21);
            this.SPS_send.TabIndex = 18;
            this.SPS_send.Text = "send";
            this.SPS_send.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Username:";
            // 
            // textBox_user
            // 
            this.textBox_user.Location = new System.Drawing.Point(314, 10);
            this.textBox_user.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(88, 20);
            this.textBox_user.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 446);
            this.Controls.Add(this.textBox_user);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SPS_send);
            this.Controls.Add(this.SPS_messageBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.SPS_sub);
            this.Controls.Add(this.IF_sub);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SPS_logs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IF_send);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IF_messageBox);
            this.Controls.Add(this.IF_logs);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.RichTextBox IF_logs;
        private System.Windows.Forms.TextBox IF_messageBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button IF_send;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox SPS_logs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button IF_sub;
        private System.Windows.Forms.Button SPS_sub;
        private System.Windows.Forms.RichTextBox logs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SPS_messageBox;
        private System.Windows.Forms.Button SPS_send;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_user;
    }
}

