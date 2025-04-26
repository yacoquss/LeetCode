namespace TestApp._1108._Defanging_an_IP_Address;

public class program
{
    
}


public class Solution {
    public string DefangIPaddr(string address) {
        return address.Replace(".", "[.]");
    }
}