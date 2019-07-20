using System;
using System.Collections.Generic;
using System.Text;

namespace LogInn.Business
{
    public interface IDiscount<T>
    {
        bool Add(T obj);
        List<T> getlist();
    }
}
