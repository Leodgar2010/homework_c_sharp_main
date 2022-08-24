// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

string PrintArrayNumbers (int [] arr)
{
    string arrStr = string.Join(", ", arr);
    string result = string.Concat("[", arrStr, "]");
    return result;
}
int HowManyNumberLargerThan0 (int [] arr)
{
    int count = 0;
    for (int i=0; i<arr.Length;i++)
    {
        if (arr[i] > 0) count ++; 
    }
    return count;
}
Console.WriteLine ("Введите сколько всего будет чисел цифрами: ");
if (!int.TryParse (Console.ReadLine(), out var m)) Console.WriteLine ("Вам нужно было ввести число. Вашему параметру присвоено значение 0.");
int [] array = new int [m]; 
string a = string.Empty;
int i = 0;
while (i < m) 
{Console.WriteLine ("Введите число: ");
    if (!int.TryParse (Console.ReadLine(), out var number))
    { 
        Console.WriteLine ("Вам нужно было ввести число. Повторите ввод.");
    }
    else 
    {
        array [i] = number;
        i++;
    }
}
Console.WriteLine (m);
Console.WriteLine ($"В следующем наборе чисел {PrintArrayNumbers (array)} количесто чисел больше ноля равно {HowManyNumberLargerThan0 (array)}.");