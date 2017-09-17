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
            /*
            if (!Page.IsPostBack)
            {
                string[] names = new string[0];
                ViewState.Add("Names", names);

                double[] numbers = new double[0];
                ViewState.Add("Numbers", numbers);
            }
            */

            // Most battles belong to: (names) Pheonix (Value: (numbers)) //most battles
            // Least battles belong to: (names) Wolverine (Value: (numbers)) //fewest battles

            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Pheonix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

            string result = "";

            int mostBattles = 0;
            int leastBattles = 0;

            for (int i = 0; i < names.Length; i++)
            {
                if (numbers[i] > numbers[mostBattles])
                {
                    mostBattles = i;
                }

                if (numbers[i] < numbers[leastBattles])
                {
                    leastBattles = i;
                }
            }

            result = String.Format("Most battles belong to: {0} (Value: {1})<br />", names[mostBattles], numbers[mostBattles]);
            result += String.Format("Least battles belong to: {0} (Value: {1})", names[leastBattles], numbers[leastBattles]);

            resultLabel.Text = result;
        }
    }
}