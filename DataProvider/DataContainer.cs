using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataProvider
{
    public class DataContainer
    {
        private static readonly Lazy<DataContainer> DContainer = new Lazy<DataContainer>(()=> new DataContainer());

        private Dictionary<Type, List<object>> ProviderInternal { get; set; }

        private DataContainer()
        {
            ProviderInternal = new Dictionary<Type, List<object>>();
        }

        public static DataContainer Instance { get { return DContainer.Value; } }

        public void AddDbContent(Type classType, List<object> content)
        {
            ProviderInternal.Add(classType, content);
        }

        public void ClearData()
        {
            ProviderInternal.Clear();
        }
    }
}
