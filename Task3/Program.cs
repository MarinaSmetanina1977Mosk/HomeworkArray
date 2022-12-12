Random random = new Random();
double[]arr=new double [7];
for(int i=0; i<arr.Length;i++)
    arr[i]=random.Next(0,100);
Console.WriteLine(string.Join(",",arr));
Console.WriteLine("Разница между максимальным и минимальным элементами:"+DiffMaxMin(arr));
double DiffMaxMin(double[] array)
{
    int i=1;
    double diff=0,max=array[0],min=array[0];
    for (i=1;i<array.Length;i++)
    {
        if (array[i]>max)
        max=array[i];
        if (array[i]<min)
        min=array[i];
    }
    diff=max-min;
    return diff;

}

