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
    Queue<TreeNode> queue = new Queue<TreeNode>();
    List<double> result = new List<double>();
    long sumInSameLevel = 0;
    int cntInSameLevel = 0;
   
    public IList<double> AverageOfLevels(TreeNode root) {
        queue.Enqueue(root);
        traverse();
        return result;
    }
     private void  traverse()
    {
        while(queue.Count > 0)
        {
            cntInSameLevel = queue.Count;
            for(int i = 0; i<cntInSameLevel; i++)
            {
                TreeNode tmpnode = queue.Dequeue();
                sumInSameLevel += tmpnode.val;
                if(tmpnode.left != null) queue.Enqueue(tmpnode.left);
                if(tmpnode.right != null) queue.Enqueue(tmpnode.right);
            }
            result.Add((double)sumInSameLevel / (double)cntInSameLevel);
            sumInSameLevel = 0;
            cntInSameLevel = 0;
        }
    }
}