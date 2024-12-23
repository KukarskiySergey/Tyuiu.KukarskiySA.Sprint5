using Tyuiu.KukarskiySA.Sprint5.Task4.V21.Lib;

Console.Title = "Спринт #5 | Выполнил: Кукарский С.А. | ИИПб-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #5                                                            *");
Console.WriteLine("* Тема: Работа с бинарными файлами                                     *");
Console.WriteLine("* Задание #4                                                           *");
Console.WriteLine("* Вариант #21                                                          *");
Console.WriteLine("* Выполнил Кукарский Сергей Андреевич | ИИПб-24-1                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Вычислить значение по формуле и вывести на консоль.                  *");
Console.WriteLine("************************************************************************");

const string filePath = @"C:\DataSprint5\InPutDataFileTask5V21.txt";
var dataService = new DataService();

try
{
    // Вызываем метод и получаем результат
    double result = dataService.LoadFromDataFile(filePath);
    Console.WriteLine($"Результат вычисления: {result}");
}
catch (Exception ex)
{
    Console.WriteLine($"Произошла ошибка: {ex.Message}");
}