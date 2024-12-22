using Tyuiu.KukarskiySA.Sprint5.Task2.V11.Lib;

namespace Tyuiu.KukarskiySA.Sprint5.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToCsvAndReplaceOddValues_Test()
        {
            // Arrange
            DataService dataService = new DataService();
            int[,] matrix = new int[,]
            {
                { 4, 9, 3 },
                { 5, 8, 8 },
                { 5, 7, 5 }
            };

            // Act
            string filePath = dataService.SaveToFileTextData(matrix);

            // Assert
            Assert.IsTrue(File.Exists(filePath)); // Проверяем, что файл создан

            string[] lines = File.ReadAllLines(filePath);
            Assert.AreEqual(3, lines.Length); // Проверяем количество строк в файле

            // Проверяем содержимое файла
            Assert.AreEqual("4; 0; 0", lines[0]);
            Assert.AreEqual("0; 8; 8", lines[1]);
            Assert.AreEqual("0; 0; 0", lines[2]);

            // Удаляем файл после теста
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }
}
