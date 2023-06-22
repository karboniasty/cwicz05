using System.ComponentModel.Design.Serialization;

namespace _01_liczby_pierwsze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ile_liczb, liczba = 2;
            bool czy_pierwsza;
            do
            {
                Console.WriteLine("Ile liczb pierwszych chcesz wypisać?");

            } while (!int.TryParse(Console.ReadLine(), out ile_liczb));
            Console.Write("Liczby pierwsze: ");
            while (ile_liczb > 0)
            {
                czy_pierwsza = true;
                double pierwiastek = Math.Sqrt(liczba);
                for (int i = 2; i <= pierwiastek; i++)
                {
                    if (liczba % i == 0)
                    {
                        czy_pierwsza=false;
                        break;
                    }
                }
                if (czy_pierwsza)
                {
                    Console.Write(liczba + " ");
                    ile_liczb--;
                }
                liczba++;
            }
        }
        
        
    }
}