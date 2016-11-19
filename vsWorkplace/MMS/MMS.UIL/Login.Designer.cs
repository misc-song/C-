namespace MMS.UIL
{
    partial class Login
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
            this.login_btn = new System.Windows.Forms.Button();
            this.register_btn = new System.Windows.Forms.Button();
            this.lab_id = new System.Windows.Forms.Label();
            this.lab_passwd = new System.Windows.Forms.Label();
            this.textbox_account = new System.Windows.Forms.TextBox();
            this.textbox_pwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(105, 198);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 23);
            this.login_btn.TabIndex = 0;
            this.login_btn.Text = "登录";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // register_btn
            // 
            this.register_btn.Location = new System.Drawing.Point(299, 198);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(75, 23);
            this.register_btn.TabIndex = 1;
            this.register_btn.Text = "注册";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // lab_id
            // 
            this.lab_id.AutoSize = true;
            this.lab_id.Location = new System.Drawing.Point(67, 46);
            this.lab_id.Name = "lab_id";
            this.lab_id.Size = new System.Drawing.Size(35, 12);
            this.lab_id.TabIndex = 2;
            this.lab_id.Text = "账号:";
            // 
            // lab_passwd
            // 
            this.lab_passwd.AutoSize = true;
            this.lab_passwd.Location = new System.Drawing.Point(69, 102);
            this.lab_passwd.Name = "lab_passwd";
            this.lab_passwd.Size = new System.Drawing.Size(35, 12);
            this.lab_passwd.TabIndex = 3;
            this.lab_passwd.Text = "密码:";
            // 
            // textbox_account
            // 
            this.textbox_account.Location = new System.Drawing.Point(140, 43);
            this.textbox_account.Name = "textbox_account";
            this.textbox_account.Size = new System.Drawing.Size(221, 21);
            this.textbox_account.TabIndex = 4;
            // 
            // textbox_pwd
            // 
            this.textbox_pwd.Location = new System.Drawing.Point(140, 92);
            this.textbox_pwd.Name = "textbox_pwd";
            this.textbox_pwd.Size = new System.Drawing.Size(221, 21);
            this.textbox_pwd.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 314);
            this.Controls.Add(this.textbox_pwd);
            this.Controls.Add(this.textbox_account);
            this.Controls.Add(this.lab_passwd);
            this.Controls.Add(this.lab_id);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.login_btn);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Label lab_id;
        private System.Windows.Forms.Label lab_passwd;
        private System.Windows.Forms.TextBox textbox_account;
        private System.Windows.Forms.TextBox textbox_pwd;
    }
}