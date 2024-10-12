namespace SudokuSolver.Business
{
    public class SudokuService : ISudokuService
    {
        public bool SudokuSolver(int[][] board)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] == 0)
                    {
                        for (int k = 1; k <= 9; k++)
                        {
                            if (IsValid(board, i, j, k))
                            {
                                board[i][j] = k;
                                if (SudokuSolver(board))
                                {
                                    return true;
                                }
                                board[i][j] = 0;
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }

        private bool IsValid(int[][] board, int row, int col, int val)
        {
            for (int i = 0; i < 9; i++)
            {
                if (board[row][i] == val)
                {
                    return false;
                }

                if (board[i][col] == val)
                {
                    return false;
                }

                if (board[3 * (row / 3) + (i % 3)][3 * (col / 3) + (i / 3)] == val)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
