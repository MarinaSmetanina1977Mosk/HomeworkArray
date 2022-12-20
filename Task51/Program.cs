// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Сумма элементов главной диагонали: 1+9+2 = 12
Console.WriteLine("Ведите числа m и n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int [,] Array2d = new int[m, n];
Console.WriteLine("Введите элементы массива в одну строку через запятую");
for (int i = 0; i < m; i++)
{
    string text = Console.ReadLine();
    string[] Array = text.Split(",");
    for (int j = 0; j < n; j++)
    {
        Array2d[i,j]=Convert.ToInt32(Array[j]);
        if (i % 2 == 1 && j % 2 == 1)
            Array2d[i, j] = Array2d[i, j] * Array2d[i, j];
    }
}
void Vivod (int [,]Array2d)
{
for (int i = 0; i < Array2d.GetLength(0); i++)
{
    for (int j = 0; j < Array2d.GetLength(1); j++)
    {
        Console.Write(Array2d[i,j]+" ");
    }
    Console.WriteLine();
}
}

Vivod(Array2d);


