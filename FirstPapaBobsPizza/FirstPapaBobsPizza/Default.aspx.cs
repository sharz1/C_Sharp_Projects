using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstPapaBobsPizza
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void purchaseButton_Click(object sender, EventArgs e)
        {
            double pricer = 0;
            if (babyRadio.Checked)
                pricer += 10;
            else if (mamaRadio.Checked)
                pricer += 13;
            else if (papaRadio.Checked)
                pricer += 16;

            if (deepRadio.Checked)
                pricer += 2;

            if (pepCheckBox.Checked)
                pricer += 1.5;
            if (onionCheckBox.Checked)
                pricer += .75;
            if (gpCheckBox.Checked)
                pricer += .5;
            if (rpCheckBox.Checked)
                pricer += .75;
            if (anchCheckBox.Checked)
                pricer += 2;
            if ((pepCheckBox.Checked && gpCheckBox.Checked && anchCheckBox.Checked)
                || (pepCheckBox.Checked && rpCheckBox.Checked && onionCheckBox.Checked))
                pricer -= 2;
            string total = pricer.ToString();

            totalLabel.Text = "$" + total;


        }
    }
}