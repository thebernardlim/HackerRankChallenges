using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int val = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(Factorial(val));
    }
    
    static int Factorial(int val)
    {
        if (val == 0) return 1;
        return val * Factorial(val - 1);
    }
}