using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_a0 = Console.ReadLine().Split(' ');
        int a0 = Convert.ToInt32(tokens_a0[0]);
        int a1 = Convert.ToInt32(tokens_a0[1]);
        int a2 = Convert.ToInt32(tokens_a0[2]);
        string[] tokens_b0 = Console.ReadLine().Split(' ');
        int b0 = Convert.ToInt32(tokens_b0[0]);
        int b1 = Convert.ToInt32(tokens_b0[1]);
        int b2 = Convert.ToInt32(tokens_b0[2]);
        
        string result = "";
        int aliceResult = 0;
        int bobResult = 0;
        
        if (a0 > b0) aliceResult++;
        if (b0 > a0) bobResult++;
        
        if (a1 > b1) aliceResult++;
        if (b1 > a1) bobResult++;
        
        if (a2 > b2) aliceResult++;
        if (b2 > a2) bobResult++;
        
        result += aliceResult + " " + bobResult;
        
        Console.WriteLine(result);
    }
}
