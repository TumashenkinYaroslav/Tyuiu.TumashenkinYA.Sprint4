using Tyuiu.TumashenkinYA.Sprint4.Task7.V21.Lib;
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дана строка из одноразрядных цифр 425963128528. Преобразуйте ее в       *");
Console.WriteLine("* матрицу 4 на 3 и подсчитайте сумму четных чисел.                                         *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string value = "425963128528";

Console.WriteLine("Матрица");
Console.WriteLine();

int[,] matrix = new int[4, 3];

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 3; j++)
    {
        matrix[i, j] = int.Parse(value.Substring(i * 3 + j, 1));
        Console.Write("   " + matrix[i, j]);
    }
    Console.WriteLine();
}

Console.WriteLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
int res = ds.Calculate(4, 3, value);



Console.WriteLine("Сумма четных чисел = " + res);

Console.ReadKey();