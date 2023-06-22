namespace _02_liczby_parzyste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random losowa = new Random();
            int liczba, ile_liczb1, ile_liczb2, liczba_losowan1=0, liczba_losowan2=0;

            do
            {
                Console.Write("Ile liczb chcesz wylosować? ");
            } while (!int.TryParse(Console.ReadLine(), out ile_liczb1));

            ile_liczb2 = ile_liczb1;

            //wersja ze sprawdzaniem po losowaniu
            Console.Write("\nLiczby parzyste wylosowane pierwszą metodą: ");
            while(ile_liczb1>0)
            {
                liczba_losowan1++;
                liczba = losowa.Next(-8, 9);
                if (liczba % 2 == 0)
                {
                    ile_liczb1--;
                    if (ile_liczb1 >0)
                        Console.Write(liczba + ", ");
                    else
                        Console.Write(liczba);
                }
            }           
            Console.Write("\nLiczby parzyste wylosowane drugą metodą: ");
            //wersja, która od razu losuje liczbę parzystą
            while (ile_liczb2 > 0)
            {
                liczba_losowan2++;
                liczba = 2*losowa.Next(-4, 5);
                ile_liczb2--;
                if (ile_liczb2 > 0)
                    Console.Write(liczba + ", ");
                else
                    Console.Write(liczba);


            }
            Console.WriteLine("\n\nLiczba losowań pierwszą metodą: {0}\nLiczba losowań drugą metodą: {1}", liczba_losowan1, liczba_losowan2);
        }
    }
}