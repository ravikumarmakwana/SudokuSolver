using Microsoft.AspNetCore.Mvc;
using SudokuSolver.Business;
using SudokuSolver.Models;

namespace SudokuSolver.Controllers
{
    public class SudokuController : Controller
    {
        private readonly ISudokuService _sudokuService;

        public SudokuController(ISudokuService sudokuService)
        {
            _sudokuService = sudokuService;
        }

        public IActionResult Index()
        {
            return View(new Sudoku());
        }

        [HttpPost]
        public IActionResult Solve()
        {
            Sudoku sudoku = new Sudoku();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    sudoku.Board[i][j] = int.Parse(Request.Form[$"Board[{i}][{j}]"]);
                }
            }
            _sudokuService.SudokuSolver(sudoku.Board);
            return View("Index", sudoku);
        }

        public IActionResult Clear()
        {
            return View("Index", new Sudoku());
        }
    }
}
