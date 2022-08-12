// Напишите программу, которая на вход принмает число и
// выдает, является ли число четным (делится на два без
// остатка) Пример 4 -> да
Console.WriteLine ("Является ли число чётным?");
Console.WriteLine ("Введите число:");
string? NumberString1 = Console.ReadLine ();
int number1 = int.Parse (NumberString1!);
if (number1%2>0)
{
Console.WriteLine ("Число нечётное");
}
else
{
Console.WriteLine ("Число чётное");
}