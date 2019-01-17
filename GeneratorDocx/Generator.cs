using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneratorDocx
{
    class Generator
    {
        private static string currentTemplateName;
        private static T1Markers markers;

        public Generator(string templateName, string[] data)
        {
            currentTemplateName = templateName;
            markers = new T1Markers(data);
        }

        // пока что считаем, что всегда currentTemplateName == "Template1"
        // Добавляем шаблон
        
        // Создаёт в папке Temp шаблон.docx
        public void Create(string name)
        {
            var currentTemplate = TemplateBuilder.BuildTemplate(name);
            currentTemplate.CreatePackage(@"C:\Temp\Output.docx");
            currentTemplate.CreatePackage(@"C:\Temp\Output.dot");
            currentTemplate.CreatePackage(@"C:\Temp\Output.rtf");
        }

    }
}
