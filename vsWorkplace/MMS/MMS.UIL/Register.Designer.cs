namespace MMS.UIL
{
    partial class Register
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
            this.Register_ID = new System.Windows.Forms.Label();
            this.Register_passwd = new System.Windows.Forms.Label();
            this.Register_confirm_passwd = new System.Windows.Forms.Label();
            this.Register_textBox_ID = new System.Windows.Forms.TextBox();
            this.Register_textBox_Passwd = new System.Windows.Forms.TextBox();
            this.Register_textBox_confirm_passwd = new System.Windows.Forms.TextBox();
            this.Register_btn_ok = new System.Windows.Forms.Button();
            this.Register_btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Register_ID
            // 
            this.Register_ID.AutoSize = true;
            this.Register_ID.Location = new System.Drawing.Point(99, 48);
            this.Register_ID.Name = "Register_ID";
            this.Register_ID.Size = new System.Drawing.Size(35, 12);
            this.Register_ID.TabIndex = 0;
            this.Register_ID.Text = "账号:";
            // 
            // Register_passwd
            // 
            this.Register_passwd.AutoSize = true;
            this.Register_passwd.Location = new System.Drawing.Point(99, 86);
            this.Register_passwd.Name = "Register_passwd";
            this.Register_passwd.Size = new System.Drawing.Size(35, 12);
            this.Register_passwd.TabIndex = 1;
            this.Register_passwd.Text = "密码:";
            // 
            // Register_confirm_passwd
            // 
            this.Register_confirm_passwd.AutoSize = true;
            this.Register_confirm_passwd.Location = new System.Drawing.Point(99, 124);
            this.Register_confirm_passwd.Name = "Register_confirm_passwd";
            this.Register_confirm_passwd.Size = new System.Drawing.Size(59, 12);
            this.Register_confirm_passwd.TabIndex = 2;
            this.Register_confirm_passwd.Text = "确认密码:";
            // 
            // Register_textBox_ID
            // 
            this.Register_textBox_ID.Location = new System.Drawing.Point(176, 48);
            this.Register_textBox_ID.Name = "Register_textBox_ID";
            this.Register_textBox_ID.Size = new System.Drawing.Size(252, 21);
            this.Register_textBox_ID.TabIndex = 3;
            // 
            // Register_textBox_Passwd
            // 
            this.Register_textBox_Passwd.Location = new System.Drawing.Point(176, 83);
            this.Register_textBox_Passwd.Name = "Register_textBox_Passwd";
            this.Register_textBox_Passwd.Size = new System.Drawing.Size(252, 21);
            this.Register_textBox_Passwd.TabIndex = 4;
            // 
            // Register_textBox_confirm_passwd
            // 
            this.Register_textBox_confirm_passwd.Location = new System.Drawing.Point(176, 115);
            this.Register_textBox_confirm_passwd.Name = "Register_textBox_confirm_passwd";
            this.Register_textBox_confirm_passwd.Size = new System.Drawing.Size(252, 21);
            this.Register_textBox_confirm_passwd.TabIndex = 5;
            // 
            // Register_btn_ok
            // 
            this.Register_btn_ok.Location = new System.Drawing.Point(92, 211);
            this.Register_btn_ok.Name = "Register_btn_ok";
            this.Register_btn_ok.Size = new System.Drawing.Size(75, 23);
            this.Register_btn_ok.TabIndex = 6;
            this.Register_btn_ok.Text = "确定";
            this.Register_btn_ok.UseVisualStyleBackColor = true;
            this.Register_btn_ok.Click += new System.EventHandler(this.Register_btn_ok_Click);
            // 
            // Register_btn_cancel
            // 
            this.Register_btn_cancel.Location = new System.Drawing.Point(343, 210);
            this.Register_btn_cancel.Name = "Register_btn_cancel";
            this.Register_btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.Register_btn_cancel.TabIndex = 7;
            this.Register_btn_cancel.Text = "取消";
            this.Register_btn_cancel.UseVisualStyleBackColor = true;
            this.Register_btn_cancel.Click += new System.EventHandler(this.Register_btn_cancel_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 330);
            this.Controls.Add(this.Register_btn_cancel);
            this.Controls.Add(this.Register_btn_ok);
            this.Controls.Add(this.Register_textBox_confirm_passwd);
            this.Controls.Add(this.Register_textBox_Passwd);
            this.Controls.Add(this.Register_textBox_ID);
            this.Controls.Add(this.Register_confirm_passwd);
            this.Controls.Add(this.Register_passwd);
            this.Controls.Add(this.Register_ID);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Register_ID;
        private System.Windows.Forms.Label Register_passwd;
        private System.Windows.Forms.Label Register_confirm_passwd;
        private System.Windows.Forms.TextBox Register_textBox_ID;
        private System.Windows.Forms.TextBox Register_textBox_Passwd;
        private System.Windows.Forms.TextBox Register_textBox_confirm_passwd;
        private System.Windows.Forms.Button Register_btn_ok;
        private System.Windows.Forms.Button Register_btn_cancel;
    }
}