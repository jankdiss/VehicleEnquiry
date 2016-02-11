﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleEnquiry.Core.IContract
{
    public interface IEventHandlerFactory
    {
        IEventHandler<IEvent> GetHandlers();
    }
}
