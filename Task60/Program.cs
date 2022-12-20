/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
int a = 2, b = 2, c = 2;
int FirstNumber = 10, SecondNumber = 100;
int[] numbers = new int[SecondNumber - FirstNumber];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = FirstNumber + i;
}
for (int i = 0; i < numbers.Length - 1; i++)
{
    int index = new Random().Next(i + 1, numbers.Length);
    int temp = numbers[i];
    numbers[i] = numbers[index];
    numbers[index] = temp;
}
int[,,] TripleMatrix = new int[a, b, c];
int count = 0;
for (int i = 0; i < a; i++)
{
    for (int j = 0; j < b; j++)
    {
        for (int z = 0; z < c; z++)
        {
            TripleMatrix[i, j, z] = numbers[count];
            Console.Write($" {TripleMatrix[i, j, z]}({i},{j},{z})");
            count++;
        }
        Console.WriteLine();
    }
}