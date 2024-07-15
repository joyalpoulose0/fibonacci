    using System;
     
    namespace Coding.Exercise
    {
        public class Exercise
        {
            public void Fibonacci(int n)
            {
                int a = 0, b = 1, c = 0;  
                for (int i = 2; i <= n; i++)  
                {  
                    c = a + b;  
                    Console.WriteLine(c);  
                    a = b;  
                    b = c;  
                }  
            }
           
        }
    }

