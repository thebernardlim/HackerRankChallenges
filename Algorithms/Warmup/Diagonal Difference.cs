using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];
        for(int a_i = 0; a_i < n; a_i++){
           string[] a_temp = Console.ReadLine().Split(' ');
           a[a_i] = Array.ConvertAll(a_temp,Int32.Parse);

        }
        
        int priDiag = 0;
        int secDiag = 0;
                    
        for (int i = 0; i < n; i++){
            priDiag += a[i][i];
        }
        
        int y = n-1;
        for (int x = 0; x < n; x++ , y--)
            secDiag += a[x][y];
        
        int diff = priDiag - secDiag;
        if (diff < 0) diff *= -1;
        
        Console.WriteLine(diff);
        
    }
}
