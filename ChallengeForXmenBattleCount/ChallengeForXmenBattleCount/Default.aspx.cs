using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeForXmenBattleCount
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Wolverine fewest battles
            // Pheonix most battles

            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Pheonix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

            string result = "";
            string max_name = "";
            string min_name = "";

            int max_battles = numbers[0];
            int min_battles = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max_battles)
                {
                    max_battles = numbers[i];
                    max_name = names[i];
                }
                if (numbers[i] < min_battles)
                {
                    min_battles = numbers[i];
                    min_name = names[i];
                }
            }

            result = String.Format("Most battles belong to {0} (Value: {1})<br />" +
                "Least battles belongs to {2} (Value: {3})", max_name, max_battles,
                min_name, min_battles);

            resultLabel.Text = result;
        }
    }
}