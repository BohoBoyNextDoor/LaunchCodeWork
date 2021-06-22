using System;
using System.Collections.Generic;
using System.Linq;
namespace exercise_16
{
    class Program
    {

        static void Divide(double x, double y)
        {
            try
            {
                if (y == 0)
                {
                    throw new ArgumentOutOfRangeException("can't divide by 0");
                }
                Console.WriteLine(x / y);
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("Not a valid input");
            }
            }


        static void CheckFileExtension (string fileName)
        {
            try
            {
                string endOfFileName = fileName.Substring(fileName.Length - 3, 3);
                if (endOfFileName == ".cs")
                {
                    Console.WriteLine("Give a point");
                }
                else
                {
                    Console.WriteLine("No point awarded");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("invalid.");
            }
            
            }
        
         
 
        static void Main(string[] args)
        {
            Divide(7, 0);
            CheckFileExtension("");
        
        
        
        
        }
    }
}
