using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace How_many_times_present_same_array_of_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 1, 1, 2, 2, 5 };
            int count = 0;
            if (input[0] == input[1]) 
            {
                count++;
                {
                    if (input[2] == input[3])
                    {
                        count++;
                    }
                    Console.Write(" this answer is =" + count + " input[1] and input[2] is two times present");
                }
                Console.ReadLine();
            }
        }
    }
}
        
    

