using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchCalculatorGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public String Selection;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selection = comboBox1.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Num = Convert.ToInt32(comboBox2.Text);

            Products instance = new Products();
            if (Selection == "Rosemary")
            {
                MessageBox.Show(instance.Rosemary(Num));
            }
            else if (Selection == "Cheddar Italian")
            {
                MessageBox.Show(instance.CheddarItalian(Num));
            }
            else if (Selection == "Tomato Basil")
            {
                MessageBox.Show(instance.TomatoBasil(Num));
            }
            else if (Selection == "Cranberry Walnut")
            {
                MessageBox.Show(instance.CranberryWalnut(Num));
            }
            else if (Selection == "Mountain Herb")
            {
                MessageBox.Show(instance.MountainHerb(Num));
            }
            else if (Selection == "Molasses")
            {
                MessageBox.Show(instance.Molasses(Num));
            }
        }
    }
}
