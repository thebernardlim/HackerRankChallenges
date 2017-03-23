using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
class Solution {

    static void Main(String[] args) {
        string n = Console.ReadLine();
        BigInteger input = BigInteger.Parse(n);
        
        int num = Convert.ToInt16(n);
        num--;
        for (int i = num; i > 0; i--){
            input *= i;
        }
        
        Console.WriteLine(input);
    }
}
