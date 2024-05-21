namespace Assignment3._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program provides the sum and average of 4 numbers.");

            double num1 = GetNumbersFromUser("first");
            double num2 = GetNumbersFromUser("second");
            double num3 = GetNumbersFromUser("third");
            double num4 = GetNumbersFromUser("fourth");

            double average = Arithmatic.CalculateAverage(num1, num2, num3, num4);
            double total = Arithmatic.CalculateSum(num1, num2, num3, num4);

            Console.WriteLine($"The average of {num1}, {num2}, {num3}, {num4} is: {average}");
            Console.WriteLine($"The total is: {total}");
        }

        public static double GetNumbersFromUser(string whichNumber)
        {
            string userInput = "";

            do
            { 
                Console.WriteLine($"Please enter the {whichNumber} number");
                userInput = Console.ReadLine();
            } while (userInput == "");
            
            return Convert.ToDouble(userInput);
        }
    }

    internal class Arithmatic
    {
        public static double CalculateSum(params double[] nums)
        {
            double sum = 0.0;
            foreach (double x in nums) 
            {
                sum = sum + x;
            }
            return sum;
        }

        public static double CalculateAverage(params double[] nums)
        {
            double sum = 0.0;
            foreach (double x in nums)
            {
                sum = sum + x;
            }
            double average = sum / nums.Length;
            return average;
        }
    }
}

