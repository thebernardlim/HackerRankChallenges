using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int[][] arr = new int[6][];
        for(int arr_i = 0; arr_i < 6; arr_i++){
           string[] arr_temp = Console.ReadLine().Split(' ');
           arr[arr_i] = Array.ConvertAll(arr_temp,Int32.Parse);
        }
        
        int maxSum = -64;
        int currentSum;
        
        for (int y = 0; y < 4; y++)
        {
            currentSum = 0;
            for (int x = 0; x < 4; x++){
                currentSum = arr[y][x] + arr[y][x+1] + arr[y][x+2] + arr[y+1][x+1] + arr[y+2][x] + arr[y+2][x+1] + arr[y+2][x+2];
                if (currentSum > maxSum) maxSum = currentSum;
            }
        }  
        
        Console.WriteLine(maxSum);
    }
}
