using System;
using System.Collections.Generic;
using VehicleEnquiry.Commands.Handlers;
using VehicleEnquiry.Core.Exceptions;
using VehicleEnquiry.Core.IContract;
using VehicleEnquiry.Domain.Model;
using VehicleEnquiry.Domain.Repository;

namespace VehicleEnquiry.Commands
{
    public class CommandBus : ICommandBus
    {
        private ICommandHandlerFactory _handlerfactory;
        public CommandBus(ICommandHandlerFactory handlerfactory)
        {
            _handlerfactory = handlerfactory;
        }

        public void Send<T>(T command) where T : ICommand
        {
            var handler = _handlerfactory.GetHandler();
            if (handler != null)
            {
                handler.Execute(command);
            }
            else
            {
                throw new UnregisteredDomainCommandException("no handler registered");
            }
        }

       

    }
}
