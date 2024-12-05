using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MokhamedAA.Sprint6.Task1.V9.Lib
{
    public class DataService : ISprint6Task1V9
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] res = new double[len];
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                double y = Math.Round((2 * i) - 4 + (((2 * i) - 1) / (Math.Sin(i) + 1)), 2);



                if (Math.Sin(i) == -1)
                {
                    res[i] = 0;
                }
                res[count] = y;

                count++;
            }
            return res;
        }
    }
}
