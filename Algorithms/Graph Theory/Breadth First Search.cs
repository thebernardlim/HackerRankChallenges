using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Collections;

class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        
        int queries = Convert.ToInt16(Console.ReadLine());
        string[] results = new string[queries];
        
        for (int j = 0; j < queries; j++)
        {
            int[] firstLine = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
            int noOfNodes = firstLine[0];

            Hashtable table = new Hashtable();
            for (int i = 0; i <= noOfNodes; i++)
            {
                table.Add(i, new List<int>());
            }

            int edges = firstLine[1];
            for (int i = 0; i < edges; i++)
            {
                int[] secondLine = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();    
                int source = secondLine[0];
                int dest = secondLine[1];

                List<int> destList = (List<int>) table[source] ;
                destList.Add(dest);
            }

            int startNode =  Convert.ToInt16(Console.ReadLine());
            for (int i = 1; i <= noOfNodes; i++)
            {
                List<int> destList = (List<int>) table[startNode];
                if (i != startNode) results[j] += (destList.Contains(i)) ? "6 " : "-1 ";
            }
        }
       
        for (int j = 0; j < queries; j++)
            Console.WriteLine(results[j]);

    }
}