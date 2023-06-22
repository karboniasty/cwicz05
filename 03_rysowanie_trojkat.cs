namespace _03_rysowanie_trojkat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wysokosc, liczba_na_wiersz = 1;

            Console.Write("Podaj wysokość trójkąta: ");
            while (!int.TryParse(Console.ReadLine(), out wysokosc))
            {
                Console.Write("Błędna wartość. Podaj wysokość trójkąta: ");
            }

            int spacje_przed = 2 * (wysokosc - 1) - 1;
            
            for(int i=1; i< wysokosc ; i++)
            {
                for(int j=0; j<spacje_przed ; j++)
                {
                    Console.Write(" ");
                }
                for(int j=0; j<liczba_na_wiersz ; j++)
                {
                    Console.Write(" +");
                }
                Console.Write("\n");
                liczba_na_wiersz += 2;
                spacje_przed -= 2;
            }
            for(int i=1;i<liczba_na_wiersz;i++)
            {
                Console.Write("+ ");
            }
            Console.Write("+");
        }
    }
}