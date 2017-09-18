using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 1.  Reverse your name
            // The result will be nayrB eelrahS
            string name = "Sharlee Bryan";
            for (int i = name.Length-1; i >= 0; i--)
            {
                Label1.Text += name[i];
            }


            // 2.  Reverse this sequence: "Luke,Leia,Han,Chewbacca"
            // When you're finished it should look like this:
            // Chewbacca,Han,Leia,Luke
            string names = "Luke,Leia,Han,Chewbacca";
            string[] splitnames = names.Split(',');
            for (int i = splitnames.Length-1; i >= 0; i--)
            {
                Label2.Text += splitnames[i] + ",";
            }
            Label2.Text = Label2.Text.Remove(Label2.Text.Length - 1, 1);

            // 3. Use the sequence to create ascii art:
            // *****luke*****
            // *****leia*****
            // *****han******
            // **Chewbacca***
            for (int i = 0; i < splitnames.Length; i++)
            {
                int sl = splitnames[i].Length;
                string artname = splitnames[i].PadLeft((sl + (14 - sl) / 2), '*');
                Label3.Text += artname.PadRight(14, '*') + "<br />";
            }


            // 4. Solve this puzzle:
            // Once you fix it with string helper methods, it should read:
            // Now is the time for all good men to come to the aid of their country.

            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";
            {
                Label4.Text = puzzle.Remove(puzzle.IndexOf("remove-me"), 
                    ("remove-me").Length).Replace('Z', 'T').ToLower().Replace("now","Now");
            }



        }
    }
}