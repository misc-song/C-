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
    public partial class frmALL : Form
    {
        public frmALL()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmALL_Load(object sender, EventArgs e)
        {
                      
           this.dataGridView1.DataSource = Business.noteOfALL();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            string name = this.textBox1.Text;
            this.dataGridView1.DataSource = Business.GetMessByName(name);
        }
    }
}
