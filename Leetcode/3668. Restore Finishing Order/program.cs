namespace TestApp._3668._Restore_Finishing_Order;

public class program
{
    public class Solution {
        public int[] RecoverOrder(int[] order, int[] friends) {
            List<int> list = new List<int>();
            foreach (var num in order)
            {
                if(friends.Contains(num)) list.Add(num);
            }
            return list.ToArray();
        }
    }
}