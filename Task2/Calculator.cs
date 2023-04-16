namespace Task2
{
    public class Calculator : ICalculator
    {
        ILogger Logger { get; }

        public double Number1;
        public double Number2;

        public Calculator(ILogger logger)
        {
            Logger = logger;
        }

        public double AddNumbers()
        {
            double result = Number1 + Number2;
            Logger.Event($"Результат сложения чисел: {result}");
            Logger.Event("Операция сложения чисел завершена");
            return result;
        }

        public void ReadFirstNumber()
        {
            Logger.Event(@"Введите первое число (разделение дробной части "",""):");
            Number1 = ReadNumber();
        }

        public void ReadSecondNumber()
        {
            Logger.Event(@"Введите второе число (разделение дробной части "",""):");
            Number2 = ReadNumber();
        }

        private double ReadNumber()
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
                    Logger.Error("Введено некорректное значение.");
                }
                catch (OverflowException)
                {
                    Logger.Error("Введенное число выходит за пределы типа.");
                }
                catch (Exception)
                {
                    Logger.Error("Другая ошибка.");
                }
            };
            return number;
        }
    }
}
