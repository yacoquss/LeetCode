namespace TestApp._94._Binary_Tree_Inorder_Traversal;


public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> result = new List<int>(); 
        InorderHelper(root, result);        
        return result;
    }
    
    private void InorderHelper(TreeNode node, List<int> list) {
        if (node == null) return;
        
        InorderHelper(node.left, list);  
        list.Add(node.val);              
        InorderHelper(node.right, list); 
    }
}