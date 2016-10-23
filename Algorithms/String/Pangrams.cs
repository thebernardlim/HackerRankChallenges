using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        string input = Console.ReadLine();
        
        Dictionary<char, int> charList = new  Dictionary<char,int>();
        string alphabets = "abcdefghijklmnopqrstuvwxyz";
        char[] aplArr = alphabets.ToCharArray();
        
        foreach(char c in aplArr){
            charList.Add(c, 0);
        }
        
        char[] inputChr = input.ToLower().ToCharArray();
        foreach (char c in inputChr){
            
            if (c != ' ') charList[c] += 1;
        }
        
        bool largerThanZero = true;
        foreach (KeyValuePair<char, int> kvPair in charList)
            if (kvPair.Value == 0) largerThanZero = false;
        
        string result = (largerThanZero) ? "pangram" : "not pangram";
        
        Console.WriteLine(result);
            
        
        
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
    }
}