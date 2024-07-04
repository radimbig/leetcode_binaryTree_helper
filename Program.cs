namespace leetcode_104
{
    /**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

    public class Solution
    {
        public int MaxDepth(TreeNode root)
        {
            if(root == null) return 0;
            if(root.left == null && root.right == null) return 1;

            int maxDepth = MaxDepthRecursive(root, 1);

            return maxDepth;

        }
        public int MaxDepthRecursive(TreeNode root, int countedDepth)
        {
            if(root == null) return 0;
            if(root.left == null && root.right == null) return 1;

            int leftMax = MaxDepthRecursive(root.left, countedDepth: countedDepth);
            int RightMax = MaxDepthRecursive(root.right, countedDepth: countedDepth);
            
            return Math.Max(leftMax, RightMax);
        }
    }
    
    

    internal class Program
    {
        static void Main(string[] args)
        {
            //BinaryTreeVisualization.VisualizeFromString("3,9,20,null,null,15,7");

            int?[] values = {3,1,4,3,null,1,5};
            var tree = new BinaryTree(values);

            Console.WriteLine(tree.head.displayNode());
        }

    }
}