using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;
using lab8;

public class Calculator
{

    private static string[] operators = { "+", "-", "*", "/", "^", "√", "sin", "cos", "tan", "ln", "log", "min", "max", "%", "//", "trunc", "(", ")" };
    private static string numberPattern = @"^-?\d+(\.\d+)?$";

    public static void Parse(string expression, out MyStack<double> numbers, out MyStack<string> signs)
    {
        numbers = new MyStack<double>();
        signs = new MyStack<string>();

        string[] tokens = expression.Split(' ');
        foreach (var token in tokens)
        {
            try
            {
                if (Array.Find(operators, op => op.Equals(token)) != null)
                {
                    signs.Push(token);
                }
                else if (token == "exp")
                {
                    numbers.Push(Math.Exp(1));
                }
                else if (Regex.Matches(token, numberPattern).Count > 0)
                {
                    double a = 0;
                    double.TryParse(token, NumberStyles.Any, CultureInfo.InvariantCulture, out a);
                    numbers.Push(a);
                }
                else
                {
                    bool flag = true;
                    foreach (char c in token)
                    {
                        if (!char.IsLetter(c))
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        Console.WriteLine("Enter the " + token + ": ");
                        try
                        {
                            string n = Console.ReadLine();
                            numbers.Push(Convert.ToDouble(n));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(token + " not a number.");
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("Incorrect input.");
            }

        }

    }

    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.GetEncoding(1251);
        while (true)
        {
            {
                Console.WriteLine("Enter the expression, divided by spaces:");
                string expression = Console.ReadLine();
                try
                {
                    Parse(expression, out MyStack<double> numbers, out MyStack<string> signs); 
                    double result = Calculate(numbers, signs);
                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"О: {ex.Message}");
                }
            }
        }
    }
    private static double Calculate(MyStack<double> numbers, MyStack<string> signs)
    {
        while (!signs.Empty() && !numbers.Empty())
        {
            try
            {
                var sign = signs.Pop();
                if (sign == ")")
                {
                    numbers.Push(Calculate(numbers, signs));
                }
                else if (sign == "(")
                    break;
                else
                    numbers.Push(Switch(sign, numbers));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
        return numbers.Pop();
    }

    public static double Switch(string sign, MyStack<double> numbers)
    {
        if (sign == "+")
            return numbers.Pop() + numbers.Pop();
        else if (sign == "-")
            return -1 * (numbers.Pop() - numbers.Pop());
        else if (sign == "*")
            return numbers.Pop() * numbers.Pop();
        else if (sign == "/")
        {
            var a = numbers.Pop();
            var b = numbers.Pop();
            return b / a;
        }
        else if (sign == "^")
        {
            var a = numbers.Pop();
            var b = numbers.Pop();
            return Math.Pow(b, a);
        }
        else if (sign == "√")
            return Math.Sqrt(numbers.Pop());
        else if (sign == "sin")
            return Math.Sin(numbers.Pop());
        else if (sign == "cos")
            return Math.Cos(numbers.Pop());
        else if (sign == "tan")
            return Math.Tan(numbers.Pop());
        else if (sign == "ln")
        {
            var a = numbers.Pop();
            if (a <= 0) throw new ArgumentException();
            return Math.Log(a);
        }
        else if (sign == "log")
        {
            var a = numbers.Pop();
            if (a <= 0) throw new ArgumentException();
            return Math.Log10(a);
        }
        else if (sign == "min")
            return Math.Min(numbers.Pop(), numbers.Pop());
        else if (sign == "max")
            return Math.Max(numbers.Pop(), numbers.Pop());
        else if (sign == "%")
        {
            var a = numbers.Pop();
            var b = numbers.Pop();
            return b % a;
        }

        else if (sign == "//")
        {
            var a = numbers.Pop();
            var b = numbers.Pop();
            return (int)b / a;
        }
        else if (sign == "trunc")
            return Math.Truncate(numbers.Pop());
        return 0;
    }
}
