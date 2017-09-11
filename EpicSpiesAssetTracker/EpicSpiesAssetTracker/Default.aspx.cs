using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EpicSpiesAssetTracker
{
    public partial class Default : System.Web.UI.Page
    {
        //initialize arrays (scoped for Page_Load and Button_Click event use)
        string[] assetsArray;
        int[] electionsArray;
        int[] subterfugeArray;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //If this is the first time loading page, create empty arrays, add to ViewState
                assetsArray = new string[0];
                electionsArray = new int[0];
                subterfugeArray = new int[0];

                ViewState.Add("Assets", assetsArray);
                ViewState.Add("Elections", electionsArray);
                ViewState.Add("Subterfuge", subterfugeArray);
            }
        }

        protected void addassetButton_Click(object sender, EventArgs e)
        {
            //Get arrays from ViewState (previously appended arrays)
            assetsArray = (string[])ViewState["Assets"];
            electionsArray = (int[])ViewState["Elections"];
            subterfugeArray = (int[])ViewState["Subterfuge"];

            //resize arrays so capacity is 1 more for each
            Array.Resize(ref assetsArray, assetsArray.Length + 1);
            Array.Resize(ref electionsArray, electionsArray.Length + 1);
            Array.Resize(ref subterfugeArray, subterfugeArray.Length + 1);

            //find highest index to use for appending new values
            int high_index = assetsArray.GetUpperBound(0);

            //set new values from form TextBoxes as final indexed values in arrays
            assetsArray[high_index] = assetNameTextBox.Text;
            electionsArray[high_index] = int.Parse(electionsTextBox.Text);
            subterfugeArray[high_index] = int.Parse(subterfugeTextBox.Text);

            //save newly appended arrays back to ViewStates
            ViewState["Assets"] = assetsArray;
            ViewState["Elections"] = electionsArray;
            ViewState["Subterfuge"] = subterfugeArray;

            //get aggregate values for Label output
            string last_added = assetsArray[high_index];
            int total_elections = electionsArray.Sum();
            double ave_subs = subterfugeArray.Average();

            //Output values to Label
            assetdataLabel.Text = String.Format("Total Elections Rigged: {0}<br />" +
                "Average Acts of Subterfuge per Asset {1:N2}<br />(Last Asset You Added: {2}", 
                total_elections, ave_subs, last_added);

        }
    }
}