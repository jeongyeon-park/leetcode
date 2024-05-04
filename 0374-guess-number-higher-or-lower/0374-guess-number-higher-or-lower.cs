/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        int left = 1;
        int right = n;

        while(left <= right)
        {
            int mid = left + (right - left) / 2;
            int result = guess(mid);
            if (result == 0 ) return mid;
            else if(result == -1)
            {
                // pick 보다 mid가 크다. 
                // mid 보다 작은 범위 탐색
                right = mid - 1;
            }
            else 
            {
                // pick 보다 mid가 작다. 
                // mid 보다 큰 범위 탐색. 
                left = mid + 1;
            }
        }
        return -1;
    }
}