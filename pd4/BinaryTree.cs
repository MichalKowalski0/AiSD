namespace pd4
{
    public class BinaryTreeNode
    {
        public int Value;
        public BinaryTreeNode Left;
        public BinaryTreeNode Right;

        public BinaryTreeNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    public class BinaryTree
    {
        public BinaryTreeNode Root;

        public void Add(int value)
        {
            if (Root == null)
            {
                Root = new BinaryTreeNode(value);
            }
            else
            {
                AddRecursive(Root, value);
            }
        }

        private void AddRecursive(BinaryTreeNode node, int value)
        {
            if (value < node.Value)
            {
                if (node.Left == null)
                {
                    node.Left = new BinaryTreeNode(value);
                }
                else
                {
                    AddRecursive(node.Left, value);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new BinaryTreeNode(value);
                }
                else
                {
                    AddRecursive(node.Right, value);
                }
            }
        }
    }
}


