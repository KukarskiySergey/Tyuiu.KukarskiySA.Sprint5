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
            string expectedValue = "1,056";  // ������� ������ � �������

            // Act
            string filePath = dataService.SaveToFileTextData(x);

            // ���������, ��� ���� ��� ������ � �������� ���������� ���������
            string resultText = File.ReadAllText(filePath);

            // Assert
            Assert.AreEqual(expectedValue, resultText);

            // ������� ��������� ���� ����� �����
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }
}