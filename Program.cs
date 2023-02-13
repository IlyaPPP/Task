/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

int number;
Console.Write("Введите первое число: ");
int.TryParse(Console.ReadLine()!, out number);

int number2;
Console.Write("Введите второе число: ");
int.TryParse(Console.ReadLine()!, out number2);

int number3;
Console.Write("Введите третье число: ");
int.TryParse(Console.ReadLine()!, out number3);

if (number > number2 && number > number3)
    Console.Write($"Максимальное число - {number}");

else if (number2 > number && number2 > number3)
    Console.Write($"Максимальное число - {number2}");
else
    Console.Write($"Максимальное число - {number3}");