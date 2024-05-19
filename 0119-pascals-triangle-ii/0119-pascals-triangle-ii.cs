public class Solution {
    public IList<int> GetRow(int rowIndex) {
        IList<IList<int>> result = new List<IList<int>>();
        
        for(int i = 0 ; i < rowIndex + 1 ; i++)
        {
            List<int> subResult = new List<int>();
            for(int j = 0 ; j < i + 1 ; j++)
            {
                if (j == 0 || j == i) subResult.Add(1);
                else 
                {
                    subResult.Add(result[i-1][j-1] + result[i-1][j]);
                }
            }
            result.Add(subResult);
        }

        return result[rowIndex];
    }
}