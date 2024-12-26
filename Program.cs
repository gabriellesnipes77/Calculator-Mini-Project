namespace Calculator_Mini_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float num1;
            float num2;

            float result;

            string answer;



            Console.WriteLine("Hello, welcome to the calculator program!");
            Console.WriteLine("Please enter the first number: ");

            num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number: ");

            num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("What type of operation would you like to do?");
            Console.WriteLine("PLease enter a for addition, s for subtraction, m for multiplication, or d for division: ");

            answer = Console.ReadLine();

            if (answer == "a")
            {
                result = num1 + num2;
                Console.WriteLine("The result of the addition is: " + result);
            }
            else if (answer == "s")
            {
                result = num1 - num2;
                Console.WriteLine("The result of the subtraction is: " + result);
            }
            else if (answer == "m")
            {
                result = num1 * num2;
                Console.WriteLine("The result of the multiplication is: " + result);
            }
            else 
            {
                result = num2 == 0? float.NaN : num1 / num2;
              
            }
            if(float.IsNaN(result))
            {
                Console.WriteLine("Cannot divide by 0");
            }
            else
            {
                Console.WriteLine("The result of the division is: " + result);
            }
            

            Console.WriteLine("Thank you for using the calculator program!");

            Console.ReadKey();
        }
    }
}
