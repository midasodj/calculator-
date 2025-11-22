namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Простой калькулятор ====\n");

            double a, b;
            string op;

            while (true)
            {
                Console.Write("Введите первое число: ");
                if (double.TryParse(Console.ReadLine(), out a))
                    break;
                Console.WriteLine("Ошибка! Введите число правильно.");
            }

            while (true)
            {
                Console.Write("Введите второе число: ");
                if (double.TryParse(Console.ReadLine(), out b))
                    break;
                Console.WriteLine("Ошибка! Введите число.");
            }

            while (true)
            {
                Console.Write("Введите операцию (+, -, *, /): ");
                op = Console.ReadLine().Trim();
                if (op == "+" || op == "-" || op == "*" || op == "/")
                    break;
                Console.WriteLine("Ошибка! Используйте только: + - * /");
            }

            if (op == "+") Console.WriteLine($"Результат: {a + b}");
            else if (op == "-") Console.WriteLine($"Результат: {a - b}");
            else if (op == "*") Console.WriteLine($"Результат: {a * b}");
            else if (op == "/")
            {
                if (b == 0)
                    Console.WriteLine("Ошибка! На ноль делить нельзя!");
                else
                    Console.WriteLine($"Результат: {a / b}");
            }
        }
    }
}