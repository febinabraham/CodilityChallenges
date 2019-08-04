using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    interface IQueue<T>
    {
        void enqueue(T t);
        T dequeue();
        Boolean isEmpty();
        int size();
    }
}
