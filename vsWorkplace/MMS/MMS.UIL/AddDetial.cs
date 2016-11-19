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
    public partial class AddDetial : Form
    {
        public AddDetial()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == ""&&this.textBox2.Text==""&&this.textBox3.Text=="")
            {
                MessageBox.Show("所有的项目都不能为空!");
            }
            else
            {
                string content = this.textBox1.Text;
                string date = this.textBox2.Text;
                int money = int.Parse(this.textBox3.Text);
               // Business.
            }


        }
    }
}
