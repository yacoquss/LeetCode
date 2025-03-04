﻿namespace TestApp._190._Reverse_Bits;

public class Solution {
    public uint reverseBits(uint n) {
        uint res = 0;
        for (int i = 0; i < 32; i++) {
            res = res << 1;       
            res += (n & 1);        
            n = n >> 1;            
        }
        return res;
    }
}
