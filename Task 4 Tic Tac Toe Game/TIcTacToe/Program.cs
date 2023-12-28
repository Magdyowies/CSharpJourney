using System;
using System.IO;

class Program
{
    static void Main()
    {
        int userWins = LoadUserWins(); // Load user wins from file
        Console.WriteLine($"Welcome to Tic Tac Toe! User Wins: {userWins}");

        do
        {
            PlayGame(ref userWins);
            Console.Write("Do you want to play again? (y/n): ");
        } while (Console.ReadLine().Trim().ToLower() == "y");

        SaveUserWins(userWins); // Save user wins to file
        Console.WriteLine("Thanks for playing! Goodbye.");
    }

    static void PlayGame(ref int userWins)
    {
        char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        int currentPlayer = 1; // 1 for X, 2 for O
        int choice;
        bool validMove;

        do
        {
            DisplayBoard(board);
            Console.WriteLine($"Player {currentPlayer}'s turn. Enter a number (1-9): ");
            validMove = int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 9 && board[choice - 1] == (char)(choice + '0');

            if (validMove)
            {
                board[choice - 1] = (currentPlayer == 1) ? 'X' : 'O';
                currentPlayer = 3 - currentPlayer; // Switch player (1 to 2 or 2 to 1)
            }
            else
            {
                Console.WriteLine("Invalid move. Please try again.");
            }
        } while (!CheckForWin(board) && !IsBoardFull(board));

        DisplayBoard(board);

        if (CheckForWin(board))
        {
            Console.WriteLine($"Player {3 - currentPlayer} wins!");
            if (currentPlayer == 1)
            {
                userWins++;
            }
        }
        else
        {
            Console.WriteLine("It's a draw!");
        }
    }

    static void DisplayBoard(char[] board)
    {
        Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
        Console.WriteLine("---|---|---");
        Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
        Console.WriteLine("---|---|---");
        Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
    }

    static bool CheckForWin(char[] board)
    {
        // Check rows, columns, and diagonals for a win
        for (int i = 0; i < 3; i++)
        {
            if (board[i * 3] == board[i * 3 + 1] && board[i * 3 + 1] == board[i * 3 + 2])
                return true;

            if (board[i] == board[i + 3] && board[i + 3] == board[i + 6])
                return true;
        }

        if (board[0] == board[4] && board[4] == board[8])
            return true;

        if (board[2] == board[4] && board[4] == board[6])
            return true;

        return false;
    }

    static bool IsBoardFull(char[] board)
    {
        // Check if the board is full
        foreach (char cell in board)
        {
            if (cell != 'X' && cell != 'O')
                return false;
        }
        return true;
    }

    static int LoadUserWins()
    {
        // Load user wins from file or return 0 if the file doesn't exist
        string filePath = "user_wins.txt";
        if (File.Exists(filePath))
        {
            string content = File.ReadAllText(filePath);
            if (int.TryParse(content, out int wins))
            {
                return wins;
            }
        }
        return 0;
    }

    static void SaveUserWins(int userWins)
    {
        // Save user wins to file
        string filePath = "user_wins.txt";
        File.WriteAllText(filePath, userWins.ToString());
    }
}
