// Напишите программу, которая принимает на вход число и выдаёт
// сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
try
{
    Console.WriteLine("Введите целое число");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"сумму цифр в числе {num} равно {Sum(num)}");
}
catch
{
    Console.WriteLine("надо было вводить именно целое число");
}
int Sum(int num)
{
    int sum = 0;
    for (int n = num; n > 0; n /= 10)
        sum += n % 10; 
    return sum;
}

