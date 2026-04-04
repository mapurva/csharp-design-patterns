using InterpreterPattern;

class Program
{
    static void Main(string[] args)
    {
        // Representing: (5 + 3) - 2

        IExpression expression = new SubtractExpression(
            new AddExpression(
                new Number(5),
                new Number(3)
            ),
            new Number(2)
        );

        int result = expression.Interpret();

        Console.WriteLine("Result: " + result);
    }
}