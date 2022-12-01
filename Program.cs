int a = 0;
int b = a;

Console.Write($"Введите первое число: ");
bool flag = int.TryParse(Console.ReadLine()!, out a);
Console.Write($"Введите второе число: ");
bool flag2 = int.TryParse(Console.ReadLine()!, out b);

if (flag && flag2)
{
    Console.Write($"{a} + {b} = {a + b}");
}
else
{
    Console.Write($"Неверный ввод\n");
}
