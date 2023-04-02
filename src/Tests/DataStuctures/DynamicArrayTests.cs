using Main.DataStuctures;
using Newtonsoft.Json.Linq;
using System;

namespace Tests.DataStuctures
{
    public class DynamicArrayTests
    {
        public DynamicArray<string> Array { get; set; }

        [SetUp]
        public void Setup()
        {
            Array = new DynamicArray<string>(2);
        }

        [Test]
        public void GetAndSet()
        {
            Array.SetValue(0, "a");
            Assert.That(Array.GetValue(0), Is.EqualTo("a"));
        }

        [Test]
        public void Insert()
        {
            Array.Add("a"); // 0
            Array.Add("b"); // 1
            Array.Add("c"); // 2

            Array.Insert(1, "d");

            Assert.That(Array.Length, Is.EqualTo(4));
            Assert.That(Array.GetValue(0), Is.EqualTo("a"));
            Assert.That(Array.GetValue(1), Is.EqualTo("d"));
            Assert.That(Array.GetValue(2), Is.EqualTo("b"));
            Assert.That(Array.GetValue(3), Is.EqualTo("c"));
        }

        [Test]
        public void DeleteFirst()
        {
            Array.Add("a");
            Array.Add("b");
            Array.Add("c");

            Array.Delete(0);

            Assert.That(Array.Length, Is.EqualTo(2));
            Assert.That(Array.GetValue(0), Is.EqualTo("b"));
            Assert.That(Array.GetValue(1), Is.EqualTo("c"));
            Assert.That(Array.GetValue(2), Is.EqualTo(null));
        }

        [Test]
        public void DeleteMiddle()
        {
            Array.Add("a");
            Array.Add("b");
            Array.Add("c");

            Array.Delete(1);

            Assert.That(Array.Length, Is.EqualTo(2));
            Assert.That(Array.GetValue(0), Is.EqualTo("a"));
            Assert.That(Array.GetValue(1), Is.EqualTo("c"));
            Assert.That(Array.GetValue(2), Is.EqualTo(null));
        }

        [Test]
        public void DeleteLast()
        {
            Array.Add("a");
            Array.Add("b");
            Array.Add("c");

            Array.Delete(2);

            Assert.That(Array.Length, Is.EqualTo(2));
            Assert.That(Array.GetValue(0), Is.EqualTo("a"));
            Assert.That(Array.GetValue(1), Is.EqualTo("b"));
            Assert.That(Array.GetValue(2), Is.EqualTo(null));
        }

        [Test]
        public void IsEmpty()
        {
            Assert.True(Array.IsEmpty);
            Array.Add("a");
            Assert.False(Array.IsEmpty);
        }

        [Test]
        public void Contains()
        {
            Assert.False(Array.Contains("a"));
            Array.Add("a");
            Assert.True(Array.Contains("a"));
            Array.Add("b");
            Array.Add("b");
            Array.Add("c");
            Assert.True(Array.Contains("b"));
            Assert.True(Array.Contains("c"));
            Array.Delete(3);
            Assert.False(Array.Contains("c"));
            Array.Delete(2);
            Assert.True(Array.Contains("b"));
            Array.Delete(1);
            Assert.False(Array.Contains("b"));
            Array.Delete(0);
            Assert.False(Array.Contains("a"));
        }
    }
}