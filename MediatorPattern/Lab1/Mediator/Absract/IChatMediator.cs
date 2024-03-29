﻿using MediatorPattern.Lab1.Absract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Lab1.Mediator.Absract
{
    public interface IChatMediator
    {
        void AddUser(IUser user);
        void SendMessage(string message,IUser sender);
    }
}
