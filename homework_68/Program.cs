// Задача 68: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
int Ackerman(int m, int n)
{
    if (m == 0)
        return (n + 1);
    else if (n == 0)
        return Ackerman(m - 1, 1);
    else if ((m > 0) && (n > 0))
        return Ackerman(m - 1, Ackerman(m, n - 1));
    else
        return (n + 1);
}
Console.WriteLine(Ackerman(2, 3));
// P.S. В условии задачи ошибка. 
// По таблице значений функции Акермана 
// при m = 2 и n = 3 А(m,n) =9