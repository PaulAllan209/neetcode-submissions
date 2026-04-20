public class Solution {
    public int EvalRPN(string[] tokens) {
        List<int> num_stack = new List<int>();
        int left_val = 0;
        int right_val = 0;

        foreach(string token in tokens){
            if (token == "+"){
                left_val = num_stack[num_stack.Count - 1];
                num_stack.RemoveAt(num_stack.Count - 1);

                right_val = num_stack[num_stack.Count - 1];
                num_stack.RemoveAt(num_stack.Count - 1);

                num_stack.Add(right_val + left_val);
            } 
            else if (token == "-"){
                left_val = num_stack[num_stack.Count - 1];
                num_stack.RemoveAt(num_stack.Count - 1);

                right_val = num_stack[num_stack.Count - 1];
                num_stack.RemoveAt(num_stack.Count - 1);

                num_stack.Add(right_val - left_val);
            }
            else if (token == "*"){
                left_val = num_stack[num_stack.Count - 1];
                num_stack.RemoveAt(num_stack.Count - 1);

                right_val = num_stack[num_stack.Count - 1];
                num_stack.RemoveAt(num_stack.Count - 1);

                num_stack.Add(right_val*left_val); 
            }
            else if (token == "/"){
                left_val = num_stack[num_stack.Count - 1];
                num_stack.RemoveAt(num_stack.Count - 1);

                right_val = num_stack[num_stack.Count - 1];
                num_stack.RemoveAt(num_stack.Count - 1);

                num_stack.Add(right_val/left_val);
            }
            else {
                num_stack.Add(int.Parse(token));
            }
        }

        return(num_stack[num_stack.Count - 1]);
    }
}
