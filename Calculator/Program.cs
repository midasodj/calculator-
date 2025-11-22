namespace  Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====Simple Calculator====");
            Console.WriteLine("Введите первое число:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите операцию: ");
            string op = Console.ReadLine();
            switch (op)
            {
                case "+":
                    Console.WriteLine(Add(a, b));
                    break;
                case "-":
                    Console.WriteLine(Subtract(a, b));
                    break;
                case "*":
                    Console.WriteLine(Multiply(a, b));
                    break;
                case "/":
                    Console.WriteLine(Divide(a, b));
                    break;
                default:
                    break;
            }
        }
        
        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            return a / b;
        }
    }
}