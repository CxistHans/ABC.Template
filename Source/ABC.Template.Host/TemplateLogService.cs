using ABC.Template.Abstraction;
using System;

namespace ABC.Template.Host
{
    public class TemplateLogService : ITemplateLogService
    {
        public TemplateLogService()
        {
            Name = "Template";
        }

        public string Name { get; }

        public void Log(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}