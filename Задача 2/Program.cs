// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine()!);
if (a > b)
{
    int max = a;
    int min = b;
    Console.WriteLine($"Максимальное число: {max}");
    Console.WriteLine($"Минимальное число: {min}");
}
else
{
    int max = b;
    int min = a;
    Console.WriteLine($"Максимальное число: {max}");
    Console.WriteLine($"Минимальное число: {min}");
}
