/*Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */


Main(args);

void Main(string[] args)
{
    Random rnd = new Random();
    int[] a = new int[10];
    int max = 0, min = 100;
    for (int i = 0; i < a.Length; i++) a[i] = rnd.Next(100);
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] > max) max = a[i];
        if (a[i] < min) min = a[i];
    }

    for (int i = 0; i < a.Length; i++) 
    Console.Write(" " + a[i]);
    Console.WriteLine();
    Console.WriteLine("Разница мак и мин:  " + (max - min));
    Console.ReadKey();
}
