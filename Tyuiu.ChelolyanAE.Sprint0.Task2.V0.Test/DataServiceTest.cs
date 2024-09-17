using Tyuiu.ChelolyanAE.Sprint0.Task2.V0.Lib;

namespace Tyuiu.ChelolyanAE.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessage()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Анжела";
            var res = DataService.GetMessage(name);

            //Вызываем класс Assert и метод AreEqual
            Assert.AreEqual(    "Привет, Анжела", res);
        }
    }
}