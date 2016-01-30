using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_prime_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s=Console.ReadLine().Split();  // ReadLine in C#===CIN in C++
            foreach(string a in s)   
            {
                int x = Convert.ToInt32(a), cnt = 0;   // Converting string type to the Binary or integer type
                for (int i = 2; i * i <= x; i++)    // we create the loop and write the algorithm for the prime number case
                    if (x % i == 0)    // 
                        cnt = 1;  // it is the same with cnt+++
                if (cnt == 0)
                    Console.Write(x + " ");   // It helps us to split the output results on the screen
                
            }
                    Console.ReadKey();     // It is not neccessary 
        }
       
    }
}
