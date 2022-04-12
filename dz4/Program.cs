using System;

namespace dz4._1
{
    //Выведите на экран матрицу заданного размера и заполните её случайными числами. Детальный алгоритм работы приложения:
    //
    //Сначала пользователю предлагается ввести количество строк в будущей матрице.
    //Затем — ввести количество столбцов в будущей матрице.
    //После того, как данные будут получены, нужно создать в памяти матрицу заданного размера.
    //Используя Random, заполнить матрицу случайными целыми числами.
    //Вывести полученную матрицу на экран.
    //Вывести суммы всех элементов этой матрицы на экран отдельной строкой.

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк в матрице: ");
            byte str = byte.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов в матрице: ");
            byte col = byte.Parse(Console.ReadLine());

            int[,] matrix = new int[str, col];
            int sum = 0;
            Random rnd = new Random();

            Console.WriteLine($"\nМатрица {col}x{str}:");
          
            for (int i = 0; i < matrix.GetLength(0); i++)
            {              
                for (int j = 0; j < matrix.GetLength(1); j++)
                {              
                    matrix[i, j] = rnd.Next(-50, 50);
                    sum += matrix[i, j];
                    Console.Write($"{matrix[i, j],3} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nСумма элементов матрицы: {sum}");
            Console.ReadKey();
        }
    }
}

