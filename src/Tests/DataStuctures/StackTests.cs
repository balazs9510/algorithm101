using Main.DataStuctures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.DataStuctures
{
    public class StackTests
    {
        private Main.DataStuctures.Stack stack;

        [SetUp]
        public void SetUp()
        {
            stack = new Main.DataStuctures.Stack();
        }

        [Test]
        public void Push()
        {
            stack.Push(15);
            stack.Push(25);
            stack.Push(75);

            Assert.That(stack.Length(), Is.EqualTo(3));
            Assert.That(stack.Peek(), Is.EqualTo(75));
            Assert.That(stack.IsEmpty, Is.EqualTo(false));
        }

        [Test]
        public void Pop()
        {
            stack.Push(15);
            stack.Push(25);
            stack.Pop();
            stack.Push(35);
            stack.Pop();

            Assert.That(stack.Peek(), Is.EqualTo(15));
            Assert.That(stack.Length(), Is.EqualTo(1));
            Assert.That(stack.IsEmpty, Is.EqualTo(false));
            Assert.That(stack.Pop(), Is.EqualTo(15));
        }
    }
}
