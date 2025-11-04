 byte b = 10;
            short s = 100;
            int i = 1000;
            long l = 100000L;
            float f = 10.5F;
            double d = 20.99;
            decimal dec = 30.1234M;
            char c = 'A';
            bool isActive = true;

            // Type conversions
            int number = 42;
            string strNumber = number.ToString(); // Convert int to string

            string piString = "3.14";
            double piValue = Convert.ToDouble(piString); // Convert string to double

            // Printing all variables
            Console.WriteLine($"byte: {b}");    
            Console.WriteLine($"short: {s}");
            Console.WriteLine($"int: {i}");
            Console.WriteLine($"long: {l}");
            Console.WriteLine($"float: {f}");
            Console.WriteLine($"double: {d}");
            Console.WriteLine($"decimal: {dec}");
            Console.WriteLine($"char: {c}");
            Console.WriteLine($"bool: {isActive}");
            Console.WriteLine($"Converted int to string: {strNumber}");
            Console.WriteLine($"Converted string to double: {piValue}");
