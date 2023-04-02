using Main.DataStuctures;
namespace Tests.DataStuctures
{
    public class LinkedListTests
    {
        public Main.DataStuctures.LinkedList LinkedList { get; set; }

        [SetUp]
        public void Setup()
        {
            LinkedList = new Main.DataStuctures.LinkedList();
        }

        [Test]
        public void AddFrontTest()
        {
            LinkedList.AddFront(1);
            LinkedList.AddFront(2);
            LinkedList.AddFront(3);
        }

        [Test]
        public void GetFirstTest()
        {
            LinkedList.AddFront(1);
            Assert.That(LinkedList.GetFirst(), Is.EqualTo(1));
        }

        [Test]
        public void GetLastTest()
        {
            LinkedList.AddFront(1);
            LinkedList.AddFront(2);
            LinkedList.AddFront(3);
            Assert.That(LinkedList.GetLast(), Is.EqualTo(1));
        }

        [Test]
        public void AddBackTest()
        {
            LinkedList.AddBack(1);
            LinkedList.AddBack(2);
            LinkedList.AddBack(3);
            Assert.That(LinkedList.GetFirst(), Is.EqualTo(1));
            Assert.That(LinkedList.GetLast(), Is.EqualTo(3));
        }

        [Test]
        public void SizeTest()
        {
            Assert.That(LinkedList.Length(), Is.EqualTo(0));
            LinkedList.AddBack(1);
            Assert.That(LinkedList.Length(), Is.EqualTo(1));
            LinkedList.AddBack(2);
            Assert.That(LinkedList.Length(), Is.EqualTo(2));
        }

        [Test]
        public void ClearTest()
        {
            LinkedList.AddBack(1);
            LinkedList.AddBack(2);
            LinkedList.AddBack(3);

            LinkedList.Clear();

            Assert.That(LinkedList.Length(), Is.EqualTo(0));
        }

        [Test]
        public void DeleteTest()
        {
            LinkedList.AddBack(1);
            LinkedList.AddBack(2);
            LinkedList.AddBack(3);

            LinkedList.DeleteValue(2);

            Assert.That(LinkedList.Length(), Is.EqualTo(2));
            Assert.That(LinkedList.GetFirst(), Is.EqualTo(1));
            Assert.That(LinkedList.GetLast(), Is.EqualTo(3));
        }
    }
}
