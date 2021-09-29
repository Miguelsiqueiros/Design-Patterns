using System;
using System.Collections.Generic;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(DateTime.Now)
            {
                expression = "DD-MM-YYYY"
            };

            List<IExpression> expressionTree = new List<IExpression>
            {
                new DayExpression(),
                new MonthExpression(),
                new YearExpression(),
                new SeperatorExpression()
            };

            foreach (var expression in expressionTree)
            {
                expression.Evaluate(context);
            }

            Console.WriteLine(context.expression);
        }
    }
}
