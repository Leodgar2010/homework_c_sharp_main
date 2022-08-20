// Задача 34: Задайте массив заполненный 
// случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int [] CreateRandomArray3numberPositive (int number)
{
    var random = new Random();
    var result = new int[number];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(100,999);
    }
    return result;
}
string PrintArrayNumbers (int [] arr)
{
    string arrStr = string.Join(", ", arr);
    string result = string.Concat("[", arrStr, "]");
    return result;
}
int EvenNumbersInArray (int [] arr)
{    
    int count = 0;
    for (int i=0; i<arr.Length; i++)
    {
        if (arr[i]%2 == 0) count += 1;
    }
    return count;
} 
Console.WriteLine ("Сколько чётных чисел в массиве заполненном случайными положительными трёхзначными числами?");
Console.WriteLine ("Введите размер массива: ");
var numberString = Console.ReadLine();
int number = int.Parse(numberString!);
int [] array = CreateRandomArray3numberPositive(number);
PrintArrayNumbers (array);
Console.Write ("В массиве " + PrintArrayNumbers (array) + " количество чётных чисел - "+EvenNumbersInArray(array)+".");