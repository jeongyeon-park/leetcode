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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        List<IList<int>> result = new List<IList<int>>();
        if(root == null) return result;
        queue.Enqueue(root);
        while(queue.Count > 0)
        {
            int countLen = queue.Count;
            List<int> subList = new List<int>();
            

            for(int i=0 ; i < countLen; i++)
            {
                TreeNode node = queue.Dequeue();
                subList.Add(node.val);
                if(node.left != null) queue.Enqueue(node.left);
                if(node.right != null) queue.Enqueue(node.right);
            }
            result.Add(subList);
        }
        return result;
    }
}