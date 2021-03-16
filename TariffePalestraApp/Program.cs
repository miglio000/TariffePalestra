using System;
using PrezziLibrary;
namespace TariffePalestraApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string tariffa = "";
            Console.WriteLine("Insert numbers of days: ");
            int giorni = int.Parse(Console.ReadLine());
            string migliore = Prezzi.WhichSubscription(giorni, tariffa);
            Console.WriteLine(migliore);
        }
    }
}
