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
    public partial class Manger : Form
    {
        public Manger()
        {
            InitializeComponent();
        }

        private void money_manager_btn_Click(object sender, EventArgs e)
        {
            Manager_money m = new Manager_money();
            m.Show();
        }

        private void type_manager_btn_Click(object sender, EventArgs e)
        {
            Manager_type t = new Manager_type();
            t.Show();
        }
    }
}
