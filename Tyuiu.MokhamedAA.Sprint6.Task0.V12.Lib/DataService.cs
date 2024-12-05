using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MokhamedAA.Sprint6.Task0.V12.Lib
{
    public class DataService : ISprint6Task0V12
    {
        public double Calculate(int x)
        {
            double y;
            y = (x * x + 1) / (Math.Pow(4 * x * x - 3, 0.5));
            if (Math.Pow(4 * x * x - 3, 0.5) == 0)
                y = 0000;
            y = Math.Round(y, 3);
            return y;
        }
    }
}
