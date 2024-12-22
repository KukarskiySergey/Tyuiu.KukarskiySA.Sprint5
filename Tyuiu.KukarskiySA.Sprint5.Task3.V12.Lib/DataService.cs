using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KukarskiySA.Sprint5.Task3.V12.Lib
{
    public class DataService : ISprint5Task3V12
    {
        public string SaveToFileTextData(int x)
        {
            // Формула y = x^3 / (2 * (x + 5)^2)
            double result = Math.Pow(x, 3) / (2 * Math.Pow(x + 5, 2));
            double roundedResult = Math.Round(result, 3);

            // Путь к бинарному файлу
            string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            // Сохранение результата в бинарный файл
            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                writer.Write(roundedResult);
            }

            // Возвращаем путь к файлу для проверки или вывода
            return filePath;
        }
    }
}
