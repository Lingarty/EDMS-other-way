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
        Template1 currentTemplate = new Template1();
        
        // Создаёт в папке Temp шаблон.docx
        public void Create()
        {
            new Template1().CreatePackage(@"C:\Temp\Output.docx");
            new Template1().CreatePackage(@"C:\Temp\Output.dot");
            new Template1().CreatePackage(@"C:\Temp\Output.rtf");
        }

    }
}
