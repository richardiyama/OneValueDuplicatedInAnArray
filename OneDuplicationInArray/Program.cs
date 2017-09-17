using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDuplicationInArray
{
    class Program
    {

       static int Duplicate(int[] numbers)
        {
            int length = numbers.Length;
            int sum1 = 0;
            for (int i = 0; i < length; ++i)
            {
                if (numbers[i] < 0 || numbers[i] > length - 2)
                    throw new ArgumentException("Invalid numbers.");
                sum1 += numbers[i];
            }
            int sum2 = ((length - 1) * (length - 2)) >> 1;
            return sum1 - sum2;
        }
        static void Main(string[] args)
        {
       
            int[] array = new int[] {0, 2,1, 3, 2};
            
            int duplicate;
           
         

            duplicate = Duplicate(array);
            System.Console.WriteLine("The duplicate array is: " + duplicate);

        }
    }
}
