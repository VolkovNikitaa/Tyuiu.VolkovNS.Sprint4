using Tyuiu.VolkovNS.Sprint4.Task3.V20.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил Волков Н. С. | ПКТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #22                                                             *");
        Console.WriteLine("* Выполнил: Волков Никита Сергеевич | ПКТб-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Найти минимальный элемент первого столбца массива                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int[,] array = new int[5, 5] { { 8, 7, 7, 8, 5 },{4,3,5,3,6},{5,3,8,6,3},{ 6, 3, 8, 5, 4},{ 3, 6, 8, 3, 4} };

        Console.WriteLine("Ответ: " + ds.Calculate(array));
    }
}