// Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine ("Возводим первое число в степень равную второму числу");
Console.WriteLine ("Введите первое число:");
string? number1String = Console.ReadLine();
int number1 = int.Parse(number1String!);
Console.WriteLine ("Введите второе число:");
string? number2String = Console.ReadLine();
int number2 = int.Parse(number2String!);
int result = number1;
for (int i=1; i<number2; i++)
{
    result = result*number1;
}
Console.WriteLine (number1+ " в степени "+ number2+" = "+ result);

