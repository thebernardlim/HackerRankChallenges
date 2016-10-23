using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        string input = Console.ReadLine();
        
        bool moreConcatenation = true;
        
        while (input.Length > 0 && moreConcatenation){
            char[] chArr = input.ToCharArray();
            
            for (int i = 0; i < chArr.Length; i++){
                
                if ((i + 1) == chArr.Length) {
                    moreConcatenation = false;
                    break;
                }
                else if (chArr[i] == chArr[i+1])
                {
                    input = input.Substring(0, i) + input.Substring(i + 2);
                    moreConcatenation = true;
                    break;
                }
            }
        }
            

        string finalResult = (input.Length == 0) ? "Empty String" : input;

        Console.WriteLine(finalResult);
        
        
    }
}