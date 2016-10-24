using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            long n = Convert.ToInt64(Console.ReadLine());
            
            List<BigInteger> fibList = new List<BigInteger>();
            fibList.Add(1);
            fibList.Add(2);
            
            BigInteger total = 0;
            BigInteger sum = 2;
            int index = 2;
            
            while(total < n){
                total = fibList[index - 2] + fibList[index - 1];
                if (total > n) break;
                fibList.Add(total);
                sum += (total % 2 == 0) ? total : 0;
                index++;
            };
            
            Console.WriteLine(sum);
        }
    }
}
