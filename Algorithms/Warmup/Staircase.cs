using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        
        string[] result = new string[n];
        List<string> resultList = new List<string>();
        
        char blank = ' ';
        char hash = '#';
        
        int blankIndex = (n-1);
        
        for (int hashIndex = 1; hashIndex <= n; hashIndex++ , blankIndex--)
        {
            string thisLine = "";
            for (int j = 0; j < blankIndex; j++)
                thisLine += blank;
           
            for (int i = 0; i < hashIndex; i++)
                thisLine += hash;
            
            resultList.Add(thisLine);
        }
        
        result = resultList.ToArray();
        
        for (int k = 0; k < n; k++)
            Console.WriteLine(result[k]);
            
    }
}
