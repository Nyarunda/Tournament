using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DatabaseConnection;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void PlaceNumberValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidatePrizeForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNameValue.Text,
                    placeNumberValue.Text,
                    prizeAmountValue.Text,
                    prizePercentageValue.Text
                );
                

                GlobalConfig.Connection.CreatePrize(model);
                
                placeNameValue.Text = "";
                placeNumberValue.Text = "";
                prizeAmountValue.Text = "0";
                prizePercentageValue.Text = "0";

            }
            else
                MessageBox.Show("The form has invalid information. Please recheck.");
        }
        private bool ValidatePrizeForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValideNumber = int.TryParse(placeNumberValue.Text, out placeNumber);
            if (!placeNumberValideNumber)
            {
                output = false;
            }
            if (placeNumber < 1)
            {
                output = false;
            }
            if (placeNameValue.Text.Length == 0)
            {
               output = false;
            }
            decimal prizeAmount = 0;
            double prizePercentage = 0;
            bool prizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(prizePercentageValue.Text, out prizePercentage);
            
            if (prizeAmountValid == false || prizePercentageValid == false) output = false;
           
            if (prizeAmount <= 0 && prizePercentage <= 0) output = false;

            if (prizePercentage < 0 || prizePercentage > 100) output = false;

            return output;
        }
    }
}
