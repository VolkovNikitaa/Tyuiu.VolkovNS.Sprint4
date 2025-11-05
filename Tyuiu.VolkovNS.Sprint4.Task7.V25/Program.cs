using Tyuiu.VolkovNS.Sprint4.Task7.V25.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил Волков Н. С. | ПКТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы (генератор случайных чисел)                     *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #11                                                             *");
        Console.WriteLine("* Выполнил: Волков Никита Сергеевич | ПКТб-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Заменить положительные элементы на 1.                                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("* \"Теннис\", \"Футбол\", \"Крикет\", \"Баскетбол\",\"Бейсбол\", \"Регби\", \"Хоккей\"*");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        string array = "348561792486";
        int n = 4, m = 3;
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Массив:                                                                    ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(int.Parse(array.Substring(i*m+j,1)) + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Ответ: " + ds.Calculate(4,3,array));
    }
}