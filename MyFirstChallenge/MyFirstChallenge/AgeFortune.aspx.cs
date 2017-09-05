using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstChallenge
{
    public partial class AgeFortune : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void fortuneButton_Click(object sender, EventArgs e)
        {
            string userAge = ageTextBox.Text;
            string userMoney = moneyTextBox.Text;

            string result = $"At {userAge} years old, I would have expected you to have more than {userMoney} in your pocket!";

            resultLabel.Text = result;
        }
    }
}