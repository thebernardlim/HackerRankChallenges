        
        // Declare second integer, double, and String variables.
        int first;
        double second;
        string third;
        
        // Read and save an integer, double, and String to your variables.
        first = Convert.ToInt16(Console.ReadLine());
        second = Convert.ToDouble(Console.ReadLine());
        third = Console.ReadLine();
        
        // Print the sum of both integer variables on a new line.
        first += i;
        Console.WriteLine(first);

        // Print the sum of the double variables on a new line.
        second += d;
        Console.WriteLine(string.Format("{0:0.0}",second));

        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        third = s + third;
        Console.WriteLine(third);

        
