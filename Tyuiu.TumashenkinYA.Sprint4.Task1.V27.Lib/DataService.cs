using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TumashenkinYA.Sprint4.Task1.V27.Lib
{
    public class DataService : ISprint4Task1V27
    {
        public int Calculate(int[] array) => array.Where(x => x % 2 == 0).Aggregate(1, (acc, x) => acc * x);
    }
}
