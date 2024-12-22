using Tyuiu.KukarskiySA.Sprint5.Task4.V21.Lib;

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