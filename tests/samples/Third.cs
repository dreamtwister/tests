using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests.samples
{
    /*
    Please write code that calculates standard deviation for a given list of values.

    Пожалуйста, напишите код, который вычисляет стандартное отклонение для заданного списка значений.
    */

    public class Third
    {
        public double CalculateStandardDeviation(double[] values)
        {
            double mean = values.Average();
            double variance = values.Select(v => Math.Pow(v - mean, 2)).Average();
            return Math.Sqrt(variance);
        }
    }
}
