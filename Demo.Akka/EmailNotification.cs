using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Akka
{
    public class EmailNotification : IEmailNotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending email...: {message}");
        }
    }
}
