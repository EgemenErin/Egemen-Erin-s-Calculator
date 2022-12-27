namespace Calculator;
class Program
{
    static void Main(string[] args)
    {
        bool calculator = true;
        double result = 0;
        while(calculator)
        {
            Console.WriteLine("|------------------------------------------|");
            Console.WriteLine("| Welcome to Egemen Erin's Calculator V1.0 |");
            Console.WriteLine("|------------------------------------------|");
            Console.WriteLine("");
            Console.WriteLine("First number: ");
            double Num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Second Number: ");
            double Num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Choose an Operator(+,-,*,/): ");
            switch (Console.ReadLine())
            {
                case "+":
                    result = Num1 + Num2;
                    Console.WriteLine($"Your result is: {result}.");
                    break;
                case "-":
                    result = Num1 - Num2;
                    Console.WriteLine($"Your result is: {result}.");
                    break;
                case "*":
                    result = Num1 * Num2;
                    Console.WriteLine($"Your result is: {result}.");
                    break;
                case "/":
                    result = Num1 / Num2;
                    Console.WriteLine($"Your result is: {result}.");
                    break;
                default:
                    calculator = false;
                    break;
            }
            Console.WriteLine("Would you like to use calculator again? (Y/N)");
            string answer = Console.ReadLine();
            answer = answer.ToUpper();
            if (answer == "Y")
            {
                calculator = true;
            }
            else
            {
                Console.WriteLine("Thanks for using my calculator!");
                calculator = false;
                return;
            }

        }
    }
}

