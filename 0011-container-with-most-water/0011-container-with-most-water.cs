public class Solution {
    public int MaxArea(int[] height) {
        int head = 0;
        int tail = height.Length-1;
        int max = 0;
        while(head < tail)
        {
            int x = tail - head;
            int y = height[head] < height[tail] ? height[head] : height[tail];
            if (x * y > max) max = x*y;
            if (height[head] < height[tail]) head++;
            else tail --;  
        }
        return max;
    }
}