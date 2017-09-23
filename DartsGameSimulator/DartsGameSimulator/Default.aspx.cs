using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DartsGameSimulator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack)
            {
                PlayButton.Text = "Play Again!";
                p1nameLabel.Text = P1TextBox.Text;
                p2nameLabel.Text = P2TextBox.Text;
                P1TextBox.Visible = false;
                P2TextBox.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string player1 = P1TextBox.Text;
            string player2 = P2TextBox.Text;

            Game DartGame = new Game(player1, player2);

            while (DartGame._player1.Score < 300 && DartGame._player2.Score < 300)
            {
                DartGame.PlayRound();
                player1Label.Text += String.Format("<br />{0}", DartGame._player1.Score);
                player2Label.Text += String.Format("<br />{0}", DartGame._player2.Score);

            }
            player1Label.Text += "<br />";
            player2Label.Text += "<br />";

            if (DartGame._player1.Score >= 300 && DartGame._player2.Score >= 300)
            {
                player1Label.Text += String.Format("<br />Tie!<br />");
                player2Label.Text += String.Format("<br />Tie!<br />");
            }
            else if (DartGame._player1.Score >= 300) player1Label.Text += String.Format("<br />Winner!<br />");
            else player2Label.Text += String.Format("<br />Winner!<br />");
        }
    }
}