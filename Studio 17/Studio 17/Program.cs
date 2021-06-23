using System;

namespace Studio_17
{
    class Program
    {
        static void DimensionsOfCircle()
        {
            Console.WriteLine("Please enter the radius of the circle");
            string radius = Console.ReadLine();
            Console.WriteLine("What's the miles per gallon for your car?");
            string mpgString = Console.ReadLine();
            int r;
            int mpg;
            bool tryParseResult;
            tryParseResult = int.TryParse(radius, out r);
            if (tryParseResult == false)
                {
                    Console.WriteLine("That Radius sure ain't seem like a number to me, brochacho");
                    return;
                }
            tryParseResult = int.TryParse(mpgString, out mpg);
            if (tryParseResult == false)
                {
                    Console.WriteLine($"Last time I checked {mpgString} ain't a valid number, homieo");
                    return;
                }

            try
            {
                if (r < 0)
                {
                    Console.WriteLine("How exactly does your circle have a negative radius?");
                }
                else if (r == 0)
                {
                    Console.WriteLine("I'm sure the scientists are facinated by your " +
                        "circle with a radius of 0, but I'm not.");
                }
                else
                {
                    double unroundedAreaAnswer = (r * r);
                    decimal decimalAreaRounded = Decimal.Parse(unroundedAreaAnswer.ToString("0.00"));
                    double unroundedCircumAnswer = (2 * 3.14 * r);
                    decimal decimalCircumRounded = Decimal.Parse(unroundedCircumAnswer.ToString("0.00"));
                    double unroundedDiameterAnswer = (2 * r);
                    decimal decimalDiameterRounded = Decimal.Parse(unroundedDiameterAnswer.ToString("0.00"));
                    decimal unroundedTripAnswer = (decimalDiameterRounded / mpg);
                    decimal decimalTripRounded = Decimal.Parse(unroundedTripAnswer.ToString("0.00"));
                    Console.WriteLine($"The answer, my love, is that a circle with radius {r}" +
                        $"has an area of {decimalAreaRounded}, a diameter of {decimalDiameterRounded}," +
                        $"and it goes without saying, pigeon, that it has a circumference of {decimalCircumRounded}");
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Please enter a value.");
            }
            
        }
        
    
        
        
        
        static void Main(string[] args)
        {
            DimensionsOfCircle();
        }
    }
}
