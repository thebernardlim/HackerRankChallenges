using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int noOfCases = Convert.ToInt16(Console.ReadLine());
        char[] inputChar = {};
        string evenStr = "";
        string oddStr = "";
        string inpStr = "";
        
        for(int i = 0; i < noOfCases; i++){
            inpStr = Console.ReadLine();
            oddStr = "";
            evenStr = "";
            
            inputChar = inpStr.ToCharArray();
            for (int j = 0; j < inputChar.Length; j++){
                if (j % 2 == 0) evenStr += inputChar[j];
                else oddStr += inputChar[j];
            }

            Console.WriteLine(evenStr + " " + oddStr);
        }
            
        
    }
}