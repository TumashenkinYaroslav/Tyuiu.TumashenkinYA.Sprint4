using Tyuiu.TumashenkinYA.Sprint4.Task1.V27.Lib;
Console.WriteLine("* УСЛОВИЕ:                                                                *");

Console.WriteLine("*Написать программу из операций сравнений (==, !=, <, >, <=, >=, последова*");
Console.WriteLine("*ательность операций не должна нарушаться) и арифметических выражений, кот*");
Console.WriteLine("*торая вернет логическую последовательность(массив): (True, True, True, Tr*");
Console.WriteLine("*rue, True, False), при x = 1054, y = 375                                 *");

Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("***************************************************************************");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();

var result = ds.Calculate(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
Console.WriteLine(result);
Console.ReadKey();