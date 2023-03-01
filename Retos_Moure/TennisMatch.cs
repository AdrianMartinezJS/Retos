using System;
using System.Collections;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Retos_Moure
{
    public class TennisMatch
    {
        private string[] results = new string[6] { "Love", "15", "30", "40", "Deuce", "Advantage" };
        private Player P1 = new Player();
        private Player P2 = new Player();
        private int allowedDifference = 2;
        private string advantagedPlayer = "";

        public string printResult(string[] match)
        {
            for (int i = 0; i < match.Length; i++)
            {
                if (match[i] == "P1")
                    P1.incrementPoints();
                if (match[i] == "P2")
                    P2.incrementPoints();
                advantagedPlayer = P1.Points > P2.Points ? "P1" : "P2";
                if (P1.Points >= 4 && P2.Points == (P1.Points - allowedDifference) || P2.Points >= 4 && P1.Points == (P2.Points - allowedDifference))
                    break;
                if (P1.Points == P2.Points && P1.Points >= 3)
                {
                    Console.WriteLine(results[4]);
                    continue;
                }
                else if ((P1.Points > P2.Points && P1.Points >= 4) || (P1.Points < P2.Points && P2.Points >= 4))
                {
                    Console.WriteLine(results[5] + " " + advantagedPlayer);
                    continue;
                }
                Console.WriteLine(results[P1.Points] + " - " + results[P2.Points]);
            }
            return String.Format("The winner is {0} with a final result from: {1} - {2}", advantagedPlayer, P1.Points, P2.Points);

        }

    }
}
