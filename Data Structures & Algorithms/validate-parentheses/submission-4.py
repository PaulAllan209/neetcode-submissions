class Solution:
    def isValid(self, s: str) -> bool:
        s = list(s)
        str_openings_stack = []

        for char in s:
            if (char == '(') or (char == '{') or (char == '['):
               str_openings_stack.append(char)
            else:
                if str_openings_stack:
                    if char == ')':
                        if str_openings_stack[-1] == '(':
                            str_openings_stack.pop()
                            continue
                        else:
                            return False
                    elif char == '}':
                        if str_openings_stack[-1] == '{':
                            str_openings_stack.pop()
                            continue
                        else:
                            return False
                    elif char == ']':
                        if str_openings_stack[-1] == '[':
                            str_openings_stack.pop()
                            continue
                        else:
                            return False
                else:
                    return False
        
        if str_openings_stack:
            return False
        else:
            return True