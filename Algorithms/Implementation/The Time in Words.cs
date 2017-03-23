using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int h = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());
        
        Dictionary<int, string> numDict = new Dictionary<int, string>();
        string[] numWords = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
                             "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty"};
        
        for(int i = 0; i < numWords.Length; i++)
        {
            numDict.Add(i, numWords[i]);
        }
        
        for(int i = 21; i <= 29; i++)
        {
            int mod = i % 20;
            numDict.Add(i, "twenty " + numDict[mod]);
        }

        string result = "";
        
        //General cases
        if (m > 1 && m < 30) result = numDict[m] + " minutes past " + numDict[h];
        if (m > 30) result = numDict[(60 - m)] + " minutes to "  + numDict[(h+1)];
        
        //Specialized cases
        if (m == 0) result = numDict[h] + " o' clock";
        if (m == 1) result = numDict[m] + " minute past " + numDict[h];
        if (m == 15) result = "quarter past " + numDict[h];
        if (m == 30) result = "half past " + numDict[h];
        if (m == 45) result = "quarter to " + numDict[(h+1)];
        if (m == 59) result = numDict[(60 - m)] + " minute to "  + numDict[(h+1)];
        
        Console.WriteLine(result);
    }
}
