using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneratorDocx
{
    class Template1Adapter : ITemplate
    {
        private Template1 _impl;

        public Template1Adapter()
        {
            _impl = new Template1();
        }

        public void CreatePackage(string path)
        {
            _impl.CreatePackage(path);
        }
    }
}
