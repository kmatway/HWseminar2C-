// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число n = ");
int n = int.Parse(Console.ReadLine());

int result = (n/10)%10;
Console.WriteLine(result);
