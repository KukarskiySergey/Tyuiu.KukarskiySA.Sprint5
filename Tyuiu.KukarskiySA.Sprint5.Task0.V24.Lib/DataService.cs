using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KukarskiySA.Sprint5.Task0.V24.Lib
{
    public class DataService : ISprint5Task0V24
    {
        public string SaveToFileTextData(int x)
        {
            double result = (Math.Pow(x, 3) - 8) / (2 * Math.Pow(x, 2));

            result = Math.Round(result, 3);

            string formattedResult = result.ToString("F3", CultureInfo.GetCultureInfo("ru-RU"));

            string filePath = "OutPutFileTask0.txt";

            File.WriteAllText(filePath, formattedResult);

            return $"Результат: {formattedResult}, сохранён в файл: {filePath}";
        }
    }
}
