﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class MonthExpression : IExpression
    {
        public void Evaluate(Context context)
        {
            string expression = context.expression;
            context.expression = expression.Replace("MM", context.date.Month.ToString());
        }
    }
}
