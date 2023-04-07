using Main.DataStuctures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.DataStuctures
{
    public class BinarySearchTreeTests
    {
        private BinarySearchTree _bst;

        [SetUp]
        public void SetUp()
        {
            _bst = new BinarySearchTree();
        }

        [Test]
        public void Insert()
        {
            _bst.Insert(5, "e");
            _bst.Insert(3, "c");
            _bst.Insert(2, "b");
            _bst.Insert(4, "d");
            _bst.Insert(7, "g");
            _bst.Insert(6, "f");
            _bst.Insert(8, "h");

            Assert.That(_bst.Find(5), Is.EqualTo("e"));
            Assert.That(_bst.Find(3), Is.EqualTo("c"));
            Assert.That(_bst.Find(2), Is.EqualTo("b"));
            Assert.That(_bst.Find(4), Is.EqualTo("d"));
            Assert.That(_bst.Find(7), Is.EqualTo("g"));
            Assert.That(_bst.Find(6), Is.EqualTo("f"));
            Assert.That(_bst.Find(8), Is.EqualTo("h"));
            Assert.That(_bst.Find(99), Is.EqualTo(null));

            _bst.Print();

            ////        _bst.printInOrderTraversal();
            ////        _bst.printPreOrderTraversal();
            //_bst.printPostOrderTraversal();
        }

        [Test]
        public void MinKey()
        {
            _bst.Insert(5, "e");
            _bst.Insert(3, "c");
            _bst.Insert(2, "b");

            _bst.Print();
            Assert.That(_bst.Min, Is.EqualTo(2));
        }

        [Test]
        public void DeleteNoChild()
        {
            _bst.Insert(5, "e");
            _bst.Insert(3, "c");
            _bst.Insert(2, "b");
            _bst.Insert(4, "d");
            _bst.Insert(7, "g");
            _bst.Insert(6, "f");
            _bst.Insert(8, "h");

            _bst.Delete(2);

            Assert.IsNull(_bst.Find(2));

            _bst.Print();
        }

        [Test]
        public void DeleteOneChild()
        {
            _bst.Insert(5, "e");
            _bst.Insert(3, "c");
            _bst.Insert(2, "b");
            _bst.Insert(4, "d");
            _bst.Insert(7, "g");
            _bst.Insert(8, "h");

            _bst.Delete(7);

            Assert.IsNull(_bst.Find(7));

            _bst.Print();
        }

        [Test]
        public void DeleteTwoChildren()
        {
            _bst.Insert(5, "e");
            _bst.Insert(3, "c");
            _bst.Insert(2, "b");
            _bst.Insert(4, "d");
            _bst.Insert(7, "g");
            _bst.Insert(6, "f");
            _bst.Insert(8, "h");

            _bst.Delete(7);

            Assert.IsNull(_bst.Find(7));

            _bst.Print();
        }
    }
}
