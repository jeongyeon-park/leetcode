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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        List<IList<int>> result = new List<IList<int>>();
        if(root == null) return result;
        queue.Enqueue(root);
        while(queue.Count > 0)
        {
            List<int> subList = new List<int>();
            int lenOfQueue = queue.Count;
            List<TreeNode> nodeList = new List<TreeNode>();
            for (int i = 0; i < lenOfQueue; i++)
            {
                TreeNode node = queue.Dequeue();
                nodeList.Add(node);
                if(node.left != null) queue.Enqueue(node.left);
                if(node.right != null) queue.Enqueue(node.right);
            }
            
            int lenOfResult = result.Count;
            if(lenOfResult % 2 == 0)
            {
                for(int j = 0; j < nodeList.Count ; j++)
                {
                    subList.Add(nodeList[j].val);
                }
            }
            else
            {
                for(int j = nodeList.Count - 1; j >= 0 ; j--)
                {
                    subList.Add(nodeList[j].val);
                }
            }
            result.Add(subList);
        }
        return result;
    }
}