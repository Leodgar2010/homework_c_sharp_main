// Напишите программу, которая принмает на вход три числа
//и выдает максимальное из этих чисел
//Пример: 2,3,7 -> 7
Console.WriteLine ("Какое число максимальное?");
Console.WriteLine ("Введите первое число:");
string? NumberString1 = Console.ReadLine ();
int number1 = int.Parse (NumberString1!);
Console.WriteLine ("Введите второе число:");
string? NumberString2 = Console.ReadLine ();
int number2 = int.Parse (NumberString2!);
Console.WriteLine ("Введите третье число:");
string? NumberString3 = Console.ReadLine ();
int number3 = int.Parse (NumberString3!);
int MaxNumber = number1;
if (MaxNumber<number2)
{
    MaxNumber=number2;
}
if (MaxNumber<number3)
{
    MaxNumber=number3;
}
Console.WriteLine ("Максимальное число: " + MaxNumber);