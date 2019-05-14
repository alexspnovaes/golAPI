﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GOL.Commom.Publisher
{
    public interface IPublisher
    {
        Task SendQuery<T>(T query) where T : Query;
        Task SendCommand<T>(T command) where T : Command;
        Task RaiseEvent<T>(T @event) where T : Event;
    }
}
