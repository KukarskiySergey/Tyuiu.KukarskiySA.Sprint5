using Tyuiu.KukarskiySA.Sprint5.Task7.V25.Lib;

Console.Title = "Спринт #5 | Выполнил: Кукарский С.А. | ИИПб-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #5                                                            *");
Console.WriteLine("* Тема: Работа с бинарными файлами                                     *");
Console.WriteLine("* Задание #7                                                           *");
Console.WriteLine("* Вариант #25                                                          *");
Console.WriteLine("* Выполнил Кукарский Сергей Андреевич | ИИПб-24-1                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Вычислить значение по формуле и вывести на консоль.                  *");
Console.WriteLine("************************************************************************");

var service = new DataService();

try
{
    Console.WriteLine("Введите путь к исходному файлу:");
    string inputFilePath = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(inputFilePath))
    {
        Console.WriteLine("Путь к исходному файлу не может быть пустым.");
        return;
    }

    inputFilePath = inputFilePath.Trim('"');

    // Удаляем английские слова и сохраняем результат
    string outputFilePath = service.LoadDataAndSave(inputFilePath);

    Console.WriteLine($"Результат сохранён в файл: {outputFilePath}");
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Произошла ошибка: {ex.Message}");
}