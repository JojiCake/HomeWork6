Console.WriteLine("Введите значение k1: ");
string? numberString1 = Console.ReadLine();
int k1 = int.Parse(numberString1!);

Console.WriteLine("Введите значение b1: ");
string? numberString2 = Console.ReadLine();
int b1 = int.Parse(numberString2!);

Console.WriteLine("Введите значение k2: ");
string? numberString3 = Console.ReadLine();
int k2 = int.Parse(numberString3!);

Console.WriteLine("Введите значение b2: ");
string? numberString4 = Console.ReadLine();
int b2 = int.Parse(numberString4!);

if(k1 == k2)
    {
        Console.WriteLine("Точек пересечения не существует");
    }
else
    {
    double x = (b2 - b1) / (k1 - k2); double fX = k1 * x + b1;
    Console.WriteLine(x);
    }

