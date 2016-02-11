using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleEnquiry.Core.IContract;
using VehicleEnquiry.Domain.Repository;

namespace VehicleEnquiry.Commands.Handlers
{
    public class CommandHandlerFactory : ICommandHandlerFactory
    {
        IRepository _repository;

        public CommandHandlerFactory(IRepository repository)
        {
            _repository = repository;
        }

        public ICommandHandler<ICommand> GetHandler()
        {
            return new CreateEnquiryCommandHandler(_repository);
        }
    }
}
