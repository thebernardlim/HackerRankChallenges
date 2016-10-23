using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

class Solution {
    static void Main(String[] args) {
        string input = Console.ReadLine();
        int[] inputs = input.Split(' ').Select(Int32.Parse).ToArray();
        
        int t0 = inputs[0];
        int t1 = inputs[1];
        int index = inputs[2];
        
        BigInteger[] fibSeq = new BigInteger[index];
        fibSeq[0] = t0;
        fibSeq[1] = t1;
        
        for (int i = 2; i < index; i++)
        {
            fibSeq[i] = fibSeq[i - 2] + (fibSeq[i - 1] * fibSeq[i - 1]);
        }
        
        Console.WriteLine(fibSeq[index-1]);
        
    }
}