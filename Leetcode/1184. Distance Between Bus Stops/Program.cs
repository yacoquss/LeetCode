var sol = new Solution();
int[] nums = [1, 2, 3, 4];



public class Solution {
    public int DistanceBetweenBusStops(int[] distance, int start, int destination)
    {
        int dist = 0, ccw = 0;
        if (start > destination)
        {
            (start, destination) = (destination, start);
        }

        while (start != destination)
        {
            dist +=distance[start];
            start++;
        }

        ccw += distance.Sum() - dist;
        return Math.Min(dist, ccw);
    }
}