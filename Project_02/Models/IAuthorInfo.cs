﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_02.Models
{
    public interface IAuthorInfo<in T>
    {
        string GetAuthorNames(T book);
    }
}//Namespace
