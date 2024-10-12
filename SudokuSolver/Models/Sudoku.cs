namespace SudokuSolver.Models
{
    public class Sudoku
    {
        public int[][] Board { get; set; }

        public Sudoku()
        {
            Board = new int[9][];
            for(int i = 0; i < 9; i++)
            {
                Board[i] = new int[9];
            }
        }
    }
}
