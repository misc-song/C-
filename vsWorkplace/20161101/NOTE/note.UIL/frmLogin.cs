using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using note.BIL;
using note.MODEL;
namespace note.UIL
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //登录操作
            string account = this.textAccount.Text;
            string pwd = this.textPwd.Text;
            User u = new User();
            if (account != null && pwd != null)
            {
                bool bo=Business.checkLogin(account, pwd);//把这段代码拿出来看
                //看好了 开始
                if (bo == true)//不对 有点问题应该true? 应该是true
                {
                    u.account = this.textAccount.Text;
                    User.UserID = int.Parse(Business.getID(this.textAccount.Text));
                    //Type_Manger t = new Type_Manger();
                    this.DialogResult = DialogResult.OK;
                    //t.Show();
                }
                else
                    MessageBox.Show("账号或者密码错误!");
            }
            else
                MessageBox.Show("账号或者密码错误!");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //注册跳转操作
            frmRegister log = new frmRegister();
            log.Show();
        }
    }
}
