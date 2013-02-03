using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataProvider
{
    internal delegate void AddDataEvent<in TData>(Type classType, List<object> obj);

    public class DataSet<TData> : Query<TData> where TData : class, new()
    {
        private readonly List<object> _listData;
        internal event AddDataEvent<TData> AddEvent;

        public DataSet()
        {
            _provider = new DataQueryProvider();
            _expression = Expression.Constant(this);
            
            _listData = new List<object>();
            DataContainer.Instance.AddDbContent(typeof(TData),_listData);
        }

        public void Add(TData data)
        {
            _listData.Add(data);
        }
    }
}
