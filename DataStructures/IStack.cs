using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    interface IStack<T>
    {
        void push(T t);
        T pop();
        Boolean isEmpty();
        int size();
    }
}
