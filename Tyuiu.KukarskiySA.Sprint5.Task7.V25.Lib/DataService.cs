using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KukarskiySA.Sprint5.Task7.V25.Lib
{
    public class DataService : ISprint5Task7V25
    {
        public string LoadDataAndSave(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл не найден: {path}");
            }

            try
            {
                // Считываем содержимое файла
                string content = File.ReadAllText(path);

                // Регулярное выражение для поиска английских слов
                Regex regex = new Regex(@"\b[a-zA-Z]+\b");

                // Удаляем английские слова
                string result = regex.Replace(content, "").Trim();

                // Генерируем путь для выходного файла
                string outputPath = Path.Combine(Path.GetDirectoryName(path), "OutPutDataFileTask7V25.txt");

                // Сохраняем результат в выходной файл
                File.WriteAllText(outputPath, result);

                // Возвращаем путь к сохранённому файлу
                return outputPath;
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при обработке данных.", ex);
            }
        }
    }
}
