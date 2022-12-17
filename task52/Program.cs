// Задайте двумерный массив (вручную) из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
Console.WriteLine("Введите размер массива числа m и n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array2d = new int[m, n];
Console.WriteLine("Введите элементы массива");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array2d[i, j] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(+array2d[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();
for (int j = 0; j < n; j++)
{
    double sum = 0;
    for (int i = 0; i < m; i++)
    {
        sum += array2d[i, j];
    }
    Console.Write($"{sum / m} ");
}
