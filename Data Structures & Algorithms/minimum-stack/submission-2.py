class MinStack:

    def __init__(self):
        self.curr_stack = []
        self.min_list = []
        

    def push(self, val: int) -> None:
        if not self.min_list:
            self.min_list += [val]
        elif val <= self.min_list[-1]:
            self.min_list += [val]

        self.curr_stack = self.curr_stack + [val]

    def pop(self) -> None:
        if self.curr_stack[-1] == self.min_list[-1]:
            self.min_list.pop()

        self.curr_stack = self.curr_stack[0:-1]

    def top(self) -> int:
        return self.curr_stack[-1]

    def getMin(self) -> int:
        return self.min_list[-1]
        
