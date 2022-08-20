// Задача 36: Задайте одномерный массив,
//  заполненный случайными числами. Найдите сумму 
//  элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] createArray()
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
int sum_odd_array (int [] arr)
{
    int result =0;
    for (int i=1; i<arr.Length; i+=2)
    {
        result += arr[i];
    }
    return result;
}
Console.WriteLine ("Какова сумма нечётных элементов данного массива?");
int [] array = createArray (); 
Console.WriteLine ("Сумма нечетных элементов массива "+ print_array_numbers(array) + " равна "+ sum_odd_array(array)+".");