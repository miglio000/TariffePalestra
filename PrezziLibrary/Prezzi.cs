using System;

namespace PrezziLibrary
{
    public class Prezzi
    {
        public static string WhichSubscription(int n, string tariffa)
        {
            if (n >= 1 && n <= 7)
            {
                if (n >= 1 && n <= 2)
                {
                    return tariffa = "best subscription: Open 1 Month.";
                }
                else if (n >= 3 && n <= 4)
                {
                    return tariffa = "best subscription: Open 3 Month.";
                }
                else
                {
                    return tariffa = "best subscription: Open 12 Month.";
                }
            }
            else
            {
                return tariffa = "Incorrect number of day/s.";
            }
        }
    }
}
