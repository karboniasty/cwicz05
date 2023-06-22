namespace _04_rysowanie_romb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int liczba_wierszy, zla_wartosc=0;
            
            Console.Write("Podaj liczbę wierszy: ");
            while(!int.TryParse(Console.ReadLine(), out liczba_wierszy) || liczba_wierszy < 3 || liczba_wierszy % 2 == 0)
            {                
                zla_wartosc++;
                if (zla_wartosc == 3)
                    break;
                Console.Write("Zła wartość. Podaj liczbę wierszy: ");
            }
            if(zla_wartosc==3)
            {
                Console.WriteLine("Zbyt duża ilość błędów. Romb nie zostanie narysowany.");
            }
            else
            {
                Random losowanie = new Random();
                string[] znaki = new string[] { "#", "@", "|", "*", ".", ":", "-", "+" };
                string ramka = znaki[losowanie.Next(0, 4)];
                string srodek = znaki[losowanie.Next(4, 8)];
                int i, spacje_przed = 2 * (liczba_wierszy/2), liczba_na_wiersz=-1;
                
                for (i=0; i<liczba_wierszy/2; i++)
                {
                    for (int j = 0; j < spacje_przed; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(ramka);
                    for (int j = 0; j < liczba_na_wiersz; j++)
                    {
                        Console.Write(" "+ srodek);
                    }
                    if (i > 0)
                        Console.Write(" {0}\n", ramka);
                    else
                        Console.Write("\n");
                    liczba_na_wiersz += 2;
                    spacje_przed -= 2;
                }
                for (int j = i; j < liczba_wierszy; j++)
                {
                    for (int k = 0; k < spacje_przed; k++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(ramka);
                    for (int k = 0; k < liczba_na_wiersz; k++)
                    {
                        Console.Write(" " + srodek);
                    }
                    if (j < liczba_wierszy-1)
                        Console.Write(" {0}\n", ramka);                    
                    liczba_na_wiersz -= 2;
                    spacje_przed += 2;
                }
            }
        }
    }
}