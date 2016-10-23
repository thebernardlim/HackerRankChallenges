using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string time = Console.ReadLine();
        
        int hr      = Convert.ToInt16(time.Substring(0,2));
        string min  = time.Substring(3,2);
        string sec  = time.Substring(6,2);
        string ampm = time.Substring(8,2);
        
        if (ampm.Equals("AM")) {
            if (hr == 12) hr = 0;
        }
        else if (ampm.Equals("PM")) {
            if (hr != 12) hr += 12;
            else hr = 12;
        }
        
        
        string hrStr = (hr < 10) ? ("0"  + hr) : ("" + hr);
        string finalTime = hrStr + ":" + min + ":" + sec;
        
        Console.WriteLine(finalTime);
    }
}
