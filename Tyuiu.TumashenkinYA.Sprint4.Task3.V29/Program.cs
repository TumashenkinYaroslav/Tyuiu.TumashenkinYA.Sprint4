using Tyuiu.TumashenkinYA.Sprint4.Task3.V29.Lib;
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
Console.WriteLine("* статическими значениями в диапазоне от 5 до 9. Найдите произведение     *");
Console.WriteLine("* элементов в первом столбце массива.                                     *");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
DataService ds = new DataService();
int[,] mas = new int[5, 5] { { 9, 9, 8, 6, 9 },
                                        { 5, 8, 8, 8, 7 },
                                        { 6, 5, 9, 7, 9 },
                                        { 7, 7, 9, 7, 8 },
                                        { 8, 5, 8, 5, 5 } };

Console.WriteLine("Массив");
int rows = mas.GetUpperBound(0) + 1;
int cols = mas.Length / rows;

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write($"{mas[i, j]}\t");

    }
    Console.WriteLine();
}



Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
int res = ds.Calculate(mas);
Console.WriteLine("Произведение элементов первого столбца = " + res);

Console.ReadLine();
