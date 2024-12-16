using System;

namespace ZadanieWartownik
{
    class Program
    {
        static void Main(string[] args)
        {
            wartownik();
        }

        static void wartownik()
        {
            int[] Tablica = new int[51];
            Random rnd = new Random();
            for (int i = 0; i <= 49; i++)
            {
                Tablica[i] = rnd.Next(0, 100);
            }

            for (int i = 0; i <= 49; i++)
            {
                Console.Write(i+"."+Tablica[i] + " ");
            }
            
            Console.WriteLine("\nPodaj liczbę, która ma być wyszukana: ");
            int szukana;
            if (int.TryParse(Console.ReadLine(), out szukana))
            {

                Tablica[50] = szukana;

                int i = 0;
                while (Tablica[i] != szukana)
                {
                    i++;
                }

                if (i == 50)
                {
                    Console.WriteLine("Nie znaleziono szukanej liczby");
                }
                else
                {
                    Console.WriteLine("Znaleziono pierwsze wystąpienie pod indeksem: "+i);
                }

            }
        }
       
    }
}