using System;


namespace _11._02._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Mathematic<double> operation = new Mathematic<double>();
            while (true)
            { 
            Console.WriteLine("первое число"); double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("второе число"); double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine(@" Выберите команду:
                1  Плюс        +
                2  Минус       -
                3  Умножение   *
                4  Деление     /
                5  Выход  !");


                switch (Console.ReadLine())
                { 
                case "+":
                    Console.Write(operation.DelSum(num1, num2));
                    break;
                case "-":
                    Console.Write(operation.DelMin(num1, num2));
                    break;
                case "*":
                    Console.Write(operation.DelMul(num1, num2));
                    break;
                case "/":
                    Console.Write(operation.DelDiv(num1, num2));
                    break;
                case "!": return;
                        
                }
                Console.ReadLine();
            }
           
            
        }
        class Mathematic<T>
        {
            public delegate T Operation(T num1, T num2);
            public Operation DelSum = Sum;
            public Operation DelMin = Sub;
            public Operation DelMul = Mul;
            public Operation DelDiv = Div;
            public static T Sum(T num1, T num2)
            {
                return (dynamic)num1 + (dynamic)num2;
            }
            public static T Sub(T num1, T num2)
            {
                return (dynamic)num1 - (dynamic)num2;
            }
            public static T Mul(T num1, T num2)
            {
                return (dynamic)num1 * (dynamic)num2;
            }
            public static T Div(T num1, T num2)
            {
                return (dynamic)num1 / (dynamic)num2;
            }
        }

    }

   
}

