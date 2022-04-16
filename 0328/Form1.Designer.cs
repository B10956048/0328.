namespace _0328
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_send = new System.Windows.Forms.TextBox();
            this.textBox_target_port = new System.Windows.Forms.TextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.button_start_listen = new System.Windows.Forms.Button();
            this.textBox_target_IP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_recive_msg = new System.Windows.Forms.TextBox();
            this.textBox_listen_port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_send
            // 
            this.textBox_send.Location = new System.Drawing.Point(192, 353);
            this.textBox_send.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_send.Name = "textBox_send";
            this.textBox_send.Size = new System.Drawing.Size(411, 25);
            this.textBox_send.TabIndex = 25;
            // 
            // textBox_target_port
            // 
            this.textBox_target_port.Location = new System.Drawing.Point(192, 300);
            this.textBox_target_port.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_target_port.Name = "textBox_target_port";
            this.textBox_target_port.Size = new System.Drawing.Size(132, 25);
            this.textBox_target_port.TabIndex = 24;
            // 
            // button_send
            // 
            this.button_send.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_send.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_send.Location = new System.Drawing.Point(753, 347);
            this.button_send.Margin = new System.Windows.Forms.Padding(4);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(137, 30);
            this.button_send.TabIndex = 23;
            this.button_send.Text = "傳送";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // button_start_listen
            // 
            this.button_start_listen.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_start_listen.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_start_listen.Location = new System.Drawing.Point(753, 120);
            this.button_start_listen.Margin = new System.Windows.Forms.Padding(4);
            this.button_start_listen.Name = "button_start_listen";
            this.button_start_listen.Size = new System.Drawing.Size(137, 30);
            this.button_start_listen.TabIndex = 22;
            this.button_start_listen.Text = "啟動接收";
            this.button_start_listen.UseVisualStyleBackColor = true;
            this.button_start_listen.Click += new System.EventHandler(this.button_start_listen_Click);
            // 
            // textBox_target_IP
            // 
            this.textBox_target_IP.Location = new System.Drawing.Point(192, 251);
            this.textBox_target_IP.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_target_IP.Name = "textBox_target_IP";
            this.textBox_target_IP.Size = new System.Drawing.Size(167, 25);
            this.textBox_target_IP.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(29, 356);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "傳送文字";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(29, 304);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "目標 Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(55, 255);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "目標IP";
            // 
            // textBox_recive_msg
            // 
            this.textBox_recive_msg.Location = new System.Drawing.Point(192, 123);
            this.textBox_recive_msg.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_recive_msg.Name = "textBox_recive_msg";
            this.textBox_recive_msg.ReadOnly = true;
            this.textBox_recive_msg.Size = new System.Drawing.Size(411, 25);
            this.textBox_recive_msg.TabIndex = 17;
            // 
            // textBox_listen_port
            // 
            this.textBox_listen_port.Location = new System.Drawing.Point(192, 71);
            this.textBox_listen_port.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_listen_port.Name = "textBox_listen_port";
            this.textBox_listen_port.Size = new System.Drawing.Size(132, 25);
            this.textBox_listen_port.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(29, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "接聽文字";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(33, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "接聽 Port";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 516);
            this.Controls.Add(this.textBox_send);
            this.Controls.Add(this.textBox_target_port);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.button_start_listen);
            this.Controls.Add(this.textBox_target_IP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_recive_msg);
            this.Controls.Add(this.textBox_listen_port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_send;
        private System.Windows.Forms.TextBox textBox_target_port;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Button button_start_listen;
        private System.Windows.Forms.TextBox textBox_target_IP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_recive_msg;
        private System.Windows.Forms.TextBox textBox_listen_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

