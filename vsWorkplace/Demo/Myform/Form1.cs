using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Myform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //命令文本
            string cmdText = "select Sno,Sname,Ssex,Sage,Sdept from Student";
            string str = this.textBox1.Text;
            if (!string.IsNullOrEmpty(str))
            {
                cmdText += " where Sname like'%" + str + "%'";
            }
            //查询数据库数据
            string conn = "server=.;database=studentandcourse;pwd =111111;uid=sa;";
            DataTable dt = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(cmdText, conn);
            dap.Fill(dt);
            //显示数据
            this.dataGridView1.DataSource = dt;
        }
    }
}
