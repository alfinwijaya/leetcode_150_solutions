public static class _36_Valid_Sudoku
{
    public static bool IsValidSudoku(char[][] board)
    {
        Dictionary<string, bool> checkRow = new();
        Dictionary<char, bool> checkColumn = new();
        Dictionary<string, bool> checkBoxes = new();


        for (int i = 0; i < board.Length; i++)
        {
            checkColumn = new();
            for (int j = 0; j < board[i].Length; j++)
            {
                if (board[i][j] != '.')
                {
                    if (checkColumn.ContainsKey(board[i][j]))
                        return false;

                    checkColumn.Add(board[i][j], true);

                    if (checkRow.ContainsKey($"{board[i][j]}#{j}"))
                        return false;

                    checkRow.Add($"{board[i][j]}#{j}", true);

                    int boxNum = (i / 3) + ((j / 3) * 3);
                    if (checkBoxes.ContainsKey($"{board[i][j]}#{boxNum}"))
                        return false;

                    checkBoxes.Add($"{board[i][j]}#{boxNum}", true);
                }
            }
        }

        return true;
    }
}
