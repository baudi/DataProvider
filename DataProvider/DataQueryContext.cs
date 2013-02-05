using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataProvider.Visitors;

namespace DataProvider
{
    public class DataQueryContext
    {
        internal static object Execute(Expression expression, bool isEnumerable)
        {
            if (!IsQueryOverDataSource(expression))
                throw new InvalidProgramException("No query over the data source was specified.");

            InnermostWhereFinder whereFinder = new InnermostWhereFinder();
            MethodCallExpression whereExpression = whereFinder.GetInnermostWhere(expression);
            LambdaExpression lambdaExpression = (LambdaExpression)((UnaryExpression)(whereExpression.Arguments[1])).Operand;

            lambdaExpression = (LambdaExpression)Evaluator.PartialEval(lambdaExpression);

            LocationFinder lf = new LocationFinder(lambdaExpression.Body);
            List<string> locations = lf.Locations;
            if (locations.Count == 0)
                throw new InvalidQueryException("You must specify at least one place name in your query.");

            //Place[] places = WebServiceHelper.GetPlacesFromTerraServer(locations);

            //IQueryable<Place> queryablePlaces = places.AsQueryable<Place>();

            //ExpressionTreeModifier<TData> treeCopier = new ExpressionTreeModifier(queryablePlaces);
            //Expression newExpressionTree = treeCopier.Visit(expression);

            //if (IsEnumerable)
            //    return queryablePlaces.Provider.CreateQuery(newExpressionTree);
            //else
            //    return queryablePlaces.Provider.Execute(newExpressionTree);

            return null;
        }

        private static bool IsQueryOverDataSource(Expression expression)
        {
            return (expression is MethodCallExpression);
        }
    }
}
