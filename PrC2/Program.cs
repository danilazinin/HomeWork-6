Console.Clear();
Console.WriteLine("Введите b1");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите k1");
int k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b2");
int b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите k2");
int k2 = int.Parse(Console.ReadLine());

double Xmethod(int b1, int b2, int k1, int k2)
{
    double x = 0;
    double num = 0;
    double num2 = 0;

    num  = b1 - b2;
    num2 = k2 - k1;

    x = num/num2;
    return x;
}

double x =  Xmethod(b1, b2, k1, k2);

double Ymethod(int b1, int k1, double x)
{
    double y = 0;
    y = k1*x + b1;
    return y;
}

Console.WriteLine($" ({Xmethod(b1, b2, k1, k2)}, {Ymethod(b1, k1, x)} )");


