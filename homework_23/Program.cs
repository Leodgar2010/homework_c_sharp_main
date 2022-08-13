// Напишите программу, которая принимает на 
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.WriteLine ("Вычисление кубов числе от 0 до введенного числа");
Console.WriteLine("Введите положительное число:");
var numberString = Console.ReadLine();
int number = int.Parse(numberString!);
int count = 1;
if (number <0)
{    
    number = number*-1;
    Console.WriteLine ("Вы ввели отрицательное число, что противоречит условию задачи. Введенное число было преобразовано в положительное по модулю.");
}
if (number ==0)
{    
    Console.WriteLine ("Вы ввели ноль. Программа ничего Вам не вычислит");
    return;
}
Console.Write ("Кубы все чисел от 1 до "+number+": ");
while (count <=number)
{
    Console.Write (Math.Pow(count, 3)+ " ");
    count += 1;
}