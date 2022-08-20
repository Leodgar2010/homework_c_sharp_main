// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и
// минимальным элементов массива.
// [3 7 22 2 78] -> 76
int[] CreateArray(int size, int min , int max)
{
    var random = new Random();
    var result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(min,max);
    }
    return result;
}
string PrintArrayNumbers (int [] arr)
{
    string arrStr = string.Join(", ", arr);
    string result = string.Concat("[", arrStr, "]");
    return result;
}
int MinArray (int []arr)
{
    int result=arr [0];
    for (int i=1; i<arr.Length; i++) if (arr[i] < result) result = arr[i];
    return result;
}
int MaxArray (int []arr)
{
    int result=arr [0];
    for (int i=1; i<arr.Length; i++) if (arr[i] > result) result = arr[i];
    return result;
}
Console.WriteLine ("Разница между максимальным и минимальным элемнтом заданного массива");
Console.WriteLine ("Введите размер массива: ");
    var numberString = Console.ReadLine();
    int number = int.Parse(numberString!);
    Console.WriteLine ("Введите минимальное значение массива: ");
    var number2String = Console.ReadLine();
    int number2 = int.Parse(number2String!);
    Console.WriteLine ("Введите максимальное значение массива: ");
    var number3String = Console.ReadLine();
    int number3 = int.Parse(number3String!);
int []array=CreateArray();
Console.WriteLine ("В массиве "+ (PrintArrayNumbers(array)) + " разница между максимальным элементом массива "+ MaxArray(array)
+" и минимальным элементом массива "+ MinArray(array) + " равна " + (MaxArray (array)- MinArray (array)));  
