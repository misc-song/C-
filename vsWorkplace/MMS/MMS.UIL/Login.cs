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
using MMS.Model;
namespace MMS.UIL
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string account =this.textbox_account.Text;
            string pwd = this.textbox_pwd.Text;
            if (account != "" && pwd != "")
            {
                if (Business.checkLogin(account, pwd) == true)
                {
                    User.userAccount = this.textbox_account.Text;
                    User.userID = int.Parse(Business.getID(this.textbox_account.Text));
                    //Type_Manger t = new Type_Manger();
                    this.DialogResult = DialogResult.OK;
                    //t.Show();
                }
                
            }
            else
                MessageBox.Show("账号或者密码错误!");
           
            
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
        }
    }
}
