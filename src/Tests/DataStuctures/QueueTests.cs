using Main.DataStuctures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.DataStuctures
{
    public class QueueTests
    {
        private Queue queue;

        [SetUp]
        public void SetUp()
        {
            queue = new Queue();
        }

        [Test]
        public void Add()
        {
            queue.Add(5);
            queue.Add(2);
            queue.Add(21);

            Assert.That(queue.Peek(), Is.EqualTo(5));
        }

        [Test]
        public void Remove()
        {
            queue.Add(8);
            queue.Add(72);
            queue.Add(11);
            queue.Remove();
            queue.Add(15);
            queue.Add(35);
            queue.Remove();

            Assert.That(queue.Peek(), Is.EqualTo(11));
        }

        [Test]
        public void IsEmpty()
        {
            queue.Add(8);
            queue.Remove();

            Assert.That(queue.IsEmpty, Is.EqualTo(true));
        }
    }
}
