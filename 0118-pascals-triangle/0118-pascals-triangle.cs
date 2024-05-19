public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> result = new List<IList<int>>();
        result.Add(new List<int>{1});
        for(int i = 1; i < numRows ; i++)
        {
            IList<int> subValue = new List<int>();
            for(int j = 0 ; j < i+1 ; j++)
            {
                if(j == 0 || j == i) subValue.Add(1);
                else 
                {
                    subValue.Add(result[i-1][j-1] + result[i-1][j]);
                }  
            }
            result.Add(subValue);
        }
        return result;
    }
}