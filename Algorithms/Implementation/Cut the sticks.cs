using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        
        int sticksRemaining = n;
        while (sticksRemaining > 0){
            
            if (sticksRemaining == 0) break;
            Console.WriteLine(sticksRemaining);
            
            int shortestLen = int.MaxValue;
            foreach (int currLen in arr){
                if (currLen < shortestLen && currLen > 0) shortestLen = currLen;
            }

            for (int i = 0; i < arr.Length; i++){
                arr[i] -= shortestLen;
                if (arr[i] == 0) sticksRemaining--;
            }
            
            
        }
        

    }
}
 