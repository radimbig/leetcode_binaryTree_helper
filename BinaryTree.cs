using System.Text;

namespace leetcode_104
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public string displayNode()
        {
            StringBuilder output = new StringBuilder();
            displayNode(output, 0);
            return output.ToString();
        }

        private void displayNode(StringBuilder output, int depth)
        {
            if (right != null)
                right.displayNode(output, depth + 1);

            output.Append('\t', depth);
            output.AppendLine(val.ToString());

            if (left != null)
                left.displayNode(output, depth + 1);
        }
    }

    public class BinaryTree
    {
        public TreeNode head;

        public bool IsItCreatedByUsingLeetCodeFormant = false;
        public int?[] UsedValuesOnCreation;

        public BinaryTree(TreeNode head)
        {
            if (head == null)
                throw new ArgumentNullException();
            this.head = head;
        }

        public BinaryTree(int?[] leetCodeFormatTreeIncludingHead)
        {
            head = new TreeNode(0);
            if (leetCodeFormatTreeIncludingHead.Length == 0)
                throw new ArgumentException("Empty values array");
            if (leetCodeFormatTreeIncludingHead[0] != null)
            {
                head.val = leetCodeFormatTreeIncludingHead[0].Value;
            }
            else
            {
                throw new ArgumentException("No value for head");
            }

            IsItCreatedByUsingLeetCodeFormant = true;
            UsedValuesOnCreation = leetCodeFormatTreeIncludingHead;

            int nextItem = 0;
            head.val = leetCodeFormatTreeIncludingHead[nextItem++].Value;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(head);

            while (queue.Count > 0 && nextItem < leetCodeFormatTreeIncludingHead.Length)
            {
                TreeNode current = queue.Dequeue();
                if (nextItem < leetCodeFormatTreeIncludingHead.Length)
                {
                    int? item = leetCodeFormatTreeIncludingHead[nextItem++];

                    if (item != null)
                    {
                        TreeNode node = new TreeNode(item.Value);
                        current.left = node;
                        queue.Enqueue(node);
                    }
                }
                if (nextItem < leetCodeFormatTreeIncludingHead.Length)
                {
                    int? item = leetCodeFormatTreeIncludingHead[nextItem++];
                    if (item != null)
                    {
                        TreeNode node = new TreeNode(item.Value);
                        current.right = node;
                        queue.Enqueue(node);
                    }
                }
            }
        }

        public void PrintTree()
        {
            Console.WriteLine(head.displayNode());
        }
    }
}
