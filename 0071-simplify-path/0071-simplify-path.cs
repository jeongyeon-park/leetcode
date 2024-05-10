public class Solution {
    public string SimplifyPath(string path) {
        //먼저 /로 분리해서 string array 생성
        //분리한 후 stack 에 넣고 .. 값일때 pop 해주면 됨
        string[] splited = path.Split('/');
        Stack<string> stack = new Stack<string>();
        StringBuilder result = new StringBuilder();
        foreach (string i in splited)
        {
            if(i.Equals("..")) 
            {
                if(stack.Count > 0) stack.Pop();
            }
            else if(String.IsNullOrEmpty(i) || i.Equals(".")) continue;
            else stack.Push("/" + i);
        }

        while(stack.Count > 0)
        {
            result.Insert(0, stack.Pop());
        }

        return result.ToString().Length > 0 ? result.ToString() : "/";
    }
}