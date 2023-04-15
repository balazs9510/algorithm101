using Main.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Algorithms
{
    public class BubbleSortTest
    {
        [Test]
        public void Sort()
        {
            int[] array = { 5, 1, 4, 2, 8 };

            int[] sorted = BubbleSort.Sort(array);

            Assert.That(sorted[0], Is.EqualTo(1));
            Assert.That(sorted[1], Is.EqualTo(2));
            Assert.That(sorted[2], Is.EqualTo(4));
            Assert.That(sorted[3], Is.EqualTo(5));
            Assert.That(sorted[4], Is.EqualTo(8));
        }
    }
}
