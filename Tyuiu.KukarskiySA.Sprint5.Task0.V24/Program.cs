using Tyuiu.KukarskiySA.Sprint5.Task0.V24.Lib;

DataService dataService = new DataService();

Console.Title = "Спринт #5 | Выполнил: Кукарский С.А. | ИИПб-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #5                                                            *");
Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                     *");
Console.WriteLine("* Задание #0                                                           *");
Console.WriteLine("* Вариант #24                                                          *");
Console.WriteLine("* Выполнил Кукарский Сергей Андреевич | ИИПб-24-1                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить *");
Console.WriteLine("* в текстовый файл OutPutFileTask0.txt и вывести на консоль.           *");
Console.WriteLine("* Округлить до трёх знаков после запятой.                              *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("* Выражение                                                            *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");

int x = 3;

string outputMessage = dataService.SaveToFileTextData(x);

Console.WriteLine(outputMessage);
Console.WriteLine("************************************************************************");
Console.ReadLine();