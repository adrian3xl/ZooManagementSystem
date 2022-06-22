using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalEncyclopedia
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void create_bt_Click(object sender, EventArgs e)
        {
            
            string fname = fname_tb.Text;
            string lname = lname_tb.Text;
            string empID = emp_tb.Text;
            string cont = cont_tb.Text;
            string pos = Pos_tb.Text;

            
            
            
            MessageBox.Show("Add successfully");
        }
    }
}
