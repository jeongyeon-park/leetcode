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
public class Solution {
    int min = int.MaxValue;
    TreeNode prev = null;

    public int GetMinimumDifference(TreeNode root) {
        
        inorderTraverse(root);
        return min;
    }

    void inorderTraverse(TreeNode node)
    {
        if(node == null) return;

        inorderTraverse(node.left);//left node
        if(prev != null)
        {
            min = Math.Min(min, node.val - prev.val );
        }
        prev = node;//current node
        inorderTraverse(node.right);//right node
    }
}