using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TEST_06._02._2020
{
    class Mieszkanie
    {
        public int Metraz { get; set; }
        public string Nazwa { get; set; }
        public int OdlegloscOdCentrum { get; set; }
        public Mieszkanie(int metraz, string nazwa, int odlegloscOdCentrum)
        {
            Metraz = metraz;
            Nazwa = nazwa;
            OdlegloscOdCentrum = odlegloscOdCentrum;
        }

        public static List<Mieszkanie> Mieszkania = new List<Mieszkanie>();

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static void insertingmieszkanie()
        {
            for (int i = 0; i < 50; i++)
            {
                Mieszkanie Mieszkanietemp = new Mieszkanie(i, Mieszkanie.RandomString(4), i * 30);
                Mieszkania.Add(Mieszkanietemp);
            }
        }
        public static List<Mieszkanie> sortowaniemieszkania()
        {
            return Mieszkanie.Mieszkania.
                OrderBy(m => m.OdlegloscOdCentrum).
                OrderBy(m => m.Nazwa).ToList();
        }
        public static void displaymieszkania()
        {
            foreach (var item in sortowaniemieszkania())
            {
                Console.WriteLine("Nazwa {0} Metraz {1} Odleglosc {2}", item.Nazwa, item.Metraz, item.OdlegloscOdCentrum);
            }
        }
    }
}
