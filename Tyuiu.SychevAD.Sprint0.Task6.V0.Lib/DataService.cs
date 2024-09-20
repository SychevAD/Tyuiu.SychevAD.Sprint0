﻿using System.Numerics;

namespace Tyuiu.SychevAD.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        public static int AdditionArray(int[] numbers)
        {
            var total = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                total = total + numbers[i];
            }
            return total;
        }



        public static int SubtractionArray(int[] numbers)
        {
            var total = 0;
            int index = 0;
            while (index < numbers.Length)
            {
                total = total - numbers[index];
                index++;
            }
            return total;
        }



        public static int MultiplicationArray(int[] numbers)
        {
            var total = 1;
            int index = 0;
            do
            {
                total = total * numbers[index];
                index++;
            }
            while (index < numbers.Length);
            return total;
        }
    }
}
