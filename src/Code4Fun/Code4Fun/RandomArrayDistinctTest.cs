using System;
using System.Linq;
using NUnit.Framework;

namespace Code4Fun
{
    [TestFixture]
    class RandomArrayDistinctTest
    {
        private const int MAX_ELEMENT = 100;
        private RandomArrayDistinct sut;

        [SetUp]
        public void Setup()
        {
            sut = new RandomArrayDistinct(MAX_ELEMENT);
        }

        [Test]
        public void ShouldArrayIsNotEmpty()
        {
            Assert.IsNotEmpty(sut.DistinctArray);
        }

        [Test]
        public void ShouldArrayContainsMinValue()
        {
            sut.PopulateArray();
            Assert.That(sut.DistinctArray.Contains(1));
        }

        [Test]
        public void ShouldArrayContainsMaxValue()
        {
            sut.PopulateArray();
            Assert.That(sut.DistinctArray.Contains(MAX_ELEMENT));
        }

        [Test]
        public void ShouldArrayNotHasDuplicates()
        {
            sut.PopulateArray();
            Assert.That(HasDuplicates(sut.DistinctArray) == false);
        }

        private bool HasDuplicates(int[] array)
        {
            Array.Sort(array);
            for (var i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1]) return true;
            }
            return false;
        }

    }
}
