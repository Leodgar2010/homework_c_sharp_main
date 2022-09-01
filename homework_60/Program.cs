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
    var random = new Random();
    int temp = 0;
    int[] source = new int[89];
    source[0]=random.Next(10, 100);
    for (int i = 1; i < source.Length; i++)
    {
        temp = source [i-1];
        source [i] = random.Next(10, 100);
        for (int j = 0; j < source.Length; j++)
        {
            while (temp == source[j])
                source[j] = random.Next(10, 100);
        }
        Console.Write ($"{source[i]}, ");
    }
    Console.WriteLine ();
    int a=0;
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            {
                result [i,j,k]=source [a];
                a++;
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
                for (int k = 0; k < array.GetLength(2); k++) Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
                Console.WriteLine();
            }
        }
    }

    int[,,] array = CreateArrayWithRandomNumbersThree(3, 3, 3);

    PrintArrayThree(array);
