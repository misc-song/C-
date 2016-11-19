using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using note.MODEL;
using note.BIL;
namespace note.UIL
{
    public partial class frmModifyPwd : Form
    {
        public frmModifyPwd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //获取原密码 
            int i = User.UserID;
            string p = Business.getPasswd(i);
            if (this.oldpwd == null||this.newpwd==null||this.newpwd_confirm==null)
            {
                MessageBox.Show("能为空吗?");
 
            }
            if (this.oldpwd.Text != p)
            {
                MessageBox.Show("原密码错误!");
            }else
            //判断新密码
            if (this.newpwd.Text == this.newpwd_confirm.Text)
            {
                //
                if (Business.UpdatePwd(this.newpwd_confirm.Text)==true)
                {
                    MessageBox.Show("修改成功");
 
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
