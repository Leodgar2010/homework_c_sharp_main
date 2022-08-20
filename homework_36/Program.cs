// Задача 36: Задайте одномерный массив,
//  заполненный случайными числами. Найдите сумму 
//  элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
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
int SumOddArray (int [] arr)
{
    int result =0;
    for (int i=1; i<arr.Length; i+=2)
    {
        result += arr[i];
    }
    return result;
}
Console.WriteLine ("Какова сумма нечётных элементов данного массива?");
 Console.WriteLine ("Введите размер массива: ");
    var numberString = Console.ReadLine();
    int number = int.Parse(numberString!);
    Console.WriteLine ("Введите минимальное значение массива: ");
    var number2String = Console.ReadLine();
    int number2 = int.Parse(number2String!);
    Console.WriteLine ("Введите максимальное значение массива: ");
    var number3String = Console.ReadLine();
    int number3 = int.Parse(number3String!);
int [] array = CreateArray (number,number2,number3); 
Console.WriteLine ("Сумма нечетных элементов массива "+ PrintArrayNumbers(array) + " равна "+ SumOddArray(array)+".");