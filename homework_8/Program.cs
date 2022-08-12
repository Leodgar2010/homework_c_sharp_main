// Напишите программу, которая на вход принмает число (N)
// а на выходе показывает все чётные значения от 1 до N
// пример: 5-> 2,4
Console.WriteLine ("Все чётные числа от единицы до введённого числа?");
Console.WriteLine ("Введите число:");
string? NumberString1 = Console.ReadLine ();
int number1 = int.Parse (NumberString1!);
Console.WriteLine ("Чётные числа от единицы до "+ number1 +":");
int CountNumber = 0;
while (CountNumber <= number1)
{
    CountNumber +=2;
    if (CountNumber <= number1)
    {
       Console.Write (CountNumber + " "); 
    }
}
