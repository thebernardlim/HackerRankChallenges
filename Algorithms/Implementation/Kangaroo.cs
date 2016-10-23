using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_x1 = Console.ReadLine().Split(' ');
        int x1 = Convert.ToInt32(tokens_x1[0]);
        int v1 = Convert.ToInt32(tokens_x1[1]);
        int x2 = Convert.ToInt32(tokens_x1[2]);
        int v2 = Convert.ToInt32(tokens_x1[3]);
        
        string result = "NO";
        
        for (int i = 1; i <= 100000; i++){
            int firstPos = x1 + (v1 * i);
            int secondPos = x2 + (v2 * i);
            
            if (firstPos == secondPos){
                result = "YES";
                break;
            }
        
        }
        
        Console.WriteLine(result);
    }
}
