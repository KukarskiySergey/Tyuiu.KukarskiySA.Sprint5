using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KukarskiySA.Sprint5.Task6.V27.Lib
{
    public class DataService : ISprint5Task6V27
    {
        public int LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл не найден: {path}");
            }

            try
            {
                // Считываем содержимое файла
                string content = File.ReadAllText(path);

                // Регулярное выражение для поиска трёхзначных чисел
                Regex regex = new Regex(@"\b\d{3}\b");
                MatchCollection matches = regex.Matches(content);

                // Возвращаем количество найденных совпадений
                return matches.Count;
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при обработке файла.", ex);
            }
        }
    }
}
