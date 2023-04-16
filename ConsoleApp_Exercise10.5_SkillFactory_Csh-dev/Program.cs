Console.WriteLine(@"Введите первое число (разделение дробной части "",""):");
double a = ReadNumber();
Console.WriteLine(@"Введите второе число (разделение дробной части "",""):");
double b = ReadNumber();
Calculator calculator = new Calculator();
double c = calculator.Add(a, b);
Console.WriteLine($"Результат сложения чисел: {c}");
Console.ReadKey();

double ReadNumber()
{
    double number = 0;
    bool exit = false;
    while (exit != true)
    {
        try
        {
            string input = Console.ReadLine();
            number = double.Parse(input);
            exit = true;
        }
        catch (FormatException)
        {
            Console.WriteLine("Введено некорректное значение.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Введенное число выходит за пределы типа.");
        }
        catch (Exception)
        {
            Console.WriteLine("Ошибка.");
        }
    };
    return number;
}

public interface ICalculator
{
    double Add(double a, double b);
}

public class Calculator : ICalculator
{
    public double Add(double a, double b)
    {
        double c = a + b;
        return c;
    }
}