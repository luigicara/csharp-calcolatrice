namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main()
        {
            int a = -2;
            int b = 0;

            Console.WriteLine($"I numeri sono {a} e {b}");

            Console.WriteLine($"La somma di questi due numeri è {Helper.Sum(a,b)}");

            Console.WriteLine($"La sottrazione di questi due numeri è {Helper.Sub(a, b)}");

            Console.WriteLine($"La moltiplicazione di questi due numeri è {Helper.Multi(a, b)}");

            Console.WriteLine($"Il valore assoluto di {a} è {Helper.Abs(a)}");

            Console.WriteLine($"Il minore tra questi due numeri è {Helper.Min(a, b)}");

            Console.WriteLine($"Il maggiore tra questi due numeri è {Helper.Max(a, b)}");
            //bonus
            Console.WriteLine($"Il numero {a} elevato a {b} è uguale a {Helper.Expo(a, b)}");

            double c = -1.2;
            double d = 3.7;

            Console.WriteLine($"\r\nI numeri sono {c} e {d}");

            Console.WriteLine($"La somma di questi due numeri è {Helper.Sum(c, d)}");

            Console.WriteLine($"La sottrazione di questi due numeri è {Helper.Sub(c, d)}");

            Console.WriteLine($"La moltiplicazione di questi due numeri è {Helper.Multi(c, d)}");

            Console.WriteLine($"Il valore assoluto di {c} è {Helper.Abs(c)}");

            Console.WriteLine($"Il minore tra questi due numeri è {Helper.Min(c, d)}");

            Console.WriteLine($"Il maggiore tra questi due numeri è {Helper.Max(c, d)}");
        }
    }
}