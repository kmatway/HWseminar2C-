// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//что третьей цифры нет.

Console.WriteLine("Введите число n = ");
int n = int.Parse(Console.ReadLine());

if (n > 99)
{
    while (n >= 1000)
    {
        n = n/10;
    }
    int result = n%10;
    Console.WriteLine("Третья цифра числа =" + result);
}
else
{
 Console.WriteLine("Третьей цифры нет");
}
