// Создать приложение по обработке двумерного массива строк.
// Если сложно, массив может сделать одномерным

// Приложение позволяет сгенерирвать массив и показать сколько в этом массиве "слов" содержащих восклицательный знак ("!")

// Требование: минимум 4 метода, IndexOf использовать нельзя

//1. Инициализация массива двумерного:
//2. Заполнение массива словами
//3. Метод вывода массива
//4. Сколько слов содержит восклицательный знак!

string[,] array = MyLib.CreateStringArray(2,3);
 MyLib.FillStringArray(array);
 string text = MyLib.PrintStringArray(array);
Console.WriteLine(text);
Console.WriteLine($"Количество слов содержащих восклицацельный знак{MyLib.CountInStringArray(array)}");


// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
 Console.WriteLine("Введите количество строк: ");
 int m = int.Parse(Console.ReadLine());

 Console.WriteLine("Введите количество столбцов: ");
 int n = int.Parse(Console.ReadLine());

 double[,] matrix = new double[m, n];

MyLib.FillMatrix(matrix);
 MyLib.PrintFloatMatrix(matrix);




// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


Console.WriteLine($"{MyLib.DateIndex(matrix)}");



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int[,] matr = new int[3, 4];
MyLib.FillArray(matr);
MyLib.PrintIntArray(matr);

//Console.WriteLine($"{
MyLib.MeanColumns(matr);

int x;
Console.WriteLine($"{MyLib.Inclusion2("adcdf", "fr", out x)}");
Console.WriteLine(x);

