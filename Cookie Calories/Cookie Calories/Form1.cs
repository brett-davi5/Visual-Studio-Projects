using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cookie_Calories
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int bag = 40; //cookies per bag
            int servings = 10; //servings per bag
            int servingCalories = 300; //# of calories per serving

            //based off the above information, here is what we know:
            // # of calories per bag = 3000
            // # cookies per serving = 4
            // calorie per cookie = 300/4 = 75

            int cookies = int.Parse(cookiesEatTextBox.Text);

            caloriesOutputLabel.Text = (cookies*75).ToString();
        }
    }
}
