using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldAPI
{
    public abstract class HelloWorldAbstractAPI
    {
        public string ConsoleMessage { get; set; }
        public string DatabaseConnection { get; set; }

        public abstract void ConsoleDisplay();
        public abstract void DatabaseWrite();
    }

    public class HelloWorldConsole : HelloWorldAbstractAPI
    {
        public void SetMessage(string message)
        {
            base.ConsoleMessage = message;
        }
        public override void ConsoleDisplay()
        {
            Console.Write("Should be writing " + ConsoleMessage + " to the console\n");
        }

        public override void DatabaseWrite() { }
    }

    public class HelloWorldDatabase : HelloWorldAbstractAPI
    {
        public void SetMessage(string message)
        {
            base.ConsoleMessage = message;
        }

        public void SetConnection(string connectionString)
        {
            base.DatabaseConnection = connectionString;
        }

        public override void DatabaseWrite()
        {
            //Add functionality to write message to the database...
            throw new NotImplementedException();
        }

        public override void ConsoleDisplay()
        {
            Console.Write("Should be writing " + ConsoleMessage + " to the database\n");
        }
    }
}