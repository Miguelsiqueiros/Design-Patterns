﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class YearExpression : IExpression
    {
        public void Evaluate(Context context)
        {
            string expression = context.expression;
            context.expression = expression.Replace("YYYY", context.date.Year.ToString());
        }
    }
}
