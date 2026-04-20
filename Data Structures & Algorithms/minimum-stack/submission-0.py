class MinStack:

    def __init__(self):
        self.curr_stack = []
        

    def push(self, val: int) -> None:
        self.curr_stack = self.curr_stack + [val]

    def pop(self) -> None:
        self.curr_stack = self.curr_stack[0:-1]

    def top(self) -> int:
        return self.curr_stack[-1]

    def getMin(self) -> int:
        return min(self.curr_stack)
        
