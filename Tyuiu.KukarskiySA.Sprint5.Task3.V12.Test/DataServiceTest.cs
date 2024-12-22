using Tyuiu.KukarskiySA.Sprint5.Task3.V12.Lib;

namespace Tyuiu.KukarskiySA.Sprint5.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        private DataService _dataService;

        [TestInitialize]
        public void Setup()
        {
            _dataService = new DataService();
        }

        [TestMethod]
        public void SaveToFileTextData_FileIsCreated()
        {
            // Arrange
            int x = 3;

            // Act
            string filePath = _dataService.SaveToFileTextData(x);

            // Assert
            Assert.IsTrue(File.Exists(filePath), "Бинарный файл не был создан.");
        }
    }
}