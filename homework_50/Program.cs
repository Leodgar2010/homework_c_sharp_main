// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
int[,] CreateArrayWithRandomNumbers(int m, int n)
{
    int[,] result = new int[m, n];
    var random = new Random();
        for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
        result[i, j] = random.Next(1, 10);
    return result;
}
void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]}, ");
        Console.WriteLine();
    }
}
Console.WriteLine("Введите число строк (m)");
if (!int.TryParse(Console.ReadLine()!, out var m)) Console.WriteLine("Всё плохо");
Console.WriteLine("Введите число столбцов (n)");
if (!int.TryParse(Console.ReadLine()!, out var n)) Console.WriteLine("Всё плохо");
int[,] array = (CreateArrayWithRandomNumbers(m, n));
PrintArray(array);
Console.WriteLine("Введите строку элемента (первая строка 0, вторая 1 и так далее...): ");
if (!int.TryParse(Console.ReadLine()!, out var line)) Console.WriteLine("Всё плохо");
Console.WriteLine("Введите колонку элемента (первая колонка 0, вторая 1 и так далее...): ");
if (!int.TryParse(Console.ReadLine()!, out var column)) Console.WriteLine("Всё плохо");
if (line > m && column > n) Console.WriteLine("Введенные значения находятся за пределами массива");
else Console.WriteLine($"В строке {line} и колонке {column} данного массива находтся число {array[line, column]}.");