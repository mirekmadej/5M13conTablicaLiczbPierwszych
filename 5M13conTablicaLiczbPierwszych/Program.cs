namespace _5M13conTablicaLiczbPierwszych
{
    /*
     * Program ma w tablicy n-elementowej przechowywac kolejne liczby pierwsze
     * użytkownik podaje n, w programie torzona jest tablica n-elementowa
     * i dodawane są do niej kolejne licby pierwsze
     * na końcu wypisywana jest zawartość tablicy
     * 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("poczaj liczbe elmentów: ");
            int liczba = int.Parse(Console.ReadLine());
            int[] liczby = new int[liczba];
            liczby[0] = 2;
            for (int i = 1; i < liczba; i++)
            {
                liczby [i] = liczbaPierwsza(liczby[i-1]);
            }
            wypiszLiczby(liczby);

        }
        private static bool czyPierwsza(int n)
        {
            for(int i = 2; i*i <= n; i++) //szukamy do pierwiastka z n
                if(n%i == 0)
                    return false;
            return true;
        }
        private static int liczbaPierwsza(int n)
        {
            while(true)
            {
                n++;
                if(czyPierwsza(n))
                    return n;
            }
        }
        private static void wypiszLiczby(int[] n)
        {
            Console.WriteLine("Liczby pierwsze: ");
            foreach (int i in n)
                Console.Write($"{i}; ");
            Console.WriteLine();
        }
    }
}
