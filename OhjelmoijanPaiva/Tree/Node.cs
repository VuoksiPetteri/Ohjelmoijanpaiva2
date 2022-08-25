using System;
using System.Collections.Generic;
using System.Linq;

namespace OhjelmoijanPaiva.Tree
{
    /// <summary>
    /// Class describes node in a tree.
    /// </summary>
    class Node
    {
        private Node left;
        private Node right;
        private string text;
        private Choise[] choises;

        public Node Left { get => this.left; }
        public Node Right { get => this.right; }

        public Node(Node left, Node right, string text, Choise[] choises)
        {
            this.left = left;
            this.right = right;
            this.text = text;
            this.choises = choises;
        }

        public void PrintOptions()
        {
            foreach (Choise item in choises)
            {
                item.Print();
            }
        }

        public void PrintText()
        {
            Console.WriteLine(this.text);

        }
    }
}
