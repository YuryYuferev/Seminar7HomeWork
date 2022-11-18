//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. m = 3, n = 4.       0,5 7 -2 -0,2         1 -3,3 8 -9,9               8 7,8 -7,1 9

/*
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите количество строк двумерного массива:");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов двумерного массива:");
        int n = Convert.ToInt32(Console.ReadLine());
        double[,] twoDimArray = new double[m, n];
        Random rnd = new Random();
        void PrintArray(double[,] matr)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                Console.Write($"{matr[i, j]} "); 
                Console.WriteLine();
            }
        }
        void FillArray(double[,] matr)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                { matr[i, j] = Convert.ToDouble(rnd.Next(-100, 100) / 10.0); }
            }
        }
        FillArray(twoDimArray);
        Console.WriteLine( );
        PrintArray(twoDimArray);
    }
}
*/
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив: 1 4 7 2     5 9 2 3     8 4 2 4        1  7 -> такого числа в массиве нет
/*
internal class Program
{
    private static void Main(string[] args)
    {
        int rows = ReadInt("Введите индекс строки: ");
        int colums = ReadInt("Введите индекс столбца: ");
        int[,] numbers = new int[4, 5];
        FillArray2D(numbers);
        PrintArray2D(numbers);
        if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) 
        Console.WriteLine(numbers[rows, colums]);
        else 
        Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");

        void FillArray2D(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(1, 10);
                }
            }
        }
        void PrintArray2D(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        } 
        int ReadInt(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
*/
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив: 1 4 7 2                5 9 2 3                        8 4 2 4
/*
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("введите количество строк");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите количество столбцов");
        int m = Convert.ToInt32(Console.ReadLine());
        int[,] numbers = new int[n, m];
        FillArrayRandomNumbers(numbers);
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            double avarage = 0;
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                avarage = avarage + numbers[i, j];
            }
            avarage = avarage / n;
            Console.Write(avarage + "; ");
        }
        Console.WriteLine();
        PrintArray(numbers);
        void FillArrayRandomNumbers(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(0, 10);
                }
            }
        }
        void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
*/

