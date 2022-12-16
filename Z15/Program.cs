// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число n = ");
int n = int.Parse(Console.ReadLine());

if (n == 6 || n == 7)
{
   Console.WriteLine("да"); 
}
if (n < 6)
{
    Console.WriteLine("нет"); 
}
if (n > 7)
{
    Console.WriteLine("некорректное число"); 
}
