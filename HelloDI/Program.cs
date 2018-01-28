using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDI
{
    class Program
    {
        static void Main(string[] args)
        {
            var typeName = ConfigurationManager.AppSettings["messageWriter"];
            var type = Type.GetType(typeName, true);

            //IMessageWriter writer = (IMessageWriter)Activator.CreateInstance(type);
            IMessageWriter writer = new SecureMessageWriter(new ConsoleMessageWriter());

            var salutation = new Salutation(writer);
            salutation.Exclaim();
        }
    }
}
