using Tyuiu.TumashenkinYA.Sprint4.Task5.V1.Lib;
namespace Tyuiu.TumashenkinYA.Sprint4.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] { { 1, 2, 3, 4, 5 }, { 2, 3, 4, 5, 6 }, { 3, 4, 5, 6, 7 }, { 4, 5, 6, 7, 8 }, { 1, 2, 3, 4, 5 } };
            int[,] wait = new int[5, 5] { { 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1 } };
            int[,] res = ds.Calculate(mas2);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
