//Напишите программу, которая на вход принимает элемент в двумерном массиве, 
//и возвращает индекс этого элемента или же указание
//что такого элемента нет. Если элементов несколько, то выводим позицию каждого. 
//Двумерный массив задаётся на ваш выбор
Console.WriteLine("Введите размер массива m - n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите искомый элемент от 1 до 10");
int x = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
Random random = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = random.Next(1, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
int ind1 = 0, ind2 = 0;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (x == array[i, j])
        {
            ind1 = i;
            ind2 = j;
            Console.WriteLine($"Искомый элемент массива = {x} с адресом [{ind1},{ind2}]");
        }

    }
}
if (ind1==0 & ind2==0)
{
    Console.WriteLine("Такого элемента нет");
}

