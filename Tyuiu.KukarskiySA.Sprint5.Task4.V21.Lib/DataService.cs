using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KukarskiySA.Sprint5.Task4.V21.Lib
{
    public class DataService : ISprint5Task4V21
    {
        public double LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл не найден: {path}");
            }

            try
            {
                // Чтение содержимого файла
                string content = File.ReadAllText(path).Trim();
                if (!double.TryParse(content, out double x))
                {
                    throw new FormatException("Содержимое файла невозможно преобразовать в число.");
                }

                // Вычисление по формуле
                double y = Math.Pow(x, 3) * Math.Cos(x) + 2 * x;

                // Округление до трех знаков после запятой
                return Math.Round(y, 3);
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при обработке файла или вычислении.", ex);
            }
        }
    }
}
