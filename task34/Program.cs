/*  Задайте массив заполненный случайными положительными трёхзначными 
числами. Напишите программу, которая покажет количество чётных чисел в
 массиве.
 [345, 897, 568, 234] -> 2
  */


Console.WriteLine("Введите размер массива");
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];

Random();
PrintCount();

void Random()
{
Random rnd = new Random();
for (int i = 0; i < arr.GetLength(0); i++)
{
        arr[i] = rnd.Next(100, 1000);
Console.Write($"{arr[i]} ");
}
}
void PrintCount()
{
int x,y;
x = y = 0;
for (int i = 0; i < arr.GetLength(0); i++)
    
        if (arr[i] % 2 == 0)
            x++;
y = arr.Length - x;
Console.WriteLine($"Количество четных: {x}");
}
