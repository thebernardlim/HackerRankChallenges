using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string s = Console.ReadLine();
        
        char[] chArr = s.ToCharArray();
        int capsCount = 1;
        foreach (char c in chArr)
            if (c == Char.ToUpper(c)) capsCount++;
        
        Console.WriteLine(capsCount);
    }
}
