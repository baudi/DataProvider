using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataProvider
{
    public class DataQueryContext
    {
        internal static object Execute(Expression expression, bool isEnumerable)
        {
            return null;
        }

        private static bool IsQueryOverDataSource(Expression expression)
        {
            return (expression is MethodCallExpression);
        }
    }
}
