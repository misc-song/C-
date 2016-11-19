using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MMS.BLL;
namespace MMS.UIL
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Register_btn_ok_Click(object sender, EventArgs e)
        {
            string raccount = this.Register_textBox_ID.Text;
            string rPwd = this.Register_textBox_Passwd.Text;
            string rcPwd = this.Register_textBox_confirm_passwd.Text;


            if (rcPwd == rPwd)
            {
                //执行插入方法
                if (Business.register(raccount, rPwd) == true)
                {
                    MessageBox.Show("注册成功");
                    this.Close();
                }
            }
            else
                MessageBox.Show("两次密码不一致");
        }
    }
}
