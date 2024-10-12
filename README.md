# Sudoku Solver

## Description
A simple Sudoku solver application built using ASP.NET Core. This application allows users to input a Sudoku puzzle and get the solved output.
The Sudoku solver uses a **Backtracking Algorithm**, which is a form of **Recursion**. The algorithm attempts to fill the Sudoku board by placing digits (1 to 9) in empty cells and recursively checking if the board remains valid. If a digit placement leads to an invalid board state, the algorithm backtracks by removing the digit and trying the next possible digit.

![chrome_dN7nn7qPmj](https://github.com/user-attachments/assets/9c350ca9-f320-4022-b6f8-6a4f36a522a6)

![chrome_Sqx6QkuPnZ](https://github.com/user-attachments/assets/6b0df866-395b-4f60-befc-7a0b4da27ee3)

## Time Complexity
- **O(9^(N*N))**
- **O(9^81)**

## Space Complexity
- **O(1)**

## Technologies Used
- C#
- ASP.NET Core MVC
- HTML/CSS
