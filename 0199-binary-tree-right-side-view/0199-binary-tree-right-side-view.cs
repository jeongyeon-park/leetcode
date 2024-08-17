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
    public IList<int> RightSideView(TreeNode root) {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        if(root != null) queue.Enqueue(root);
        List<int> result = new List<int>();

        while(queue.Count > 0)
        {
            int cnt = queue.Count;
            
            for(int i = 0 ; i<cnt ; i++)
            {
                TreeNode tmpNode = queue.Dequeue();
                if (i == cnt-1) result.Add(tmpNode.val);
                if(tmpNode.left != null) queue.Enqueue(tmpNode.left);
                if(tmpNode.right != null) queue.Enqueue(tmpNode.right);
            }
        }

        return result;
    }
}