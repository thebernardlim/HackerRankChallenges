using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int m = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        string[] b_temp = Console.ReadLine().Split(' ');
        int[] b = Array.ConvertAll(b_temp,Int32.Parse);
        
        //Sort lists
        Array.Sort<int>(a);  
        Array.Sort<int>(b);
        
        int lastInA = a[n-1];
        int firstInB = b[0];
        int eligibleInts = 0;
        
        bool eligibleA = false;
        bool eligibleB = false;
        
        while (lastInA <= firstInB){
            eligibleA = false;
            eligibleB = false;
            
            for (int i = 0; i < n; i++){
                if (lastInA % a[i] > 0) {
                    eligibleA = false;
                    break;
                }
                else{
                    eligibleA = true;    
                }
            }
            
            for (int j = 0; j < m; j++){
                if (b[j] % lastInA > 0){
                    eligibleB = false;
                    break;
                }
                else{
                    eligibleB = true;
                }
            }
            
            if (eligibleA && eligibleB) eligibleInts++;
            
            lastInA++;
        }
        
        Console.WriteLine(eligibleInts);
    }
}
