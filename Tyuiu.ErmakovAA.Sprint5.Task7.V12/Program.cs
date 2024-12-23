using Tyuiu.ErmakovAA.Sprint5.Task7.V12.Lib;
namespace Tyuiu.ErmakovAA.Sprint5.Task7.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполгил: Ермаков А.А. | ПКТб-24-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                    *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                                  *");
            Console.WriteLine("* Задание #7                                                                   *");
            Console.WriteLine("* Вариант #14                                                                  *");
            Console.WriteLine("* Выполнил: Ермаков А.А.                                                       *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask7V14.txt";
            Console.WriteLine("Данные находятся в файле: " + path);
                    
            string str = File.ReadAllText(path);
            string resPath = Path.Combine(Path.GetTempPath(), "OutPutFileTask7V14.txt");

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");

            
            Console.WriteLine("Берем отсюда значение: " + resPath);
            Console.WriteLine("Значение в файле: " + str);

            Console.WriteLine("Измененное значени загрузилось в файл OutPutFileTask7V14.txt по данному пути: " + ds.LoadDataAndSave(path));

            Console.ReadKey();

           



        }
    }
}
