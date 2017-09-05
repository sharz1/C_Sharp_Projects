using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CondtionalRadioButton
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OkButton_Click(object sender, EventArgs e)
        {
            if (selectedLabel.Text != "")
                selectedLabel.Text = "";
            if (pencilRadioButton.Checked)
                optionImage.ImageUrl = "pencil.png";
            else if (penRadioButton.Checked)
                optionImage.ImageUrl = "pen.png";
            else if (phoneRadioButton.Checked)
                optionImage.ImageUrl = "phone.png"; 
            else if (tabletRadioButton.Checked)
                optionImage.ImageUrl = "tablet.png"; 
            else
                selectedLabel.Text = "Please select an option"; 
        }
    }
}