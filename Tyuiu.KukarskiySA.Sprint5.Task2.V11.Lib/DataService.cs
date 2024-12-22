using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KukarskiySA.Sprint5.Task2.V11.Lib
{
    public class DataService : ISprint5Task2V11
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            // Устанавливаем путь к файлу
            string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    StringBuilder line = new StringBuilder();

                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] % 2 != 0) // Если элемент нечётный
                        {
                            matrix[i, j] = 0; // Заменяем на 0
                        }

                        line.Append(matrix[i, j]);
                        if (j < matrix.GetLength(1) - 1)
                        {
                            line.Append("; ");
                        }
                    }

                    writer.WriteLine(line.ToString());
                    Console.WriteLine(line.ToString());
                }
            }

            return filePath;
        }
    }
}
