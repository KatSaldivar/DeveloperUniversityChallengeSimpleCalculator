using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSimpleCalculator
{
    public partial class CalculatorWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void additionButton_Click(object sender, EventArgs e)
        {
            float myFirstValue = float.Parse(firstValue.Text);
            float mysecondValue = float.Parse(secondValue.Text);
            float resultFloat = myFirstValue + mysecondValue;
            string result = resultFloat.ToString();
            resultLabel.Text = result;
        }

        protected void subtractButton_Click(object sender, EventArgs e)
        {
            float myFirstValue = float.Parse(firstValue.Text);
            float mysecondValue = float.Parse(secondValue.Text);
            float resultFloat = myFirstValue - mysecondValue;
            string result = resultFloat.ToString();
            resultLabel.Text = result;
        }

        protected void multiplyButton_Click(object sender, EventArgs e)
        {
            float myFirstValue = float.Parse(firstValue.Text);
            float mysecondValue = float.Parse(secondValue.Text);
            float resultFloat = myFirstValue * mysecondValue;
            string result = resultFloat.ToString();
            resultLabel.Text = result;
        }

        protected void divideButton_Click(object sender, EventArgs e)
        {
            float myFirstValue = float.Parse(firstValue.Text);
            float mysecondValue = float.Parse(secondValue.Text);
            float resultFloat = myFirstValue / mysecondValue;
            string result = resultFloat.ToString();
            resultLabel.Text = result;
        }
    }
}