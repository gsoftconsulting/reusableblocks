﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableBlocks.Interfaces
{
    public interface IStringReader : IReader<String>
    {        
    }

    public interface IStringReader<T> : IReader<String, T> 
    {
    }

}
