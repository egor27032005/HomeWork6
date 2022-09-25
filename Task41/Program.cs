Console.Clear();
Console.Write("Введите число m: ");
int m =Convert.ToInt32(Console.ReadLine());
int sum=0;
int ConvertNumber(int i)
{
while(m>i)
{
    Console.Write("Введите число: ");
    int x =Convert.ToInt32(Console.ReadLine());
    i++;
    if (x>0)
    sum++;
}
return sum;
}
Console.WriteLine( "Положительных чисел: " + ConvertNumber(sum));