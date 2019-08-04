﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  interface IBag<T>
  {
    void add(T t);
    Boolean isEmpty();
    int Size { get; }
  }
}
