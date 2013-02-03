using System;

namespace DataProvider
{
    public class DataContext : IDisposable
    {
        public void SaveChange()
        {}

        public void Dispose()
        {
            DataContainer.Instance.ClearData();
        }
    }
}
