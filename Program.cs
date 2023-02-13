/*Задача 8: Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

int N;
Console.Write("Введите число: ");
bool flag = int.TryParse(Console.ReadLine()!, out N);
if (flag)
{
    if (N > 0)
    {
        for (int i2 = 2; i2 <= N; i2 += 2)
            Console.Write($" {i2} ");
    }
    else
    {
        for (int i2 = -2; i2 >= N; i2 -= 2)
            Console.Write($" {i2} ");
    }
}
else
    Console.Write("Неверный ввод");