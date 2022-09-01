// Задача 60. ...Сформируйте трёхмерный массив 
// из неповторяющихся двузначных чисел. Напишите 
// программу, которая будет построчно выводить 
// массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
int[,,] CreateArrayWithRandomNumbersThree(int m, int n, int t)
{
    int[,,] result = new int[m, n, t];
    int a = 0;
    bool x = true;
    var random = new Random();
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            {
                // result[i, j, k] = random.Next(10, 99);
                a = random.Next(10, 99);
                result[i, j, k] = a;
                while (x == false)
                {
                    foreach (int number in result)
                    {
                        if (number == a)
                        {
                            x = false;
                            a = random.Next(10, 99);
                            break;
                        }
                        else
                        {
                            x = true;
                        }
                    }
                    result[i, j, k] = a;
                }
            }
        }
    }
    return result;
}

void PrintArrayThree(int[,,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++) Console.Write($"{array[i, j, k]} [{i},{j},{k}] ");
            Console.WriteLine();
        }
    }
}
int[,,] array = CreateArrayWithRandomNumbersThree(5, 5, 5);
PrintArrayThree(array);
