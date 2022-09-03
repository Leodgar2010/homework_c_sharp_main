// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int Numbers(int m, int n)
{
    if (m-1 == n)
        return 0;     
    else
        return Numbers(m+1, n) + m;
}
Console.WriteLine(Numbers(1, 15));