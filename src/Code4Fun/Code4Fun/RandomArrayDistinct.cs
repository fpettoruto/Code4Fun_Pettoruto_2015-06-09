using System;

namespace Code4Fun
{
    class RandomArrayDistinct
    {
        private int maxElement;
        private int[] IntIsUsed;

        public int[] DistinctArray { get; private set; }

        public RandomArrayDistinct(int maxElememt)
        {
            maxElement = maxElememt;
            IntIsUsed = new int[maxElememt];
            DistinctArray = new int[maxElememt];
        }
        public void PopulateArray()
        {
            throw new NotImplementedException();
        }

      
    }
}
