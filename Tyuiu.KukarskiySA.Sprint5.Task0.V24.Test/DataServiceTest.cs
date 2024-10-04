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
            string expectedValue = "1,056";  // Ожидаем строку с запятой
            string filePath = "OutPutFileTask0.txt";

            // Act
            dataService.SaveToFileTextData(x);

            // Проверяем, что файл был создан и содержит правильный результат
            string resultText = File.ReadAllText(filePath);

            // Assert
            Assert.AreEqual(expectedValue, resultText);

            // Очистка тестового файла после теста
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }
}