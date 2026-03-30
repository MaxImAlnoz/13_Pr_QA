using System;
using System.Collections.Generic;
using System.Linq;

namespace ListApp
{
    public class IntegerList
    {
        private List<int> numbers;

        public IntegerList(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
                throw new ArgumentException("Список пуст");

            this.numbers = numbers;
        }

        public double GetAverage()
        {
            return numbers.Average();
        }

        public void RemoveByDeviation(double threshold)
        {
            double avg = GetAverage();

            numbers = numbers
                .Where(x => Math.Abs(x - avg) <= threshold)
                .ToList();
        }

        public void SortDescending()
        {
            numbers = numbers
                .OrderByDescending(x => x)
                .ToList();
        }

        public List<int> GetList()
        {
            return numbers;
        }
    }
}