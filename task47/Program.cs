//Задайте двумерный массив (вручную) размером m×n, заполненный вещественными числами.
Console.WriteLine("Введите размер массива числа m и n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double[,] array2d = new double[m, n];
Console.WriteLine("Введите элементы массива");
for (int i = 0; i < m; i++)
{

    for (int j = 0; j < n; j++)
    {
        array2d[i, j] = Convert.ToDouble(Console.ReadLine());
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