using System;
namespace TAM_Task_07
{
    class Program
    {
        static Random rnd = new Random();
        static void Shuffle(ref int[] mas) // Новенькая вкусная функция Shuffle
        {
            Random rnd = new Random();
            for (int i = mas.Length - 1; i >= 1; i--)
            {
                int j = rnd.Next(i + 1);
                int boofer = mas[j];
                mas[j] = mas[i];
                mas[i] = boofer;
            }
        }
        static void mas(int num, ref int[] mas1, ref int[] mas2) // Создание массива
        {
            mas1 = new int[num];
            mas2 = new int[num];

            for (int i = 0; i < num; i++)
            {
                mas1[i] = rnd.Next(0, 100);
                mas2[i] = mas1[i];
            }
        }
        static void masOut(int[] mas) // Вывод массива
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
            }
        }
        static void Main(string[] args)
        {
            int num;
            int[] mas1 = new int[0]; // Объявление массива
            int[] mas2 = new int[0];
            ConsoleKeyInfo key;

        restart:
            Console.Write("Введите размер массива: "); // Вворд размерности массива
            num = Convert.ToInt32(Console.ReadLine());
            if ((num <= 0) || (num > 20)) goto restart;
            mas(num, ref mas2, ref mas1);

            do
            {

                Console.Clear();
                Console.WriteLine("============================================================================");
                Console.WriteLine(@"
                    _____ _    _ _    _ ______ ______ _      ______ 
                   / ____| |  | | |  | |  ____|  ____| |    |  ____|
                  | (___ | |__| | |  | | |__  | |__  | |    | |__   
                   \___ \|  __  | |  | |  __| |  __| | |    |  __|  
                   ____) | |  | | |__| | |    | |    | |____| |____ 
                  |_____/|_|  |_|\____/|_|    |_|    |______|______|

                ");
                Console.WriteLine("============================================================================");

                Console.WriteLine("\n\nEnter - Использовать функцию Shuffle()");
                Console.WriteLine("Esc - Завершение программы.");
                Console.WriteLine("Исходный массив: ");
                masOut(mas1);
                Console.Write('\n');

                Shuffle(ref mas2);
                Console.WriteLine("Массив пропущенный через Shuffle(): ");
                Console.Write('\n');

                masOut(mas2);
                key = Console.ReadKey(true);

            } while (key.Key != ConsoleKey.Escape); // Конец программы

            Console.Clear();
            Console.WriteLine("============================================================================");
            Console.WriteLine(@"
                      ______ _   _ _____  ______ _____  
                     |  ____| \ | |  __ \|  ____|  __ \ 
                     | |__  |  \| | |  | | |__  | |  | |
                     |  __| | . ` | |  | |  __| | |  | |
                     | |____| |\  | |__| | |____| |__| |
                     |______|_| \_|_____/|______|_____/ 

            ");
            Console.WriteLine("============================================================================");
        }
    }
}
