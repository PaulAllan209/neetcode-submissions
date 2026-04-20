public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        var pairs = position.Zip(speed, (a, b) => (Pos: a, Speed: b))
            .OrderByDescending(x => x.Pos)
            .ToArray();

        Stack<decimal> stack = new Stack<decimal>();

        for (int i = 0;  i < pairs.Length; i++)
        {
            decimal currPos = pairs[i].Pos;
            decimal currSpeed = pairs[i].Speed;
            
            decimal toAppend = (target - currPos) / currSpeed;
            stack.Push(toAppend);


            if(stack.Count >= 2 && stack.Peek() <= stack.ElementAt(1))
            {
                stack.Pop();
            }
        }

        return stack.Count;
    }
}
