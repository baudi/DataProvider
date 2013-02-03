using System;
using System.Linq.Expressions;

namespace DataProvider
{
    public class DataQueryProvider : QueryProvider
    {
        public DataQueryProvider(){}

        public override string GetQueryText(Expression expression)
        {
            throw new NotImplementedException();
        }

        public override object Execute(Expression expression)
        {
            return DataQueryContext.Execute(expression, false);
        }
    }
}
