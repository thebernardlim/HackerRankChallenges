using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        double mealCost = Convert.ToDouble(Console.ReadLine());
        double tip = Convert.ToDouble(Console.ReadLine());
        double tax = Convert.ToDouble(Console.ReadLine());
        
        double tipCost = mealCost * (tip/100);
        double taxCost = mealCost * (tax/100);
        
        double totalCost = mealCost + tipCost + taxCost;
        
        Console.WriteLine(string.Format("The total meal cost is {0} dollars.", Math.Round(totalCost,0)));
    }
}


