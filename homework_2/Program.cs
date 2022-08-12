// Напишите программу, которая на вход принмает два числа 
// и выдает, какое число большее, а какое меньшее
//пример:
//a=5; b=7 -> max =7
Console.WriteLine ("Какое число больше?");
Console.WriteLine ("Введите первое число:");
string? NumberString1 = Console.ReadLine ();
int number1 = int.Parse (NumberString1!);
Console.WriteLine ("Введите второе число:");
string? NumberString2 = Console.ReadLine ();
int number2 = int.Parse (NumberString2!);
if (number1>number2)
{
    Console.WriteLine ("Первое число "+number1+" больше второго "+number2);
}
else if (number2>number1)
{
Console.WriteLine ("Второе число "+number2+" больше первого "+number1);
}
else
{
    Console.WriteLine ("Введенные числа одинаковые");
}