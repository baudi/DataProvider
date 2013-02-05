using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataProvider.Visitors
{
    internal class ExpressionTreeModifier<TData> : ExpressionVisitor
    {
        private IQueryable<TData> _queryablePlaces;

        internal ExpressionTreeModifier(IQueryable<TData> places)
        {
            _queryablePlaces = places;
        }

        protected override Expression VisitConstant(ConstantExpression c)
        {
            if (c.Type == typeof(DataSet<>))
                return Expression.Constant(_queryablePlaces);
            else
                return c;
        }
    }
}
