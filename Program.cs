Console.WriteLine("Введите начало координат a");
if (!int.TryParse(Console.ReadLine(), out int a))
{
    Console.WriteLine("Ошибка: Введите целое число.");
    return;
}
Console.WriteLine("Введите начало координат b");
if (!int.TryParse(Console.ReadLine(), out int b))
{
    Console.WriteLine("Ошибка: Введите целое число.");
    return;
}
Console.WriteLine("Введите значение шага h");
if (!int.TryParse(Console.ReadLine(), out int h))
{
    Console.WriteLine("Ошибка: Введите целое число.");
    return;
}

Console.WriteLine("------------------");
Console.WriteLine("|  i  |   sa[i]  |");
Console.WriteLine("------------------");

double[] sa = new double[b];
int kis = 0;
int v = 0;

for (int i = 0; i < b; i++)
{
    double z = Math.Cos(Math.Pow(i, 2)) + Math.Pow(Math.Sin(i), 2);
    sa[i] = z;

    Console.WriteLine($"| {i,3} | {sa[i],8:F3} |");

    v++;
}
Console.WriteLine("------------------");

for (int i = 1; i < sa.Length; i++)
{
    if ((sa[i] > 0 & sa[i - 1] < 0) || (sa[i] < 0 & sa[i - 1] > 0))
    {
        kis++;
    }
}


Console.WriteLine("Минимальное значение:");
Console.WriteLine($"{sa.Min():F3}");
Console.WriteLine("Максимальное значение:");
Console.WriteLine($"{sa.Max():F3}");
Console.WriteLine("Количество точек:");
Console.WriteLine(v);
Console.WriteLine("Количество раз когда функция меняет знак");
Console.WriteLine(kis);