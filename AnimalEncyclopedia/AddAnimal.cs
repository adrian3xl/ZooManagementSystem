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
    public partial class AddAnimal : Form
    {
        public AddAnimal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = name_tb.Text;
            string color = color_cb.SelectedItem.ToString();
            string weight = weight_tb.Text;
            DateTime dob = dateTimePicker1.Value;
            string species = species_cb.SelectedItem.ToString();
            string emp = emp_cb.ToString();


            bool isValid = true;


            if (string.IsNullOrEmpty(name)|| string.IsNullOrEmpty(species)){

                isValid = false;
                MessageBox.Show("Missing information detected");


            }
            if (isValid) {

                MessageBox.Show("Animal has been added successfully to record");


            }

        }
    }
}
