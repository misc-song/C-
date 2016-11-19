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
    public partial class Manager_type : Form
    {
        public Manager_type()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //执行查询操作
            if (this.textBox1.Text == "")
            {
                this.dataGridView1.DataSource = Business.detalSearchALL();
            }
            else
            {
                this.dataGridView1.DataSource = Business.detalSearchBYName(this.textBox1.Text);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            AddDetial add = new AddDetial();
            add.Show();
        }
    }
}
