namespace _05_potegowanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wynik, podstawa, wykladnik, skladnik;

            Console.Write("Podaj postawę potęgi: ");
            while(!int.TryParse(Console.ReadLine(), out podstawa) || podstawa<1 )
            {
                Console.Write("Zła wartość, podaj podstawę potęgi: ");
            }
            Console.Write("Podaj wykładnik potęgi: ");
            while (!int.TryParse(Console.ReadLine(), out wykladnik) || wykladnik < 0)
            {
                Console.Write("Zła wartość, podaj wykładnik potęgi: ");
            }

            if (wykladnik == 0 || podstawa == 1)
                wynik = 1;
            else
            {
                wynik = podstawa;                
                for (int i = 1; i < wykladnik; i++)
                {
                    skladnik = wynik;
                    for (int j = 1; j < podstawa; j++)
                    {
                        wynik += skladnik;
                    }                    
                }
            }

            Console.WriteLine("Wynik potęgowania wynosi: " + wynik);                
        }
    }
}