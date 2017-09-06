using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DaysBetweenDates
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void calcButton_Click(object sender, EventArgs e)
        {
            DateTime firstDate = firstCalendar.SelectedDate;
            DateTime secondDate = secondCalendar.SelectedDate;
            TimeSpan diffSpan = secondDate.Subtract(firstDate);

            if (secondDate > firstDate)
                resultLabel.Text = diffSpan.TotalDays.ToString() + " Days";
            else
                resultLabel.Text = "Start date cannot be later than end date. Please try again.";
        }
    }
}