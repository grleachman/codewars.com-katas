using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata1
{
    public class ThePoetAndThePendulum
    {
        public static object Pendulum(int[] values)
        {

            //[InlineData(new[] { 9, 4, 6, 4, 10, 5 }, new[] { 9, 5, 4, 4, 6, 10 })]

            var sortedArray = values.OrderBy(x => x).ToList();

            var innerValues = new int[values.Length];

            var leftQueue = new Queue<int>();
            var rightQueue = new Queue<int>();
            var index1 = 0 + (values.Length / 2);
            index1 = index1 + ((values.Length % 2 == 0) ? -1 : 0);

            var oscilator = 0;
            var pendulum = -1;
            var nextOscilation = 0;
            Console.WriteLine($"center = {index1}");
            for (var i = 0; i < values.Length; i++)
            {
                oscilator = oscilator + pendulum * i;
                pendulum = -pendulum;
                Console.WriteLine($"oscilator {oscilator}, index1 : {index1 + oscilator}; i : {i}");

                innerValues[index1 + oscilator] = sortedArray[i];

            }

            return innerValues;
        }
    }
}
