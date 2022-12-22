/* Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15-> 120
M = 4; N = 8. -> 30*/

Console.Write("Enter Number M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Number N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

void GapNumberSum(int numberM, int numberN, int sum)
{
    if (numberM > numberN)
    {
        Console.WriteLine($"Sum of natural elements between M and N: {sum}");
        return;
    }
    sum = sum + (numberM++);
    GapNumberSum(numberM, numberN, sum);
}
GapNumberSum(numberM, numberN, 0);
