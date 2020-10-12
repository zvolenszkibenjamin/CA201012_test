using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1002_csdolgozat
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2020.10.12. 11AB dolgozat - Zvolenszki Benjámin

            int[] t = new int[100];
            Random rnd = new Random();

            // Tömb feltöltése, kiírás
            for (int i = 0; i < 100; i++)
            {
                t[i] = rnd.Next(200, 2000) * 5;

                if ((i + 1) % 7 == 0) Console.ForegroundColor = ConsoleColor.Green;
                else Console.ResetColor();

                Console.Write($"{t[i]} ");
                if ((i + 1) % 10 == 0) Console.Write("\n");
            }

            Console.WriteLine($"\nA tömb elemeinek összege: {t.Sum()}");

            // 4000 és 5000 közötti elemek feladat
            int avgSum = 0;
            int avgCount = 0;
            foreach (int i in t) {
                if (i >= 4000 && i < 5000)
                {
                    avgSum += i;
                    avgCount++;
                }
            }
            Console.WriteLine($"A tömb 4000 és 5000 közötti értékeinek átlaga: {avgSum / avgCount}");

            // 65 többszöröse feladat
            int _65_idx = 0;
            while (_65_idx < 100 && t[_65_idx] % 65 != 0) _65_idx++;
            if (_65_idx < 100) Console.WriteLine("A tömbben szerepel olyan szám, " +
                $"ami 65 többszöröse, ez a szám: {t[_65_idx]}, indexe: {_65_idx}");
            else Console.WriteLine("A tömbben nem szerepel olyan szám, ami 65 többszöröse lenne.");

            // 3-as számjeggyel kezdődő számos feladat
            int startWithThree = 0;
            foreach (int i in t) if (i.ToString()[0] == '3') startWithThree++;
            Console.WriteLine($"A tömbben {startWithThree} db olyan szám van, " +
                "ami 3-as számjeggyel kezdődik.");

            // Órabéres feladat
            int oraberIdx = 0;
            while (oraberIdx < 100 && t[oraberIdx] < 2188) oraberIdx++;
            if (oraberIdx < 100) Console.WriteLine($"A tömbben a {oraberIdx}. elem forintban" +
                " értelmezve (szerintem) már elég egy kezdő junior szoftverfejlesztő órabérének.");
            else Console.WriteLine("A tömbben nincs olyan elem, ami forintban értelmezve" +
                " (szerintem) elég lenne egy kezdő junior szoftverfejlesztő órabérének.");

            // Kerek százasok feladat + annak kiírása a feladatnak megfelelően
            Console.Write("Kerek százasok a tömbben: ");
            int[] szazasok = new int[100];
            for (int i = 0; i < 100; i++)
            {
                if (t[i] % 100 == 0)
                {
                    szazasok[i] = t[i];

                    if (t[i].ToString()[0] == t[i].ToString()[1])
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.Write($"{szazasok[i]}");
                        Console.ResetColor();
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.ResetColor();
                        Console.Write($"{szazasok[i]} ");
                    }
                }
            }
            Console.Write("\n");

            // Születési éves feladat 
            // A születési évem: 2003 --> kerekítve 2005
            int birthDayIdx = 0;
            while (birthDayIdx < 100 && t[birthDayIdx] != 2005) birthDayIdx++;
            if (birthDayIdx < 100) Console.WriteLine("A tömbben szerepel az az elem, " +
                "ami a születési évem 5-el osztható számmá kerekítve. (2003->2005)");
            else Console.WriteLine("A tömbben nem szerepel az az elem, " +
                "ami a születési évem 5-el osztható számmá kerekítve. (2003->2005)");

            Console.ReadKey(true);
        }
    }
}
