using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        
        int days = Convert.ToInt16(Console.ReadLine());

        decimal pplReached = 5;
        decimal noOfLikes = 0;
        
        decimal totalLikes = 0;
        
        for(int i = 0; i < days; i++)
        {
            noOfLikes = Math.Floor(pplReached/2);
            totalLikes += noOfLikes;
            pplReached = noOfLikes * 3;
        }
        
        Console.WriteLine(totalLikes);
        
    }
}