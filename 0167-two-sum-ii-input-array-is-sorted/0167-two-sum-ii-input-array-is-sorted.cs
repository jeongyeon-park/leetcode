public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int h = 0;
        int t = numbers.Length - 1;
        int[] result = new int[2];
        while(h < t)
        {
            if(numbers[h] + numbers[t] == target) 
            {
                result[0] = h+1;
                result[1] = t+1;
                break;
            }
            else if(numbers[h] + numbers[t] < target)
                h++;
            else
                t--;
        }

        return result;
    }
}