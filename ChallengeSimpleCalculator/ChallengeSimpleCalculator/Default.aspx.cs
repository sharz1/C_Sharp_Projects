using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSimpleCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void plusButton_Click(object sender, EventArgs e)
        {
            decimal firstValue = decimal.Parse(inputBox1.Text);
            decimal secondValue = decimal.Parse(inputBox2.Text);
            decimal result = (firstValue + secondValue);

            resultLabel.Text = result.ToString();
        }

        protected void minusButton_Click(object sender, EventArgs e)
        {
            decimal firstValue = decimal.Parse(inputBox1.Text);
            decimal secondValue = decimal.Parse(inputBox2.Text);
            decimal result = (firstValue - secondValue);

            resultLabel.Text = result.ToString();
        }

        protected void multButton_Click(object sender, EventArgs e)
        {
            decimal firstValue = decimal.Parse(inputBox1.Text);
            decimal secondValue = decimal.Parse(inputBox2.Text);
            decimal result;
            checked
            {
                result = (firstValue * secondValue);
            }

            resultLabel.Text = result.ToString();
        }

        protected void divideButton_Click(object sender, EventArgs e)
        {
            decimal firstValue = decimal.Parse(inputBox1.Text);
            decimal secondValue = decimal.Parse(inputBox2.Text);
            decimal result;
            checked
            {
                result = (firstValue / secondValue);
            }

            resultLabel.Text = result.ToString();
        }
    }
}