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
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Game DartGame = new Game();
            while (DartGame.Player1Score < 300 && DartGame.Player2Score < 300)
            {
                DartGame.PlayRound();
                player1Label.Text += String.Format("<br />{0}", DartGame.Player1Score);
                player2Label.Text += String.Format("<br />{0}", DartGame.Player2Score);

            }
            if (DartGame.Player1Score >= 300 && DartGame.Player2Score >= 300)
            {
                player1Label.Text += String.Format("<br /><br />Tie!<br />");
                player2Label.Text += String.Format("<br /><br />Tie!<br />");
            }
            else if (DartGame.Player1Score >= 300) player1Label.Text += String.Format("<br /><br />Winner!<br />");
            else player2Label.Text += String.Format("<br /><br />Winner!<br />");
        }
    }
}