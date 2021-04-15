//https://leetcode.com/problems/add-two-numbers
//https://leetcode.com/submissions/detail/480826524/
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode result = null;
        
        var temp1 = GetNodeValueToDouble(l1);
        var temp2 = GetNodeValueToDouble(l2);
        
        var d = temp1 + temp2;

        result = MakeNode(ReverseString(d.ToString()));
        
        return result;
    }
    
    private BigInteger GetNodeValueToDouble(ListNode node)
    {
        var temp = SearchNode(node);
        var reverseTemp = ReverseString(temp);
        
        var result = BigInteger.Parse(reverseTemp);
        return result;
    }
    
    private int GetNumber(char ch)
    {
        return ch - '0';
    }
    
    private ListNode MakeNode(string str)
    {
        if(str.Length <= 0)
            return new ListNode();
        
        ListNode node = new ListNode(GetNumber(str[0]), null);
        
        ListNode tempNode = node;
        for(int i = 1; i < str.Length; ++i, tempNode = tempNode.next)
        {
            int val = GetNumber(str[i]);
            tempNode.next = new ListNode(val, null);
        }
        
        return node;
    }
                                                 
    private string SearchNode(ListNode node)
    {
        string temp = node.val.ToString();
        while(node.next != null)
        {
            node = node.next;
            int val = node.val;
            temp += val.ToString();
        }
        
        return temp;
    }
    
    private string ReverseString(string str)
    {
        string result = "";
        
        char[] array = str.ToCharArray();
        Array.Reverse(array);
        result = new string(array);
        
        return result;
    }
}
