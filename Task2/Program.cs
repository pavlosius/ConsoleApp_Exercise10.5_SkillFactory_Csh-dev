using Task2;

ILogger Logger = new Logger();

Calculator calculator = new Calculator(Logger);

calculator.ReadFirstNumber();
calculator.ReadSecondNumber();
calculator.AddNumbers();
//Console.ReadKey();

public interface ICalculator
{
    double AddNumbers();
}

public interface ILogger
{
    void Event(string message);
    void Error(string message);
}

public class Logger : ILogger
{
    public void Event(string message)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
    public void Error(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}

