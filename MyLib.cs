using System.Runtime;

public class MyLib
{
    /// <summary>
    /// Метод создание строкового массива
    /// </summary>
    /// <param name="str">количество строк</param>
    /// <param name="columns">количество столбцов</param>
    /// <returns></returns>
    public static string[,] CreateStringArray(int str, int columns)
    {
        return new string[str, columns];
    }

    public static void FillStringArray(string[,] array)
    {

        int sizeI = array.GetLength(0);
        int sizeJ = array.GetLength(1);
        for (int i = 0; i < sizeI; i++)
        {
            for (int j = 0; j < sizeJ; j++)
            {
                Console.WriteLine($"Введите слово на позицию [{i + 1} , {j + 1}]. После ввода слова нажмите Enter");
                array[i, j] = Console.ReadLine();

            }
        }
    }


    public static string PrintStringArray(string[,] array)
    {
        string word = string.Empty;
        Console.WriteLine("Массив:");
        for (int i = 0; i < array.GetLength(0); i++)
        {

            for (int j = 0; j < array.GetLength(1); j++)
            {
                word += array[i, j] + " ";

            }
            word += "\n";
        }
        return word;

    }

    public static int CountInStringArray(string[,] array)
    {
        int count = 0;
        string s = string.Empty;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                //if (array[i, j].Contains("!")) count++;
                s = array[i, j];
                for (int index = 0; index < s.Length; index++)
                {
                    if (array[i, j][index] == '!')
                    {
                        count++;
                        break;
                    }
                }
            }

        }
        return count;
    }
        // public static bool Inclusion(string str, string end)
        // {
            

        // }
    public static bool Inclusion2(string str, string end, out int pos)
    {
        pos = str.IndexOf(end);
        return pos != -1;

    }



    // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
    // m = 3, n = 4.
    // 0,5 7 -2 -0,2
    // 1 -3,3 8 -9,9
    // 8 7,8 -7,1 9
    //1. Метод создания массива mxn:
    // public static int[,] CreateMatrix(int m, int n)
    // {
    //     // Console.WriteLine("Введите количество строк: ");
    //     // m = int.Parse(Console.ReadLine());

    //     // Console.WriteLine("Введите количество столбцов: ");
    //     // n = int.Parse(Console.ReadLine());
    //     return new int[m, n];

    // }


    public static void FillMatrix(double[,] matr)
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {

                    matr[i, j] = new Random().NextDouble() + new Random().Next(-10, 10);//можно через NextDouble, можгно через new Random().Next(-10, 10)/10.00
                }
            }
        }

        public static void PrintFloatMatrix(double[,] matr)
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    Console.Write($"{matr[i, j]:0.00} " + "\t");
                }
                Console.WriteLine();
            }

        }

        public static string DateIndex(double[,] matr)
        {
            Console.WriteLine("Введите номер строки: ");
            int x = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Введите номер столбца: ");
            int y = int.Parse(Console.ReadLine()) - 1;

            string s = string.Empty;

            if ((x < matr.GetLength(0)) && (y < matr.GetLength(1)))
            {
                for (int i = 0; i < matr.GetLength(0); i++)
                {
                    for (int j = 0; j < matr.GetLength(1); j++)
                    {
                        s = $"Элемент в строке {i + 1} столбца {j + 1} --> {matr[x, y]:0.00}";
                    }
                }


            }
            else Console.WriteLine("такого элемента нет");


            return s;
        }
        public static void PrintIntArray(int[,] matr)
        {

            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    Console.Write($" {matr[i, j]}  ");
                }
                Console.WriteLine();
            }
        }
        public static void FillArray(int[,] matr)
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    matr[i, j] = new Random().Next(1, 10);
                }
            }
        }

        public static void MeanColumns(int[,] matr)
        {
            double mean = 0.0;
            double count = 0;
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                for (int i = 0; i < matr.GetLength(0); i++)
                {
                    count = count + matr[i, j];
                }
                mean = count / matr.GetLength(0);
                //Console.Write($"{(count / 3):0.0} ");
                Console.Write($"{mean:0.0} ");
                count = 0;


            }



        }











    }








