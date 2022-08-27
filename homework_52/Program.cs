// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int[,] CreateArrayWithRandomNumbers(int m, int n)
{
    int[,] result = new int[m, n];
    var random = new Random();
        for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
        result[i, j] = random.Next(1, 10);
    return result;
}
void PrintArrayTwo(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]}, ");
        Console.WriteLine();
    }
}
double [] ArithmeticMean (int [,] array)
{
    double sum = 0;
    double [] result = new double [array.GetLength(0)];
    for (int j = 0; j < array.GetLength(0); j++)
    {    
            for (int i = 0; i < array.GetLength(1); i++) 
             {
                sum += array [i,j];
             }
    result [j] = sum/array.GetLength (1);
    sum = 0;
    }
    return result;
}
void PrintArrayOne (double [] arr)
{
    for (int i = 0; i < arr.Length; i++)       
    {
        Console.Write ($"{arr[i].ToString ("F2")}");
        if (i == arr.Length-1) Console.Write ("");
        else Console.Write (", ");
    }
}
Console.WriteLine("Введите число строк (m)");
if (!int.TryParse(Console.ReadLine()!, out var m)) Console.WriteLine("Всё плохо");
Console.WriteLine("Введите число столбцов (n)");
if (!int.TryParse(Console.ReadLine()!, out var n)) Console.WriteLine("Всё плохо");
int[,] array = (CreateArrayWithRandomNumbers(m, n));
Console.WriteLine ("В заданном массиве:");
PrintArrayTwo(array);
Console.Write ($"Среднее арифмитеческое каждого столбца: ");
PrintArrayOne (ArithmeticMean (array));

