using System.Diagnostics.CodeAnalysis;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.VolkovNS.Sprint4.Task6.V25.Lib
{
    public class DataService : ISprint4Task6V25
    {
        public int Calculate(string[] array)
        { int sum = 0;
            foreach (string item in array) {
                if (item.Length >6) 
                    sum++;
            } 
            return sum;
        }
    }
}
