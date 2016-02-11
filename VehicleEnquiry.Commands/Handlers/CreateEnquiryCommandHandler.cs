using System;
using VehicleEnquiry.Core.IContract;
using VehicleEnquiry.Domain.Model;

namespace VehicleEnquiry.Commands.Handlers
{
    public class CreateEnquiryCommandHandler: ICommandHandler<ICommand>
    {
        private IRepository _repository;

        public CreateEnquiryCommandHandler(IRepository repository)
        {
            _repository = repository;
        }

        public void Execute(ICommand command)
        {
            if (command == null)
            {
                throw new ArgumentNullException("command");
            }
            if (_repository == null)
            {
                throw new InvalidOperationException("Repository is not initialized.");
            }

            var enquiryCommand = (CreateEnquiryCommand)command;

            var aggregate = new Vehicle(
                enquiryCommand.Name,
                enquiryCommand.Email,
                enquiryCommand.Comment,
                enquiryCommand.CreatedAt
            );
            // >>>>> save to presistence storage 
            aggregate.Save(enquiryCommand.VehicleId);

            aggregate.Version = -1;

            // >>>> Save to Event source 
            _repository.Save(aggregate, aggregate.Version);
        }


    }
}
