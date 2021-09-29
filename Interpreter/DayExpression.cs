﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class DayExpression : IExpression
    {
        public void Evaluate(Context context)
        {
            string expression = context.expression;
            context.expression = expression.Replace("DD", context.date.Day.ToString());
        }
    }
}
