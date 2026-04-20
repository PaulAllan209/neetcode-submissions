public class Solution {  
    public List<string> GenerateParenthesis(int n) {
        StringBuilder stack_str = new StringBuilder();

        List<string> return_list = new List<string>();

        void backtrack(int openN, int closeN){
            if(openN == closeN && closeN == n){
                return_list.Add(stack_str.ToString());
            }

            if(openN < n){
                stack_str.Append("(");
                backtrack(openN + 1, closeN);
                stack_str.Remove(stack_str.Length - 1, 1);
            }

            if(closeN < openN){
                stack_str.Append(")");
                backtrack(openN, closeN + 1);
                stack_str.Remove(stack_str.Length - 1, 1);
            }
        }

        backtrack(0, 0);

        return return_list;

    }
}
