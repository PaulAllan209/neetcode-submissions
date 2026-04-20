public class Solution {
    public int EvalRPN(string[] tokens) {
        List<int> num_stack = new List<int>();
        int left_val = 0;
        int right_val = 0;

        // for i in tokens:
        //     if i == "+":
        //         left_val = num_stack.pop()
        //         right_val = num_stack.pop()
        //         num_stack += [right_val + left_val]
        //     elif i == "-":
        //         left_val = num_stack.pop()
        //         right_val = num_stack.pop()
        //         num_stack += [right_val - left_val]
        //     elif i == "*":
        //         left_val = num_stack.pop()
        //         right_val = num_stack.pop()
        //         num_stack += [right_val * left_val]
        //     elif i == "/":
        //         left_val = num_stack.pop()
        //         right_val = num_stack.pop()
        //         num_stack += [right_val / left_val]
        //     else:
        //         num_stack.append(int(i))
        
        // return int(num_stack[-1])

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
