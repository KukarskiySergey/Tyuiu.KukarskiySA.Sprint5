using Tyuiu.KukarskiySA.Sprint5.Task6.V27.Lib;

Console.Title = "Спринт #5 | Выполнил: Кукарский С.А. | ИИПб-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #5                                                            *");
Console.WriteLine("* Тема: Работа с бинарными файлами                                     *");
Console.WriteLine("* Задание #6                                                           *");
Console.WriteLine("* Вариант #27                                                          *");
Console.WriteLine("* Выполнил Кукарский Сергей Андреевич | ИИПб-24-1                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Вычислить значение по формуле и вывести на консоль.                  *");
Console.WriteLine("************************************************************************");

var service = new DataService();

try
{
    // Ввод пути к файлу
    Console.WriteLine("Введите путь к файлу:");
    string filePath = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(filePath))
    {
        Console.WriteLine("Путь к файлу не может быть пустым.");
        return;
    }

    // Убираем кавычки, если они случайно введены
    filePath = filePath.Trim('"');

    // Подсчёт трёхзначных чисел
    int result = service.LoadFromDataFile(filePath);
    Console.WriteLine($"Количество трёхзначных чисел: {result}");
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Произошла ошибка: {ex.Message}");
}