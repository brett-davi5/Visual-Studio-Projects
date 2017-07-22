using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Body_Mass_Index_Program_Enhancement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int weight = int.Parse(weightTextBox.Text);
            int height = int.Parse(heightTextBox.Text);
            double bmi = (weight * 703) / (height * height);

            bmiOutputLabel.Text = bmi.ToString();


            if (bmi >= 18.5 && bmi <= 25)
                MessageBox.Show("Your BMI is optimal! :)");
            else if (bmi <= 18.5)
                MessageBox.Show("Your BMI is low! Eat a damn sammich!");
            else
                MessageBox.Show("Your BMI is overweight. Put down the sammich.");


        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
