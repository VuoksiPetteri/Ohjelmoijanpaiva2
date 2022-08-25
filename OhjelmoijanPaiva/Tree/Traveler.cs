namespace OhjelmoijanPaiva.Tree
{
    /// <summary>
    /// Class travels down the tree.
    /// </summary>
    class Traveler
    {
        private Node activeNode;

        public Traveler(Node root)
        {
            this.activeNode = root;
        }

     /// <summary>
     /// Travle down the tree.
     /// </summary>
     /// <param name="direction"></param>
     /// <returns>0 if tree over 1 if tree continues</returns>
        public int TravelDown(int direction)
        {
            if(direction == 0)
            {
                this.activeNode = this.activeNode.Left;
            }
            else
            {
                this.activeNode = this.activeNode.Right;
            }

            return this.activeNode == null ? 0 : 1;
        }

        /// <summary>
        /// Consume node text for user
        /// </summary>
        public void Consume()
        {
            this.activeNode.PrintText();
            this.activeNode.PrintOptions();
        }
    }
}
