/*Задача 10: Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.Clear();

Console.Write("Введите трехзначное число: ");

int n = (Convert.ToInt32(Console.ReadLine()));

while (Math.Abs(n) < 100 || Math.Abs(n) > 999)
{
    Console.Write("Неверно. Введите трехзначное число: ");
    n = Convert.ToInt32(Console.ReadLine());
}
int a = n;

Console.WriteLine($"Вторая цифра числа: {a}, равна: {Math.Abs((n / 10) % 10)}");