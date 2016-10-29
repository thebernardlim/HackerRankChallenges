using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_s = Console.ReadLine().Split(' ');
        int s = Convert.ToInt32(tokens_s[0]);
        int t = Convert.ToInt32(tokens_s[1]);
        string[] tokens_a = Console.ReadLine().Split(' ');
        int appleStart = Convert.ToInt32(tokens_a[0]);
        int orangeStart = Convert.ToInt32(tokens_a[1]);
        string[] tokens_m = Console.ReadLine().Split(' ');
        int appleCount = Convert.ToInt32(tokens_m[0]);
        int orangeCount = Convert.ToInt32(tokens_m[1]);
        string[] apple_temp = Console.ReadLine().Split(' ');
        int[] apple = Array.ConvertAll(apple_temp,Int32.Parse);
        string[] orange_temp = Console.ReadLine().Split(' ');
        int[] orange = Array.ConvertAll(orange_temp,Int32.Parse);
        
        int appInCount = 0;
        foreach (int app in apple){
            int currApp = appleStart + app;
            if (currApp >= s && currApp <= t) appInCount++;
        }
        
        int orgInCount = 0;
        foreach (int org in orange){
            int currOrg = orangeStart + org;
            if (currOrg >= s && currOrg <= t) orgInCount++;
        }
        
        Console.WriteLine(appInCount);
        Console.WriteLine(orgInCount);
        
    }
}
