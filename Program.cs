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