using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.VolkovNS.Sprint4.Task7.V25.Lib
{
    public class DataService : ISprint4Task7V25
    {
        public int Calculate(int n, int m, string value)
        {   int sum = 0;
            int[,] data = new int[n, m];
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++)
                {
                    data[i, j] = int.Parse(value.Substring(i * m+j, 1));
                    if (data[i, j] % 2 == 0)
                        sum+=data[i,j];
                }
            }
            return sum;
        }
    }
}
