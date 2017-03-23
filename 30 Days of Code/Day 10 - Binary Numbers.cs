using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int remainder;
        List<int> binaryList = new List<int>();
        
        //Get remainders as this will result in binary number
        while(n > 0){
            remainder = n%2;
            n = n/2;
            binaryList.Add(remainder);
        }
        
        //Split into string arrays, then iterate through each substring and compare length to get the largest length
        string binaryResult = String.Join("", binaryList);
        string[] splittedArr = binaryResult.Split('0');
        int maxLength = 0;
        foreach (string s in splittedArr)
            if (s.Length > maxLength) maxLength = s.Length;
            
        Console.WriteLine(maxLength);

    }
}