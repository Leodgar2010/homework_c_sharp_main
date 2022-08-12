// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine ("Введите цифру обозначающую день недели. Проверим является ли этот день выходным: ");
string? numberString1 = Console.ReadLine ();
int number1=  int.Parse (numberString1!);
if (number1 == 6 || number1==7)
{
    Console.WriteLine ("да");
}
else if (number1 < 1 || number1 >7)
{
    Console.WriteLine ("Введенная цифра не обозначает день недели");
}
else    
    Console.WriteLine ("нет");