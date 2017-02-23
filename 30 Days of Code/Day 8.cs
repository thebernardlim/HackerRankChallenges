using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        string sizeInput = Console.ReadLine();
        int dictSize = Convert.ToInt32(sizeInput);
        Dictionary<string, string> dict = new Dictionary<string, string>();
        
        for (int i = 0; i < dictSize; i++)
        {
            string[] dictEntry = Console.ReadLine().Split(' ');
            dict.Add(dictEntry[0], dictEntry[1]);    
        }

        string query = Console.ReadLine();
        while(!string.IsNullOrEmpty(query)) {
            if (dict.ContainsKey(query))
                Console.WriteLine(query + "=" + dict[query]);
            else
                Console.WriteLine("Not found");
            
            query = Console.ReadLine();
        }
        
    }
}