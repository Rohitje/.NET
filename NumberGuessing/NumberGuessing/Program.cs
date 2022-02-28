using System;

namespace NumberGuessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int winNum = r.Next(0, 200);

            bool win = false;

            do
            {
                Console.Write("Kies een nummer tussen 0 en 200: ");
                string s = Console.ReadLine();

                int i = int.Parse(s);

                if (i > winNum)
                {
                    Console.WriteLine("Te hoog! Gok een lager een nummer...");
                }
                else if (i < winNum)
                {
                    Console.WriteLine("Te laag! Gok een hoger nummer...");
                }
                else if (i == winNum)
                {
                    Console.WriteLine("CORRECT! Je hebt gewonnen!");
                    win = true;
                }

                Console.WriteLine();
            } while (win == false);

            Console.WriteLine("Bedankt voor het spelen!");
            Console.Write("Druk op een willekeurige toets op het toetsenbord om te beëindigen.");
            Console.ReadKey(true);
        }
    }
}
