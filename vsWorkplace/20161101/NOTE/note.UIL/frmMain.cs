using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace note.UIL
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //显示开发人员信息
            MessageBox.Show(".Net 1407 宋和俊");
        }

        private void 密码修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //跳转到修改密码的页面
            frmModifyPwd mdfp = new frmModifyPwd();
            mdfp.Show();
        }

        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            //退出登录
        }

        private void 我的印象ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //跳转到frmme
            frmME fm = new frmME();
            fm.Show();
        }

        private void 印象大厅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //跳转到frmall
            frmALL fma = new frmALL();
            fma.Show();
        }
    }
}
