using Tyuiu.KukarskiySA.Sprint5.Task0.V24.Lib;

namespace Tyuiu.KukarskiySA.Sprint5.Task0.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData_Test()
        {
            // Arrange
            DataService dataService = new DataService();
            int x = 3;
            double expectedValue = 1.056;
            string filePath = "OutPutFileTask0.txt";

            // Act
            dataService.SaveToFileTextData(x);

            // Проверяем, что файл был создан и содержит правильный результат
            string resultText = File.ReadAllText(filePath);
            double actualResult = double.Parse(resultText);

            // Assert
            Assert.AreEqual(expectedValue, actualResult);

            // Очистка тестового файла после теста
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }
}