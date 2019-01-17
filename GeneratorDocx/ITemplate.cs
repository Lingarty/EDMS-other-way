using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneratorDocx
{
    internal interface ITemplate
    {
        void CreatePackage(string path);
    }
}
