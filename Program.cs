int a = 0;
int b = a;

// Console.Write($"Введите первое число: ");
// int.TryParse(Console.ReadLine()!, out a);
// Console.Write($"Введите второе число: ");
// int.TryParse(Console.ReadLine()!, out b);

int index = 0;

while (index < 5)
{
    Console.Write($"{index} ");
    index++;
}

Console.Write($"\n");

for (int index2 = 0; index2 < 5; index2++)
{
    Console.Write($"{index2} ");
}