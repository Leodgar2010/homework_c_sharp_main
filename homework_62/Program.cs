// Задача 62. Напишите программу, 
// которая заполнит спирально 
// массив 4 на 4.
// Например, на выходе 
// получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]}, ");
        Console.WriteLine();
    }
}
int[,] array = new int[4, 4];
int count = 1;
int line = array.GetLength(0);
int column = array.GetLength(1);
for (int i = 0; i < column; i++)// заполняем первую строку
{
    array [0,i] = count;
    count++;
}
column--;
for (int i = line-1; i > 0; i--) //заполняем последнюю колонку
{
    array [line-i,column] = count;
    count++;
}
line --;
for (int i = 1; i < column+1; i++)//заполняем нижнюю строку
{
      array [line, column-i] = count;
      count ++;
}
for (int i = 1; i < line; i++)//заполняем правую колонку
{
      array [line-i, 0] = count;
      count ++;
}
column++;
for (int i = column-1; i>1; i--)//заполняем вторую строку
{
      array [1, column -i] = count;
      count ++;
}
column--;
for (int i = 1; i<column; i++)//заполняем третью строку
{
      array [2, column - i] = count;
      count ++;
}

PrintArray(array);