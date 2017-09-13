using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostalCalculator
{
    public partial class Default : System.Web.UI.Page
    {
     
        protected void handleChange(object sender, EventArgs e)
        {
            CalculatePrice();
        }


        private void CalculatePrice()
        {
            //Check if dimensions are provided
            if (!getDimensions()) return;

            //Check if volume returns anything
            double pkg_volume = 0.0;
            if (!getVolume(out pkg_volume)) return;
            
            //Determine the multiplier
            double shipmultiplier = getMultiplier();

            //Calculate shipcost
            double shipcost = shipmultiplier * pkg_volume;

            //Output shipcost to the user
            PriceLabel.Text = String.Format("Shipping Cost: {0:C}", shipcost);
        }

        private bool getDimensions()
        {
            if (!GroundRadioBtn.Checked && !AirRadioBtn.Checked && !NextDayRadioBtn.Checked)
                return false;

            if (WidthTextBox.Text.Trim().Length == 0 | HeightTextBox.Text.Trim().Length == 0)
                return false;

            return true;
        }

        private bool getVolume(out double pkg_volume)
        {
            pkg_volume = 0;

            double pkg_width = 0.0;
            double pkg_height = 0.0;
            double pkg_length = 0.0;

            if(!double.TryParse(WidthTextBox.Text.Trim(), out pkg_width)) return false;
            if(!double.TryParse(HeightTextBox.Text.Trim(), out pkg_height)) return false;
            if(!double.TryParse(LengthTextBox.Text.Trim(), out pkg_length)) pkg_length = 1;

            pkg_volume = pkg_width * pkg_height * pkg_length;

            return true;
        }

        private double getMultiplier()
        {
            if (GroundRadioBtn.Checked) return .15;
            else if (AirRadioBtn.Checked) return .25;
            else if (NextDayRadioBtn.Checked) return .45;
            else return 0;
        }



    }
}