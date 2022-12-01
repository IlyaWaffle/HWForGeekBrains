int a = 0;
int b = a;

Console.Write($"Введите первое число: ");
bool flag = int.TryParse(Console.ReadLine()!, out a);
Console.Write($"Введите второе число: ");
bool flag2 = int.TryParse(Console.ReadLine()!, out b);

Console.Write($"{a} больше {b}");