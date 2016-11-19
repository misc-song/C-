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
    public partial class frmME : Form
    {
        public frmME()
        {
            InitializeComponent();
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            //向表中插入一条数据
            System.DateTime currentTime=new System.DateTime(); 
            currentTime=System.DateTime.Now;
            int userid = User.UserID;
            if (Business.AddContent(this.textBox1.Text, currentTime,userid) == true)
            {
                MessageBox.Show("添加笔记成功");
            }
            else 
            {
                MessageBox.Show("添加失败!");
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            //删除一天记录
        
            int id = int.Parse(this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            Business.DeleteMess(id);
            this.dataGridView1.DataSource = Business.noteOfMe(User.UserID);
        }

        private void frmME_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Business.noteOfMe(User.UserID);
        }
    }
}
