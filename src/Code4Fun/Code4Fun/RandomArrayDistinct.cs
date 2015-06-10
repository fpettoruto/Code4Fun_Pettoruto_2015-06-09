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
            int j = 0;
            var r = new Random();

            for (var i = 0; j < maxElement; i++)
            {
                var randomValue = r.Next(maxElement);
                if (IntIsUsed[randomValue] == 1)
                {
                    randomValue = j;
                }

                if (IntIsUsed[randomValue] != 1)
                {
                    IntIsUsed[randomValue] = 1;
                    DistinctArray[j++] = randomValue + 1;
                }
            }
        }

      
    }
}
