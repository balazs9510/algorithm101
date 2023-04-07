using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Main.DataStuctures
{

    public class BinarySearchTree
    {
        private class BinarySearchTreeNode
        {
            public int Key { get; set; }
            public string Value { get; set; }
            public BinarySearchTreeNode Left { get; set; }
            public BinarySearchTreeNode Right { get; set; }

            public BinarySearchTreeNode(int Key, string value)
            {
                Key = Key;
                Value = value;
            }

            public int Min => MinRec().Key;
            public BinarySearchTreeNode MinNode => MinRec();
            private BinarySearchTreeNode MinRec()
            {
                if (Left == null)
                {
                    return this;
                }

                return Left.MinRec();
            }
        }

        private BinarySearchTreeNode _root;

        public string Find(int index)
        {
            return Find(_root, index)?.Value;
        }

        private BinarySearchTreeNode Find(BinarySearchTreeNode node, int index)
        {
            if (node == null) return null;

            if (index < node.Key)
            {
                return Find(node.Left, index);
            }
            else if (index > node.Key)
            {
                return Find(node.Right, index);
            }

            return node;
        }

        public void Insert(int index, string value)
        {
            _root = Insert(_root, index, value);
        }

        private BinarySearchTreeNode Insert(BinarySearchTreeNode node, int index, string value)
        {
            if (node == null)
            {
                return new BinarySearchTreeNode(index, value);
            }

            if (index < node.Key)
            {
                node.Left = Insert(node.Left, index, value);
            }
            else
            {
                node.Right = Insert(node.Right, index, value);
            }

            return node;
        }

        public int? Min => _root?.Min;

        public void Print()
        {
            // Hard coded print out of binary tree depth = 3

            int rootLeftKey = _root.Left == null ? 0 : _root.Left.Key;
            int rootRightKey = _root.Right == null ? 0 : _root.Right.Key;

            int rootLeftLeftKey = 0;
            int rootLeftRightKey = 0;

            if (_root.Left != null)
            {
                rootLeftLeftKey = _root.Left.Left == null ? 0 : _root.Left.Left.Key;
                rootLeftRightKey = _root.Left.Right == null ? 0 : _root.Left.Right.Key;
            }

            int rootRightLeftKey = 0;
            int rootRightRightKey = 0;

            if (_root.Right != null)
            {
                rootRightLeftKey = _root.Right.Left == null ? 0 : _root.Right.Left.Key;
                rootRightRightKey = _root.Right.Right == null ? 0 : _root.Right.Right.Key;
            }

            Console.WriteLine("     " + _root.Key);
            Console.WriteLine("   /  \\");
            Console.WriteLine("  " + rootLeftKey + "    " + rootRightKey);
            Console.WriteLine(" / \\  / \\");
            Console.WriteLine(rootLeftLeftKey + "  " + rootLeftRightKey + " " + rootRightLeftKey + "   " + rootRightRightKey);
        }

        private BinarySearchTreeNode FindParent(BinarySearchTreeNode node, int index)
        {
            if (node == null) return null;

            if (node.Left?.Key == index || node.Right?.Key == index)
            {
                return node;
            }

            if (index < node.Key)
            {
                return FindParent(node.Left, index);
            }
            else
            {
                return FindParent(node.Right, index);
            }
        }

        public void Delete(int Key)
        {
            _root = Delete(_root, Key);
        }

        private BinarySearchTreeNode Delete(BinarySearchTreeNode node, int Key)
        {
            if (node == null)
            {
                return null;
            }
            else if (Key < node.Key)
            {
                node.Left = Delete(node.Left, Key);
            }
            else if (Key > node.Key)
            {
                node.Right = Delete(node.Right, Key);
            }
            else
            { // Woohoo! Found you. This is the node we want to delete.

                // Case 1: No child
                if (node.Left == null && node.Right == null)
                {
                    node = null;
                }

                // Case 2: One child
                else if (node.Left == null)
                {
                    node = node.Right;
                }
                else if (node.Right == null)
                {
                    node = node.Left;
                }

                // Case 3: Two children
                else
                {
                    // Find the minimum node on the Right (could also max the Left...)
                    var minRight = node.Right.MinNode;

                    // Duplicate it by copying its values here
                    node.Key = minRight.Key;
                    node.Value = minRight.Value;

                    // Now go ahead and delete the node we just duplicated (same Key)
                    node.Right = Delete(node.Right, node.Key);
                }
            }

            return node;
        }

    }
}
