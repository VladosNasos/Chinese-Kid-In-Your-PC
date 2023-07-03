using System;

namespace Chinese_Kid_In_Your_PC
{
    public class Calculator
    {
        public double Calculate(double number1, double number2, string operation)
        {
            switch (operation)
            {
                case "Add":
                    return number1 + number2;
                case "Subtract":
                    return number1 - number2;
                case "Multiply":
                    return number1 * number2;
                case "Divide":
                    if (number2 != 0)
                        return number1 / number2;
                    else
                        throw new DivideByZeroException("Cannot divide by zero");
                default:
                    throw new InvalidOperationException("Invalid operation");
            }
        }
    }
}
