using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        
        int positiveTotal = 0;
        int negativeTotal = 0;
        int zeroTotal = 0;
        
        foreach (int i in arr)
        {
            if (i > 0) positiveTotal++;
            if (i < 0) negativeTotal++;
            if (i == 0) zeroTotal++;
        }
        
        decimal total = n;
        
        //Console.WriteLine(n + ", " + positiveTotal + ", " + negativeTotal + ", " + zeroTotal);
        
        decimal positive = positiveTotal / total;
        decimal negative = negativeTotal / total;
        decimal zero = zeroTotal / total;
        
        Console.WriteLine(positive);
        Console.WriteLine(negative);
        Console.WriteLine(zero);
        
        
    }
}

