using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KukarskiySA.Sprint5.Task1.V25.Lib
{
    public class DataService : ISprint5Task1V25
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            // Устанавливаем путь к файлу
            string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            // Создаем текстовый файл
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int x = startValue; x <= stopValue; x++)
                {
                    double fx = CalculateFunction(x);
                    fx = Math.Round(fx, 2);

                    // Выбираем формат: без десятичной части, если дробная часть равна 0
                    string formattedFx = (fx % 1 == 0)
                        ? ((int)fx).ToString("F0", CultureInfo.GetCultureInfo("ru-RU"))
                        : fx.ToString("F2", CultureInfo.GetCultureInfo("ru-RU"));

                    writer.WriteLine(formattedFx);
                    Console.WriteLine(formattedFx);
                }
            }

            return filePath;
        }

        private double CalculateFunction(int x)
        {
            // Проверка деления на ноль (если знаменатель равен 0, возвращаем 0)
            double denominator = 3 * x + 1.2;
            if (denominator == 0)
            {
                return 0;
            }

            // Вычисляем F(x)
            double fx = (2 * Math.Sin(x) / denominator) + Math.Cos(x) - 7 * x * 2;

            return fx;
        }
    }
}
