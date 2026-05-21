public class Solution {
    public int MaxArea(int[] heights) {
        var area = -1;
        for (int i = 0; i < heights.Length; i++) {
            for (int j = i + 1; j < heights.Length; j++) {
                int curentArea = Math.Min(heights[i], heights[j]) * (j - i);
                if (curentArea > area) {
                    area = curentArea;
                }
            }
        }
        return area;
    }
}
