using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneratorDocx
{
    class Program
    {
        static void Main(string[] args)
        {
            TemplateBuilder.RegisterTemplate("template1", new Template1Adapter());
            string[] data = null;
            string t1 = null;
            Generator gen = new Generator(t1, data);
            gen.Create("template1");
        }
    }
}
