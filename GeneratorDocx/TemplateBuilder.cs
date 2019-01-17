using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneratorDocx
{
    internal static class TemplateBuilder
    {
        private static IDictionary<string, ITemplate> _templates;

        public static ITemplate BuildTemplate(string name)
        {
            return _templates[name];
        }
        
        public static void RegisterTemplate(string name, ITemplate template)
        {
            _templates.Add(name, template);
        }
    }
}
