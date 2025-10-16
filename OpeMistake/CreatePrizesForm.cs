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

namespace TrackerUI
{
    public partial class CreatePrizesForm : Form
    {
        public CreatePrizesForm()
        {
            InitializeComponent();
        }

        private void createPrizeLabel_Click(object sender, EventArgs e)
        {

        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNumberValue.Text,
                    placeNameValue.Text,
                    prizePercentageValue.Text,
                    placeAmountValue.Text);

                foreach (IDataConnection db in GlobalConfig.Connections) 
                {
                    db.CreatePrize(model);
                }
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check again and try again.");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNumberValue.Text, out placeNumber);

            if (placeNumberValidNumber == false)
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

            decimal placeAmount = 0;
            decimal prizePercentage = 0;

            bool placeAmountValid = decimal.TryParse(placeAmountValue.Text, out placeAmount);
            bool prizePercentageValid = decimal.TryParse(prizePercentageValue.Text, out prizePercentage);

            if (placeAmountValid == false || prizePercentageValid == false)
            {
                output = false;
            }
            if (placeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }
            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }

            return output;
        }
    }
}
