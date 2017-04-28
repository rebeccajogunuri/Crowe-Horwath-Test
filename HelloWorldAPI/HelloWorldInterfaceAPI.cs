using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorldAPI
{
    public interface IApplicationBehavior
    {
        void SetMessage(string message);
        string GetMessage();
        void WriteMessage();
    }

    public class ConsoleBehavior : IApplicationBehavior
    {
        public string ConsoleMessage;

        public void SetMessage(string message)
        {
            this.ConsoleMessage = message;
        }
        public string GetMessage()
        {
            return this.ConsoleMessage;
        }

        public void WriteMessage()
        {
            Console.WriteLine("Should be writing " + ConsoleMessage + " to the console\n");
        }
    }

    public class DatabaseBehavior : IApplicationBehavior
    {
        public string ConsoleMessage;

        public void SetMessage(string message)
        {
            this.ConsoleMessage = message;
        }
        public string GetMessage()
        {
            return this.ConsoleMessage;
        }
        public void WriteMessage()
        {
            Console.WriteLine("Should be writing " + ConsoleMessage + " to the database\n");
        }
    }

    public class App
    {
        IApplicationBehavior behavior;

        public void setBehavior(IApplicationBehavior behavior)
        {
            this.behavior = behavior;
        }

        public IApplicationBehavior getBehavior()
        {
            return behavior;
        }

        public void setMessage(string message)
        {
            behavior.SetMessage(message);
        }

        public string getMessage()
        {
            return behavior.GetMessage();
        }

        public void WriteMessage()
        {
            behavior.WriteMessage();
        }
    }
}