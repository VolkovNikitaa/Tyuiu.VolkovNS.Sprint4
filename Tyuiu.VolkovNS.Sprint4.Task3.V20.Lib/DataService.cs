using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.VolkovNS.Sprint4.Task3.V20.Lib
{
    public class DataService : ISprint4Task3V20
    {
        public int Calculate(int[,] array)
        {
            int sum=9;
            for (int i = 0; i < array.GetLength(0); i++) {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if(j==0 && array[i,j]<sum)
                        sum=array[i,j];
                }
            }
            return sum;
        }
    }
}
