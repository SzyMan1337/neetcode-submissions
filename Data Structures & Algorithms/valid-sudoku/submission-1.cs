public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        int size = 9;
        var cols = new List<HashSet<char>>(size);
        var rows = new List<HashSet<char>>(size);
        var boxes = new List<HashSet<char>>(size);

        for (int i = 0; i < size; i++)
        {
            cols.Add(new HashSet<char>());
            rows.Add(new HashSet<char>());
            boxes.Add(new HashSet<char>());
        }

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                char c = board[i][j];

                if (c != '.' && (cols[j].Contains(c) || rows[i].Contains(c) || boxes[(i / 3) * 3 + j / 3].Contains(c)))
                {
                    return false;
                }
                cols[j].Add(c);
                rows[i].Add(c);
                boxes[(i / 3) * 3 + j / 3].Add(c);
            }
        }

        return true;
    }
}
