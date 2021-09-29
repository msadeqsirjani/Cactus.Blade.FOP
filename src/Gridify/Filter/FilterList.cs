﻿using System.Collections.Generic;

namespace Gridify.Filter
{
    public class FilterList : IFilterList
    {
        public FilterLogic Logic { get; set; }

        public IEnumerable<IFilter> Filters { get; set; }
    }
}
