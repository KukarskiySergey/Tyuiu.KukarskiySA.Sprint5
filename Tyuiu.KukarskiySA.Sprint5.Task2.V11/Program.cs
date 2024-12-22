using Tyuiu.KukarskiySA.Sprint5.Task2.V11.Lib;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #5 | Выполнил: Кукарский С.А. | ИИПб-24-1";
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* Спринт #5                                                            *");
        Console.WriteLine("* Тема: Работа с массивами и запись в CSV                              *");
        Console.WriteLine("* Задание #2                                                           *");
        Console.WriteLine("* Вариант #11                                                          *");
        Console.WriteLine("* Выполнил Кукарский Сергей Андреевич | ИИПб-24-1                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("* Дан двумерный массив, заменить нечётные элементы на 0                *");
        Console.WriteLine("************************************************************************");

        // Создаем массив 3x3
        int[,] matrix = new int[3, 3];

        Console.WriteLine("* Ввод массива:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Введите элемент [{i}, {j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine() ?? "0");
            }
        }

        DataService dataService = new DataService();
        string filePath = dataService.SaveToFileTextData(matrix);

        Console.WriteLine("\nРезультат сохранен в файл: " + filePath);
        Console.WriteLine("************************************************************************");
        Console.ReadLine();
    }
}
