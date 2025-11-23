using Tyuiu.TumashenkinYA.Sprint4.Task5.V1.Lib;
DataService ds = new DataService();
Random rnd = new Random();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите количевство строк матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количевство столбцов матрицы: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] mtrx = new int[rows, columns];
Console.WriteLine("***************************************************************************");
for (int  i = 0;  i < rows;  i++)
{
    for (int j = 0; j < columns; j++)
    {
        mtrx[i, j] = rnd.Next(-9, 8);

    }
}
Console.WriteLine("\nМассив:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{mtrx[i, j]} \t");

    }
    Console.WriteLine();
}
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
int[,] res = ds.Calculate(mtrx);

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{res[i, j]} \t");

    }
    Console.WriteLine();
}

