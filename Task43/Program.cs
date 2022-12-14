//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//Точки для уравнений пользователь вводит с клавиатуры, можно через несколько ReadLine
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine ("Введите K1 для уравнения y=k1*x+b1:");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите B1 для уравнения y=k1*x+b1:");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите K2 для уравнения y=k2*x+b2:");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите B2 для уравнения y=k2*x+b2:");
double b2 = Convert.ToInt32(Console.ReadLine());
if (k1==k2&&b1==b2||k1==k2&&b1>b2||k1==k2&&b1<b2)
    Console.WriteLine("Прямые не пересекутся");
else
    Console.WriteLine($"две прямые пересекутся в точке с координатами X: {IntersectionPointX(k1,k2,b1,b2)}, Y: {IntersectionPointY(k1,k2,b1,b2)}");

double IntersectionPointX (double k1,double k2,double b1,double b2)
{
    double x = (-b2 + b1)/(-k1 + k2);
    return x;
}
double IntersectionPointY (double k1,double k2,double b1,double b2)
{
    double x = (-b2 + b1)/(-k1 + k2);
    double y = k2 * x + b2;
    return y;
}