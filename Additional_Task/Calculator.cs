using System;


namespace Additional_Task
{
    enum ArithmeticOperations
    {
        Addition = 1,
        Subtraction,
        Multiplying,
        Division
    }
    static class Calculator
    {        
        public static void SelectOperation(ArithmeticOperations operations)
        {
           
            switch ((int)operations)
            {
                case 1:
                    {
                        Console.WriteLine("Введите первое число:");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите второе число:");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        int result = Addition(num1, num2);
                        Console.WriteLine($"Ответ:  {result}");

                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Введите первое число:");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите второе число:");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        int result = Subtraction(num1, num2);
                        Console.WriteLine($"Ответ:  {result}");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Введите первое число:");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите второе число:");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        int result = Multiplying(num1, num2);
                        Console.WriteLine($"Ответ:  {result}");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Введите первое число:");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите второе число:");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        double result = Division(num1, num2);
                        Console.WriteLine($"Ответ с округлением:  {string.Format("{0:N2}",result)}");
                        Console.WriteLine($"Ответ без округления:  {result}");
                        break;
                    }
            }
        }
        

        public static int Addition(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiplying(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Division(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
