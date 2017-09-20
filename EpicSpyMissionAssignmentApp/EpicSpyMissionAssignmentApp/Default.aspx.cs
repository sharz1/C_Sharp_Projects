using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EpicSpyMissionAssignmentApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                spyNameTextBox.Text = "Rosalina";
                newassignTextBox.Text = "Project: Go Kart";
                prevCalendar.SelectedDate = DateTime.Now.Date;
                newstartCalendar.SelectedDate = prevCalendar.SelectedDate.AddDays(14);
            }
        }

        protected void aspyButton_Click(object sender, EventArgs e)
        {
            if (newstartCalendar.SelectedDate.Subtract(prevCalendar.SelectedDate).TotalDays < 14)
            {
                budgetLabel.Text = "Cannot Assign Spy: " +
                    "Must allow at least 2 weeks between previous assignment and new assignment.";
                newstartCalendar.SelectedDate = prevCalendar.SelectedDate.AddDays(14);
            }
            else
            {
                TimeSpan duration = newendCalendar.SelectedDate.Subtract(newstartCalendar.SelectedDate);
                double budget = 0.00;
                if (duration.TotalDays < 0)
                    budgetLabel.Text = "Error: New Assignment Start Date must be before End Date";
                else
                {
                    budget = duration.TotalDays * 500;
                    if (duration.TotalDays > 21)
                    {
                        budget += 1000;
                    }
                    budgetLabel.Text = String.Format(
                        "Authorized: {0} has been assigned to {1}. Budget total: {2:C}",
                        spyNameTextBox.Text, newassignTextBox.Text, budget);

                }
            }
                




        }
    }
}