using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Akka
{
    public interface IEmailNotification
    {
        void Send(string message);
    }
}
