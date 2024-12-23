using Tyuiu.KukarskiySA.Sprint5.Task5.V23.Lib;

var service = new DataService();
string filePath = @"/app/data/AssesmentData/C#/Sprint5Task5/InPutDataFileTask5V23.txt";

try
{
    double result = service.LoadFromDataFile(filePath);
    Console.WriteLine($"Минимальное значение: {result}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}