using System;

class GameBoard
{
    static char[,] board;

    public static void SetupBoard()
    {
        board = new char[ , ] {
            { 'O', 'X', 'X', },   // board[0]
            { 'O', 'X', 'O', },   // board[1]
            { 'X', 'X', 'O', },   // board[2]
            //[0]  [1]  [2]
        };
    }

    public static void PrintBoard()
    {

        Console.WriteLine("playing board");

        for (int i = 0; i < 3; i++)
        {
            for (int f = 0; f < 3; f++)  // row
                Console.Write(board[i, f]);

            Console.WriteLine();  // break betwwen rows
        }

        Console.WriteLine("=====================");
    }

    static void CheckWinners()
    {
        int num = 0;

        num = Matrix.CountRow(board, 0, 'X');  // count X in top row
        Console.WriteLine("number of X in the top row is " + num);

        num = Matrix.CountRow(board,1,'X');  
        Console.WriteLine("number of X in the middle row is " + num);

        num = Matrix.CountRow(board, 2, 'X');   
        Console.WriteLine("number of X in the bottom row is " + num);

        num = Matrix.CountColumn(board, 0, 'X');   // count X in left column
        Console.WriteLine("number of X in the left column is " + num);

        num = Matrix.CountColumn(board, 1, 'X');   
        Console.WriteLine("number of X in the middle column is " + num);

        num = Matrix.CountColumn(board, 2, 'X');  
        Console.WriteLine("number of X in the right column is " + num);

        num = Matrix.CountMainDiagonal(board);
        Console.WriteLine("number of X in the main diagonal is " + num);

        // c

        if (true)
            return;

        if (num == 3)
            Console.WriteLine("X wins in row 1 on board");

        num = Matrix.CountMainDiagonal(board);
        if (num == 3)
            Console.WriteLine("X wins on main diagonal");

        num = Matrix.CountSecondDiagonal(board);
        if (num == 3)
            Console.WriteLine("X wins on second diagonal");
    }

    static void Main(string[] args)
    {
        SetupBoard();
        PrintBoard();
        CheckWinners();

        Console.WriteLine("Press Enter to Quit");
        Console.ReadLine();
    }
}

