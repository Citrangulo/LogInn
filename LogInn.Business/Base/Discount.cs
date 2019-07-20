using System;
using System.Collections.Generic;
using System.Text;

namespace LogInn.Business
{
    public class Discount<T> : IDiscount<T>
    {
        public bool Add(T obj)
        {
            throw new NotImplementedException();
        }

        public List<T> getlist()
        {
            throw new NotImplementedException();
        }
    }
}
