﻿using Gridify.Exceptions;
using Gridify.Filter;

namespace Gridify.Strategies
{
    public class EnumDataTypeStrategy : IFilterDataTypeStrategy
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
                case FilterOperators.GreaterOrEqualThan:
                case FilterOperators.LessThan:
                case FilterOperators.LessOrEqualThan:
                case FilterOperators.Contains:
                case FilterOperators.NotContains:
                case FilterOperators.StartsWith:
                case FilterOperators.NotStartsWith:
                case FilterOperators.EndsWith:
                case FilterOperators.NotEndsWith:
                default:
                    throw new EnumDataTypeNotSupportedException($"String filter does not support {filter.Operator}");

            }
        }
    }
}
