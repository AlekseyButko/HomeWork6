namespace HW_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose number of sustem: 2/8/10/16");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the first value");
                string firstvalue = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the second value");
                string secondvalue = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Chose operator:+ , - , * , /");
                char calculationOperation = Convert.ToChar(Console.ReadLine());
                SystemNumber.Calculate(firstvalue, secondvalue, calculationOperation, number);
            }
        }
    }
}