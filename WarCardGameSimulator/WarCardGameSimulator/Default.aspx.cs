using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WarCardGameSimulator
{
    public partial class Default : System.Web.UI.Page
    {
        Random random = new Random();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                P1TextBox.Visible = false;
                P2TextBox.Visible = false;
                PlayButton.Text = "Play Again!";
            }

        }

        protected void PlayButton_Click(object sender, EventArgs e)
        {
            //Clear previous game
            ResultsLabel.Text = "";
            string p1Name = P1TextBox.Text;
            string p2Name = P2TextBox.Text;
            if (P1TextBox.Text == "") P1TextBox.Text = "Player1";
            if (P2TextBox.Text == "") P2TextBox.Text = "Player2";

            Game game = new Game
            {   // Get player names from textboxes
                Player1 = new Player() { Name = p1Name, Hand = new List<Card>() },
                Player2 = new Player() { Name = p2Name, Hand = new List<Card>() }
            };
            
            //add player names to label
            ResultsLabel.Text = game.Player1.Name + " vs. " + game.Player2.Name + "<br />";

            game.DealtoPlayers(random);

            while (game.Player1.Hand.Count > 0 && game.Player2.Hand.Count > 0)
            {
                Battle battle = new Battle();

                //Compare values
                battle.PlayBattle(game.Player1, game.Player2);

                //Both players flip over first card
                P1Image.ImageUrl = "Images/" + (battle.Card1.Name) + ".png";
                P2Image.ImageUrl = "Images/" + (battle.Card2.Name) + ".png";

                //Display winner of battle and number of cards won
                ResultsLabel.Text += String.Format("<br />{0} vs. {1}: {2} wins {3} cards",
                    battle.Card1.Face, battle.Card2.Face, battle.Winner.Name, battle.Wincards.Count);
            }
            if (game.Player1.Hand.Count > 0) game.Winner = game.Player1;
            else game.Winner = game.Player2;

            ResultsLabel.Text += String.Format("<br /><br />{0} Wins the War!", game.Winner.Name);
        }
       
               
    }
}