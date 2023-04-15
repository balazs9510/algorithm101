using Main.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Algorithms
{
    public class RecursionTests
    {
        private Recursion recursion;

        [SetUp]
        public void SetUp()
        {
            recursion = new Recursion();
        }


        /*
        Channel formatter

        Write a recursive algorithm that strips the leading zeros off Strings of text.

        Simply strip off one zero at a time, and then recursively call yourself
        until no leading zeros from the original string are left.
         */
        [Test]
        public void StripLeadingZeros()
        {
            Assert.That(recursion.StripZeros("0001"), Is.EqualTo("1"));
            Assert.That(recursion.StripZeros("00011"), Is.EqualTo("11"));
            Assert.That(recursion.StripZeros("00001989"), Is.EqualTo("1989"));
            Assert.That(recursion.StripZeros("VOD"), Is.EqualTo("VOD"));
        }
    }
}
