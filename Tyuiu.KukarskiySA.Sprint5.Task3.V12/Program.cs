using Tyuiu.KukarskiySA.Sprint5.Task3.V12.Lib;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #5 | Выполнил: Кукарский С.А. | ИИПб-24-1";
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* Спринт #5                                                            *");
        Console.WriteLine("* Тема: Работа с бинарными файлами                                     *");
        Console.WriteLine("* Задание #3                                                           *");
        Console.WriteLine("* Вариант #12                                                          *");
        Console.WriteLine("* Выполнил Кукарский Сергей Андреевич | ИИПб-24-1                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("* Вычислить значение выражения при x = 3, сохранить в бинарный файл    *");
        Console.WriteLine("* и вывести на консоль.                                                *");
        Console.WriteLine("************************************************************************");

        DataService dataService = new DataService();
        int x = 3;

        try
        {
            // Вызываем метод для вычисления, сохранения в файл и получения пути
            string filePath = dataService.SaveToFileTextData(x);

            // Чтение результата из файла
            double result;
            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                result = reader.ReadDouble();
            }

            // Вывод результата
            Console.WriteLine($"Результат вычисления (округлено до 3 знаков): {result}");
            Console.WriteLine($"Результат сохранен в файл: {filePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }

        Console.WriteLine("************************************************************************");
        Console.ReadLine();
    }
}
