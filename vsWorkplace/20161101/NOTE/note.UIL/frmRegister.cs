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
namespace note.UIL
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //提交数据
            string accou = this.text_account.Text;
            string pwd = this.text_pwd.Text;
            string repwd = this.text_confirm_pwd.Text;
            string name = this.text_name.Text;
            if (accou == null)
            {
                MessageBox.Show("账号不能为空!");
            }
            if (pwd == null)
            {
                MessageBox.Show("密码不能为空!");
            }
            if (name == null)
            {
                MessageBox.Show("用户名不能为空!");
            }
            if (pwd == repwd)
            {
                //向数据库执行插入操作
                if (Business.register(accou, repwd, name) == true)
                {
                    MessageBox.Show("注册成功!");
                }
            }
            else
            {
                MessageBox.Show("两次输入的密码不一致");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //关闭窗口
            this.Close();
        }
    }
}
