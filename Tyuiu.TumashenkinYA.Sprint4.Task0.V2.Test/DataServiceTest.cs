using Tyuiu.TumashenkinYA.Sprint4.Task0.V2.Lib;
namespace Tyuiu.TumashenkinYA.Sprint4.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumOddArrEl()
        {
            DataService ds = new DataService();

            int[] array = { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };

            int result = ds.GetSumOddArrEl(array);
            int expected = 44;

            Assert.AreEqual(expected, result);
        }
    }
}
