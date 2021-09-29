﻿using Gridify.Exceptions;
using Gridify.Filter;

namespace Gridify.Strategies
{
    public class IntDataTypeStrategy : IFilterDataTypeStrategy
    {
        public string ConvertFilterToText(Filter.Filter filter)
        {
            switch (filter.Operator)
            {
                case FilterOperators.Equal:
                    return filter.Key + " == " + filter.Value;
                case FilterOperators.NotEqual:
                    return filter.Key + " != " + filter.Value;
                case FilterOperators.GreaterThan:
                    return filter.Key + " > " + filter.Value;
                case FilterOperators.GreaterOrEqualThan:
                    return filter.Key + " >= " + filter.Value;
                case FilterOperators.LessThan:
                    return filter.Key + " < " + filter.Value;
                case FilterOperators.LessOrEqualThan:
                    return filter.Key + " <= " + filter.Value;
                case FilterOperators.Contains:
                case FilterOperators.NotContains:
                case FilterOperators.StartsWith:
                case FilterOperators.NotStartsWith:
                case FilterOperators.EndsWith:
                case FilterOperators.NotEndsWith:
                default:
                    throw new IntDataTypeNotSupportedException($"String filter does not support {filter.Operator}");

            }
        }
    }
}
