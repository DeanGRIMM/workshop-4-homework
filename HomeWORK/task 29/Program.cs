// Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры 
// и далее выводит массив на экран в одну строку.
Console.WriteLine("Введите размер массива");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
void FillArray(int[]col)
{
    int length = col.Length;
    int index = 0;
    while (index<length)
    {
        Console.WriteLine("Введите целое число");
        int num = Convert.ToInt32(Console.ReadLine());        
        col[index] = num;        
        index++;
    }
}
void PrintArray(int[]col1)
{
    int count = col1.Length;
    int position = 0;
    while (position<count)
    {
        Console.Write(col1[position]);
        Console.Write(" ");
        position++;
    }
}

int[] array = new int [n];
FillArray(array);
Console.WriteLine();
PrintArray(array);

