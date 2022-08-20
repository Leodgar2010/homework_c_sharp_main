// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и
// минимальным элементов массива.
// [3 7 22 2 78] -> 76
int [] createArray()
{
    Console.WriteLine ("Введите размер массива: ");
    var numberString = Console.ReadLine();
    int number = int.Parse(numberString!);
    Console.WriteLine ("Введите минимальное значение массива: ");
    var number2String = Console.ReadLine();
    int number2 = int.Parse(number2String!);
    Console.WriteLine ("Введите максимальное значение массива: ");
    var number3String = Console.ReadLine();
    int number3 = int.Parse(number3String!);
    var random = new Random();
    var result = new int[number];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(number2,number3);
    }
    return result;
}
string print_array_numbers (int [] arr)
{
    string arrStr = string.Join(", ", arr);
    string result = string.Concat("[", arrStr, "]");
    return result;
}
int min_array (int []arr)
{
    int result=arr [0];
    for (int i=1; i<arr.Length; i++) if (arr[i] < result) result = arr[i];
    return result;
}
int max_array (int []arr)
{
    int result=arr [0];
    for (int i=1; i<arr.Length; i++) if (arr[i] > result) result = arr[i];
    return result;
}
Console.WriteLine ("Разница между максимальным и минимальным элемнтом заданного массива");
int []array=createArray();
Console.WriteLine ("В массиве "+ (print_array_numbers(array)) + " разница между максимальным элементом массива "+ max_array (array)
+" и минимальным элементом массива "+ min_array(array) + " равна " + (max_array (array)-min_array (array)));  
