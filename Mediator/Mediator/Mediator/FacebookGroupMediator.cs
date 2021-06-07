using Microsoft.Azure.Documents;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public interface FacebookGroupMediator
    {
        void SendMessage(string msg, User user);
        void RegisterUser(User user);
    }
}
