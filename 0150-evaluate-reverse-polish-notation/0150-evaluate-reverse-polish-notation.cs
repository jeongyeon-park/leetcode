public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        int num1 = 0;
        int num2 = 0;
        foreach(string token in tokens)
        {
            if (token == "+")
            {
                num2 = stack.Pop();
                num1 = stack.Pop();
                stack.Push(num1 + num2);
            }
            else if (token == "-")
            {
                num2 = stack.Pop();
                num1 = stack.Pop();
                stack.Push(num1 - num2);
            }
            else if (token == "*")
            {
                num2 = stack.Pop();
                num1 = stack.Pop();
                stack.Push(num1 * num2);
            }
            else if (token == "/")
            {
                num2 = stack.Pop();
                num1 = stack.Pop();
                stack.Push(num1 / num2);
            }
            else 
            {
                stack.Push(Int32.Parse(token));
            }
        }
        return stack.Pop();
    }
}