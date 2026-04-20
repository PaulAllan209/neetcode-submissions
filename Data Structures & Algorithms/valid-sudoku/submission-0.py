class Solution:
    def isValidSudoku(self, board: List[List[str]]) -> bool:
        # Row reptition check
        row_rep = [[] for _ in range(9)]
        # Column repitition check
        col_rep = [[] for _ in range(9)]

        # Group repitition check
        group_rep = [[[] for _ in range(3)] for _ in range(3)]

        for row_idx in range(9):
            for col_idx in range(9):
                if(board[row_idx][col_idx] != "."):
                    curr_num = int(board[row_idx][col_idx])
                    if (curr_num in row_rep[row_idx]):
                        return False
                    if (curr_num in col_rep[col_idx]):
                        return False
                    if (curr_num in group_rep[row_idx//3][col_idx//3]):
                        return False
                    
                    row_rep[row_idx].append(curr_num)
                    col_rep[col_idx].append(curr_num)
                    group_rep[row_idx//3][col_idx//3].append(curr_num)
        
        return True
        