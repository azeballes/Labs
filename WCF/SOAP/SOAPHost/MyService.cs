using System;

namespace SOAPHost
{
    public class MyService : IMyService
    {
        public string SayHello(string name)
        {
            Console.WriteLine("SayHello: " + name);
            return name;
        }
    }
}
