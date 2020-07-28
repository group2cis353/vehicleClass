using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_Group2
{
    public partial class vehicleClass : Form
    {
        string Make;
        string Model;
        string Plate;
        public vehicleClass()
        {
            InitializeComponent();
        }

        private void MakeInput_TextChanged(object sender, EventArgs e)
        {
            Make = MakeInput.Text;
        }

        private void ModeLInput_TextChanged(object sender, EventArgs e)
        {
            Model = ModeLInput.Text;
        }

        private void plateInput_TextChanged(object sender, EventArgs e)
        {
            Plate = plateInput.Text.ToString();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string message = "You have entered: \n " +
                "Make: " + Make + "\n " +
                "Model: " + Model + "\n" +
                "License Plate: " + Plate + "\n" +
                "Is this correct?";
            string title = "Submit";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult selection = MessageBox.Show(message, title, buttons);
            if (selection == DialogResult.Yes)
            {
                // code to save to file
            }
            else 
            {

            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            // code to go back to start window
        }
    }
}
