using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public interface IExpression
    {
        void Evaluate(Context context);
    }
}
