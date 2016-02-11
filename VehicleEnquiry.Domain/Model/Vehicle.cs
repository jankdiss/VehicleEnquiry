using System;
using VehicleEnquiry.Core.IContract;
using VehicleEnquiry.Core.Utils;
using VehicleEnquiry.Domain.Events;
using VehicleEnquiry.Domain.Model.Mementos;

namespace VehicleEnquiry.Domain.Model
{
    public class Vehicle : AggregateRoot, IOriginator,IDomain, IHandle<EnqueryCreatedEvent>
    {

        public Enquiry EnquiryData { get; private set; }

        public Vehicle()
        {

        }

        public Vehicle(
         string name,
         string email,
         string comment,
         DateTime CreateAt)
        {
            EnquiryData = new Enquiry()
            {
                Id = Guid.NewGuid(),
                Name = name,
                Email = email,
                Comment = comment,
                CreateAt = CreateAt
            };
            
        }

        public void Save(int id)
        {
            Id = id;
            ApplyChange(new EnqueryCreatedEvent(id, EnquiryData.Id,EnquiryData.Name,EnquiryData.Email,EnquiryData.Comment,EnquiryData.CreateAt));
        }

        public BaseMemento GetMemento()
        {
            return new EnquiryMemento(EnquiryData.Id,EnquiryData.Name, EnquiryData.Email, EnquiryData.Comment, EnquiryData.CreateAt, Id);
        }

        public void SetMemento(BaseMemento memento)
        {
            EnquiryData = new Enquiry()
            {
                Name = ((EnquiryMemento)memento).Name,
                Email = ((EnquiryMemento)memento).Email,
                Comment = ((EnquiryMemento)memento).Comment,
                CreateAt = ((EnquiryMemento)memento).CreateAt,
                Id = ((EnquiryMemento)memento).Id
            };
            Id = ((EnquiryMemento)memento).VehicleId;
        }

        public void Handle(EnqueryCreatedEvent e)
        {
            EnquiryData = new Enquiry()
            {
                Name = e.Name,
                Email = e.Email,
                Comment = e.Comment,
                CreateAt = e.CreateAt,
                Id = e.Id
            };
            Id = e.AggregateId;
        }
    }
}
