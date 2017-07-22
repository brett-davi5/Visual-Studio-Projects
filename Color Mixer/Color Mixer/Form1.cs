using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Mixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mixButton_Click(object sender, EventArgs e)
        {
            if (redRadioButton1.Checked && redRadioButton2.Checked)
            {
                this.BackColor = Color.Red;
            }
            else if (redRadioButton1.Checked && blueRadioButton2.Checked)
            {
                this.BackColor = Color.Purple;
            }
            else if (redRadioButton1.Checked && yellowRadioButton2.Checked)
            {
                this.BackColor = Color.Orange;
            }
            else if (yellowRadioButton1.Checked && redRadioButton2.Checked)
            {
                this.BackColor = Color.Orange;
            }
            else if (yellowRadioButton1.Checked && yellowRadioButton2.Checked)
            {
                this.BackColor = Color.Yellow;
            }
            else if (yellowRadioButton1.Checked && blueRadioButton2.Checked)
            {
                this.BackColor = Color.Green;
            }
            else if (blueRadioButton1.Checked && redRadioButton2.Checked)
            {
                this.BackColor = Color.Purple;
            }
            else if (blueRadioButton1.Checked && yellowRadioButton2.Checked)
            {
                this.BackColor = Color.Green;
            }
            else if (blueRadioButton1.Checked && blueRadioButton2.Checked)
            {
                this.BackColor = Color.Blue;
            }
        }
    }
}
