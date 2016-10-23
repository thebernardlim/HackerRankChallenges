using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string S = Console.ReadLine();
        
        int len = S.Length;
        int noOfSOS = len / 3;
        char[] sosArr = {'S','O','S'};
        
        int currIndex = 0;
        int diffLettersCount = 0;
        
        while (currIndex < len){
            string currBatch = S.Substring(currIndex, 3);
            char[] currChArr = currBatch.ToCharArray();
            
            for (int i = 0; i < 3; i++)
                if (sosArr[i] != currChArr[i]) diffLettersCount++;
            
            currIndex += 3;
        }
        
        Console.WriteLine(diffLettersCount);
    }
}
