using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Security;

 class ClearingCommands
{
    private static void Main()
    {
        List<char[]> board = new List<char[]>();
        string commandChars = "><^v";
        string inputLine;
        while ((inputLine = Console.ReadLine()) != "END")
        {
            board.Add(inputLine.ToCharArray());
        }
        for (int row = 0; row < board.Count; row++)
        {
            for (int col = 0; col < board[row].Length; col++)
            {
                int colRemove;
                int rowRemove;
                switch (board[row][col])
                {
                    case '>':
                        colRemove = col + 1;
                        while (colRemove < board[row].Length && !commandChars.Contains(board[row][colRemove].ToString()))
                        {
                            board[row][colRemove] = ' ';
                            colRemove++;
                        }
                        break;
                    case '<':
                        colRemove = col - 1;
                        while (colRemove >= 0 && !commandChars.Contains(board[row][colRemove].ToString()))
                        {
                            board[row][colRemove] = ' ';
                            colRemove--;
                        }
                        break;
                    case '^':
                        rowRemove = row - 1;
                        while (rowRemove >= 0 && !commandChars.Contains(board[rowRemove][col].ToString()))
                        {
                            board[rowRemove][col] = ' ';
                            rowRemove--;
                        }
                        break;
                    case 'v':
                        rowRemove = row + 1;
                        while (rowRemove < board.Count && !commandChars.Contains(board[rowRemove][col].ToString()))
                        {
                            board[rowRemove][col] = ' ';
                            rowRemove++;
                        }
                        break;
                }
            }
        }
        foreach (char[] line in board)
        {
            Console.WriteLine("<p>" + System.Security.SecurityElement.Escape(new string(line)) + "</p>");
        }

    }
}