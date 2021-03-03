using System;
using System.Collections.Generic;
using CV02_PR1_FILIP_SVOBODA;

namespace CV02_PR2_FILIP_SVOBODA
{
    class Program
    {
        public static List<int> list = new List<int>();
        public static Random rand = new Random();
        public static bool run = true;

        static void Main(string[] args)
        {
            while (run)
            {
                Console.Clear();

                Console.WriteLine("Menu");
                Console.WriteLine("1. Zadání prvku z klávesnice");
                Console.WriteLine("2. Vložení náhodných hodnot");
                Console.WriteLine("3. Výpis pole na obrazovku");
                Console.WriteLine("4. Utřídění pole vzestupně");
                Console.WriteLine("5. Utřídění pole sestupně");
                Console.WriteLine("6. Hledání minimálního prvku");
                Console.WriteLine("7. Hledání prvního výskytu zadaného čísla");
                Console.WriteLine("8. Hledání posledního výskytu zadaného čísla");
                Console.WriteLine("9. Konec programu");
                int option = Reading.ReadInt("\nZadejte možnost");

                switch (option)
                {
                    case 1:
                        Console.Clear();
                        list.Add(Reading.ReadInt("Hodnota"));
                        if (list.Count - 1 < 10)
                            Console.WriteLine($"Prvek {list[list.Count - 1]} vložen na index 0{list.Count - 1}");
                        else
                            Console.WriteLine($"Prvek {list[list.Count - 1]} vložen na index {list.Count - 1}");
                        Console.ReadKey();
                        break;
                    case 2:
                        for (int i = 0; i < 1000; i++)
                        {
                            list.Add(rand.Next(0, 9999));
                        }
                        break;
                    case 3:
                        Console.Clear();
                        PrintField();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Descending();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Ascending();
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        FindMinimum();
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        FirstOccurrence(Reading.ReadInt("hodnota"));
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.Clear();
                        LastOccurrence(Reading.ReadInt("hodnota"));
                        Console.ReadKey();
                        break;
                    case 9:
                        run = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Špatná hodnota vstupu.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public static void PrintField()
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (i < 10)
                {
                    Console.WriteLine("index 0" + i + ": " + list[i]);
                }
                else
                {
                    Console.WriteLine("index " + i + ": " + list[i]);
                }
            }
        }

        public static void Descending()
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            PrintField();
        }

        public static void Ascending()
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (list[j] < list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            PrintField();
        }

        public static void FindMinimum()
        {
            int min = int.MaxValue;
            int index = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (min > list[i])
                {
                    min = list[i];
                    index = i;
                }
            }

            Console.WriteLine($"Minimální prvek na indexu {index} s hodnotou {min}");
        }

        public static void FirstOccurrence(int value)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == value)
                {
                    Console.WriteLine($"První výskyt hodnoty {value} je na indexu {i}");
                    return;
                }
            }
        }

        public static void LastOccurrence(int value)
        {
            int index = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == value)
                {
                    index = i;
                }
            }

            Console.WriteLine($"Poslední výskyt hodnoty {value} je na indexu {index}");
        }
    }
}
