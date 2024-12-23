using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KukarskiySA.Sprint5.Task5.V23.Lib
{
    public class DataService : ISprint5Task5V23
    {
        public double LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл не найден: {path}");
            }

            try
            {
                // Считываем все строки из файла
                string[] lines = File.ReadAllLines(path);

                double minValue = double.MaxValue; // Изначально задаем максимальное значение

                foreach (string line in lines)
                {
                    string trimmedLine = line.Trim(); // Удаляем лишние пробелы и символы

                    if (double.TryParse(trimmedLine, NumberStyles.Float, CultureInfo.GetCultureInfo("ru-RU"), out double number))
                    {
                        if (number < minValue)
                        {
                            minValue = number; // Находим минимальное число
                        }
                    }
                    else
                    {
                        throw new FormatException($"Строка '{line}' невозможно преобразовать в число.");
                    }
                }

                // Округляем минимальное значение до трёх знаков после запятой
                return Math.Round(minValue, 3);
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при обработке файла или вычислении.", ex);
            }
        }
    }
}
