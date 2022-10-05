/*Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

Console.Clear();
Console.WriteLine("Введите размер массива: ");
int num = int.Parse(Console.ReadLine());
int[] a = new int[num];
int sum = 0;
FillArray(a);

void FillArray(int[] a)
{
    Random rand = new Random();

    for (int i = 0; i < num; i++)
    {
        a[i] = rand.Next(0, 1000);
        Console.Write($" {a[i]} ");
    }
}
Console.WriteLine();

for (int i = 0; i < num; i++)
{
    if (i % 2 != 0)
        sum += a[i];
}
Console.WriteLine($"Сумма элементов с нечетными позициями: {sum}");