﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1BCleanCode
{
    public interface IFileOperations
    {
        public string Read(string filepath);

        public string GetFilepath(string filename);
    }
}
