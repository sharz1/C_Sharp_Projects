using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CasinoSlots
{
    public partial class Default : System.Web.UI.Page
    {
        int total_money;
        int betAmount;
        Random random = new Random();
        string[] slotimages = new string[12]
                {"Bar.png","Bell.png","Cherry.png","Clover.png","Diamond.png","Horseshoe.png",
                 "Lemon.png","Seven.png","Plum.png","Orange.png","Strawberry.png","Watermelon.png"};

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ViewState.Add("TotalMoney", "100");
            }
            total_money = int.Parse(ViewState["TotalMoney"].ToString());
            MoneyLabel.Text = String.Format("Player's Money: {0:C}", total_money); 
        }

        protected void LeverBtn_Click(object sender, EventArgs e)
        {

            //get bet from radio/text box, if 0 or not enough money in bank don't continue
            betAmount = getBetAmount();
            if (betAmount == 0 || betAmount > total_money) return;
            //fortesting: else ResultLabel.Text = String.Format("You bet: {0:C}", betAmount);
            
            //get random reels and set images
            getReels(out int r1, out int r2, out int r3);

            //determine winnings and notify user about results
            int win_loss = getWinnings(r1, r2, r3);

            if (win_loss == 0) ResultLabel.Text = String.Format("Sorry, you lost " +
                "{0:C}. Better luck next time.", betAmount);
            else ResultLabel.Text = String.Format("You bet {0:C} and won {1:C}!", betAmount, win_loss);

            //Update player's money total
            updateMoney(total_money,win_loss);
        }
        
        private int getBetAmount()
        {
            if (RadioOther.Checked) return getOtherbet();
            else if (Radio20.Checked) return 20;
            else if (Radio10.Checked) return 10;
            else if (Radio5.Checked) return 5;
            else if (Radio2.Checked) return 2;
            else if (Radio1.Checked) return 1;
            else return 0;
        }
        private int getOtherbet()
        {
            //get bet amount from input text box, validate it is an integer
            if (!int.TryParse(BetTextBox.Text.Trim(), out betAmount)) return 0;
            //if entered amount is greater than MAXBET($20), set betamount to $20
            if (betAmount > 20)
            {
                BetTextBox.Text = "20";
                Radio20.Checked = true;
                betAmount = 20;
            }
            return betAmount;
        }

        private void getReels(out int r1, out int r2, out int r3)
        {
            //get random number for each reel image
            r1 = random.Next(0, 11);
            r2 = random.Next(0, 11);
            r3 = random.Next(0, 11);

            //use random number as index for image URL in slotimages array
            reel1.ImageUrl = slotimages[r1];
            reel2.ImageUrl = slotimages[r2];
            reel3.ImageUrl = slotimages[r3];

        }

        private int getWinnings(int r1, int r2, int r3)
        {
            //Check for a bar = no winnings, lose bet amount
            if (r1 == 0 || r2 == 0 || r3 == 0) return 0;
            //if all 7s, win 100X bet
            else if (r1 == 7 && r2 == 7 && r3 == 7) return (betAmount * 100);
            // if all cherries, win 4x bet
            else if (r1 == 2 && r2 == 2 && r3 == 2) return (betAmount * 4);
            // if no triples or bars present, check for 2 cherries, win 3x bet
            else if ((r1 == 2 && r2 == 2) || (r2 == 2 && r3 == 2) || (r1 == 2 && r3 == 2))
                return (betAmount * 3);
            //if no double cherries, check for single cherries, win 2x bet 
            else if (r1 == 2 || r2 == 2 || r3 == 2) return (betAmount * 2);
            //if any other combo, no win, lose bet amount
            else return 0;
        }

        private void updateMoney(int total_money, int win_loss)
        {
            total_money += (win_loss-betAmount);
            MoneyLabel.Text = String.Format("Player's Money: {0:C}", total_money);
            ViewState["TotalMoney"] = total_money;
        }
    }
}