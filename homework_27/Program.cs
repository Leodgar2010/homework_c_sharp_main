// Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int AllDigitSum (string numberString)
{
    int number_lenght = numberString.Length;
    int number = int.Parse (numberString!);
    int result = (number/1)%10;
    int intPow =0;
    for (int i=1; i<number_lenght; i++)
        {
            intPow=((int) (Math.Pow(10,i)));
            result = result+ (number/(1*intPow))%10;
 
        }
    return result;
}
Console.WriteLine ("Выдаём сумму цифр во введенном числе");
Console.WriteLine ("Введите число:");
string? numString = Console.ReadLine();
Console.WriteLine ("Cумма цифр в данном числе: " + (AllDigitSum (numString!)));
// подготовлено для проверки
