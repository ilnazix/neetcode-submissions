public class Solution {
    public bool IsValidSudoku(char[][] board) {
        
        var rows = Enumerable.Range(0, 9).ToDictionary(x => x, x => new HashSet<int>());
        var cols = Enumerable.Range(0, 9).ToDictionary(x => x, x => new HashSet<int>());
        var quads = new Dictionary<(int, int), HashSet<int>>();

        for(int i = 0; i < 3; i++)
            for(int j = 0; j < 3; j++)
                quads.Add((i, j), new HashSet<int>());

        for(int r = 0; r < 9; r++){
            for(int c = 0; c < 9; c++){
                if(board[r][c] == '.') continue;
                var e = board[r][c];

                if(rows[r].Contains(e) 
                    || cols[c].Contains(e)
                    || quads[((int)r/3, (int)c/3)].Contains(e))
                        return false;

                rows[r].Add(e); 
                cols[c].Add(e);
                quads[((int)r/3, (int)c/3)].Add(e);
            }
        }

        return true;
    }
}
