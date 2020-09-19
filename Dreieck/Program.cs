using System;

namespace Dreieck
{
    class Program
    {
        static void Main(string[] args)
        {
            RechtwinkligesDreieck dreieck_1 = new RechtwinkligesDreieck();
            string text;
            double zahl;
            bool ok = true;
            do
            {
                Console.WriteLine("Geben Sie den Winkel alpha ein.");
                text = Console.ReadLine();
                ok = Double.TryParse(text, out zahl);
                if (ok)
                {
                    dreieck_1.SetAlpha(zahl);
                }
            } while (!ok);
            Console.WriteLine("Geben Sie die länge der Hypothenuse ein.");
            dreieck_1.SetHypothenuse(Double.Parse(Console.ReadLine()));
            // Console.WriteLine(dreieck_1.GetAlpha());
            Console.WriteLine("Beta ist " + dreieck_1.GetBeta()+"°");
            Console.WriteLine("Die Gegenkathete von Alpha ist " + Math.Round(dreieck_1.GetKathete_a(),2) + " Längeneinheiten");
        }
    }
}
