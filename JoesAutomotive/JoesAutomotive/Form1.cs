using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoesAutomotive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void oilLubeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //call all 5 fucntions to clear them
            clearOilLube();
            clearFlushes();
            clearMisc();
            clearOther();
            clearFees();

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (int.Parse(laborTextBox.Text) >= 0)
            {
                double totalServices = oilLubeCharges() + flushCharges() + miscCharges() + int.Parse(laborTextBox.Text);
                servicesLaborOutput.Text = totalServices.ToString();

                double partsAmount = double.Parse(partsTextBox.Text);
                partsOutput.Text = partsAmount.ToString();

                double taxValue = taxCharges(partsAmount);
                taxOutput.Text = taxValue.ToString();

                double totalEverything = totalServices + partsAmount + taxValue;
                totalFeesOutput.Text = totalEverything.ToString();
            }
            else
            {
                double totalServices = oilLubeCharges() + flushCharges() + miscCharges();
                servicesLaborOutput.Text = totalServices.ToString();

                double partsAmount = double.Parse(partsTextBox.Text);
                partsOutput.Text = partsAmount.ToString();

                double taxValue = taxCharges(partsAmount);
                taxOutput.Text = taxValue.ToString();

                double totalEverything = totalServices + partsAmount + taxValue;
                totalFeesOutput.Text = totalEverything.ToString();
            }

            

        }

        public int oil = 0;
        public int lubeJob = 0;
        public int inspection;
        public int replaceMuffler;
        public int tireRotation;
        public int radiatorFlush = 0;
        public int transmissionFlush = 0;
        public int parts;
        public int labor;

        private int oilLubeCharges()
        {
            if (oilChangeBox.Checked)
            {
                oil = 26;
            }
            if (lubeJobBox.Checked)
            {
                lubeJob = 18;
            }

            return oil + lubeJob;
        }

        private int flushCharges()
        {
            if (radiatorFlushBox.Checked)
            {
                radiatorFlush = 30;
            }
            if (transmissionFlushBox.Checked)
            {
                transmissionFlush = 80;
            }
            return radiatorFlush + transmissionFlush;
        }

        private int miscCharges()
        {
            if (inspectionBox.Checked)
            {
                inspection = 15;
            }
            if (replaceMufflerBox.Checked)
            {
                replaceMuffler = 100;
            }
            if (tireRotationBox.Checked)
            {
                tireRotation = 20;
            }
            return inspection + replaceMuffler + tireRotation;
        }

        private int otherCharges()
        {
            parts = int.Parse(partsTextBox.Text);
            labor = int.Parse(laborTextBox.Text);
            return parts + labor;
        }

        private double taxCharges(double parts)
        {
            if (parts > 0)
            {
                return 0.06 * parts;
            }
            else
            {
                return 0;
            }
        }

        private void clearOilLube()
        {
            oilChangeBox.Checked = false;
            lubeJobBox.Checked = false;
        }
        private void clearFlushes()
        {
            radiatorFlushBox.Checked = false;
            transmissionFlushBox.Checked = false;
        }
        private void clearMisc()
        {
            inspectionBox.Checked = false;
            replaceMufflerBox.Checked = false;
            tireRotationBox.Checked = false;
        }
        private void clearOther()
        {
            partsTextBox.Text = " ";
            laborTextBox.Text = " ";
        }
        private void clearFees()
        {
            servicesLaborOutput.Text = " ";
            partsOutput.Text = " ";
            taxOutput.Text = " ";
            totalFeesOutput.Text = " ";
        }
    }
}
