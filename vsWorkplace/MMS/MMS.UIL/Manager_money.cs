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
    public partial class Manager_money : Form
    {
        public Manager_money()
        {
            InitializeComponent();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            //执行查询操作
            if (this.textBox1.Text == "")
            {
                this.dataGridView1.DataSource = Business.categorySearchALL();
            }
            else
            {
                this.dataGridView1.DataSource = Business.categorySearchBYName(this.textBox1.Text);
            }
        }
    }
}
