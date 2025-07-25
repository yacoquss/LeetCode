namespace TestApp._1380._Lucky_Numbers_in_a_Matrix;

public class Solution {
    public IList<int> LuckyNumbers(int[][] matrix) {
        HashSet<int> minRows = new HashSet<int>();
        foreach (var row in matrix) {
            minRows.Add(row.Min());
        }

        HashSet<int> maxCols = new HashSet<int>();
        for (int col = 0; col < matrix[0].Length; col++) {
            int max = matrix[0][col];
            for (int row = 1; row < matrix.Length; row++) {
                if (matrix[row][col] > max) {
                    max = matrix[row][col];
                }
            }
            maxCols.Add(max);
        }

        return minRows.Intersect(maxCols).ToList();
    }
}