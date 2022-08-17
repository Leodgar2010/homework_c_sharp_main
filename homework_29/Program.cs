// Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
string [] New_List_8_elements () 
{ 
    string [] result = new string [8
    ];
    for (int i=0; i<8;i++)
    {   
        Console.WriteLine ("Введите элемент:");
        string? Element = Console.ReadLine ();
        result [i] = (Element!);
        Console.WriteLine ("Чтобы закончить ввод элементов массива нажмите пробел и enter");
        Console.WriteLine ("Чтобы продолжить нажмите enter");
        string? EndCondition = Console.ReadLine()!;
        if (EndCondition==" ") break;
        else continue;
    }
    return result;
}
void PrintList ( string [] a)
{
Console.Write ("[");
for (int i=0; i<8;i++)
{
    if (a[i] == null) 
    {
        Console.Write ("]");
        break;
    }
    else if (i==0) Console.Write (a [i]);
    else if ((i>=1)&& (i<7)) Console.Write (", " + a[i]);
    else
    { 
        Console.Write (", "+ a[i]+ "]");
        break;
    }
}
}
Console.WriteLine ("Задаем массив из 8 элементов и выводим его на экран");
string [] list = New_List_8_elements ();
PrintList (list);
// подготовлено для проверки



    
