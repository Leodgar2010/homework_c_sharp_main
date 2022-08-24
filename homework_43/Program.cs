// Задача 43: Напишите программу, которая найдёт 
// точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine ("Введите число b1: ");
var b1String = Console.ReadLine();
double b1 = double.Parse(b1String!);
Console.WriteLine ("Введите число k1: ");
var k1String = Console.ReadLine();
double k1 = double.Parse(k1String!);
Console.WriteLine ("Введите число b2: ");
var b2String = Console.ReadLine();
double b2 = double.Parse(b2String!);
Console.WriteLine ("Введите число k2: ");
var k2String = Console.ReadLine();
double k2 = double.Parse(k2String!);
// приравниваем два выражения чтобы вычислить x.
// k1*x + b1 = k2*x+b2
// x*(k1-k2) = b2-b1 
// x = (b2-b1)/(k1-k2)
double x = (b2-b1)/(k1-k2);
double y = k1*x+b1;
Console.WriteLine ($"Координаты точки пересечения двух прямых заданных уравнениями (y={k1}*x + {b1}) и (y={k2}*x+{b2}) следующие ({x};{y})");


    
