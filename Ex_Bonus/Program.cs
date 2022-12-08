/*
Задана последовательность натуральных чисел, завершающаяся числом 0. 
Требуется определить значение второго по величине элемента в этой последовательности,
то есть элемента, который будет наибольшим, 
если из последовательности удалить наибольший элемент.
*/

Console.Clear();
Console.WriteLine("Введите число или введите «0» для конца цикла.");
int n = Convert.ToInt32(Console.ReadLine());
int max = -1;
int smax = -2;
int temp = 0;
while (n != 0)
{ 
    n = Convert.ToInt32(Console.ReadLine());
    if (smax < n) smax = n;
    if (smax > max)
        {
            temp = max;
            max = smax;
            smax = temp;  
        }  
}
Console.WriteLine ($"Второе максимальное число = {smax}");
Console.WriteLine("Конец");