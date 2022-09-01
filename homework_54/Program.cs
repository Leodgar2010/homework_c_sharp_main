// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки 
// двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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
void ArrayOrder(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++) // обход массива по строкам
    {
        for (int j = 0; j < arr.GetLength(1); j++) // обход массива по колонкам
        {
            int max = j; // присвоение звания максимального элемента данному индексу колонки.
            for (int k = j + 1; k < arr.GetLength (0); k++) // обход строки массива со смещением индекса на 1
            {
                if (arr[i,k] > arr[i,max]) // если элемент в данной ячейке больше чем элемент в предыдщей ячейке
                max = k; //  то звание максимального элемента переходит к этому элементу            
            }
            int temporary = arr[i,j]; //
            arr[i,j] = arr[i,max]; // меняем элементы местами 
            arr[i,max] = temporary;//
        }
    } 
}
int [,] array = CreateArrayWithRandomNumbers (4,4);
Console.WriteLine ("Заданный массив:");
PrintArray (array);
Console.WriteLine ("Заданный массив строки которого отсортированы по убыванию:");
ArrayOrder (array);
PrintArray (array);