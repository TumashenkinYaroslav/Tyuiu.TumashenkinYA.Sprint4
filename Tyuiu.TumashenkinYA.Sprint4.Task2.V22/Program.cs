using Tyuiu.TumashenkinYA.Sprint4.Task2.V22.Lib;
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов заполненный         *");
Console.WriteLine("* заполненный случайными в диапазоне от 1 до 6                            *");
Console.WriteLine("* подсчитать произведение нечетных элементов массива.                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int len;
Console.WriteLine("Введите количество элементов массива:");
len = Convert.ToInt32(Console.ReadLine());

int[] numsArray = new int[len];

for (int i = 0; i <= len - 1; i++)
{
    numsArray[i] = rnd.Next(1, 6);
}
Console.WriteLine();
Console.WriteLine("Массив:");
for (int i = 0; i <= len - 1; ++i)
{
    Console.Write(numsArray[i] + "\t");
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int res = ds.Calculate(numsArray);
Console.WriteLine("Произведение нечетных элементов массива равна: " + res);
Console.ReadKey();