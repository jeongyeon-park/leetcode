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
    public TreeNode SortedArrayToBST(int[] nums) {
        return MakeNodes(nums, 0 , nums.Length - 1);
    }

    public TreeNode MakeNodes(int[] nums, int left, int right)
    {
        if(left > right) return null;
        //Get mid node
        //Prevent Overflow
        int midIdx = left + (right - left) / 2;
        int midNodeVal = nums[midIdx];
        TreeNode result = new TreeNode(midNodeVal);
        result.left = MakeNodes(nums, left, midIdx - 1);
        result.right = MakeNodes(nums, midIdx+1, right);
        return result;
    }
}