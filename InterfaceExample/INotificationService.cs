﻿namespace InterfaceExample
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface INotificationService
    {
        void SendNotification(string text);
    }
}
