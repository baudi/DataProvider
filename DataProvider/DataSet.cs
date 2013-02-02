using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataProvider
{
    public class DataSet<TData> : Query<TData>
    {
        private List<object> _listData;

        public DataSet():base()
        {
            _listData = new List<object>();
        }

        public void Add(TData data)
        {}
    }
}
