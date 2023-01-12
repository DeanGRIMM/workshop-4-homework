// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// # 3, 5 -> 243 (3⁵)
// # 2, 4 -> 16
try
{
    Console.WriteLine("Введите целое число");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите целое число");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"число {a} в степени {b} равно {Prod(a, b)}");
}
catch
{
    Console.WriteLine("надо было вводить именно целое число");
}
int Prod(int a, int b)
{
    int p = a;
    for (int i=1; i<b; i++)
        p*=a;
    return p;
}
