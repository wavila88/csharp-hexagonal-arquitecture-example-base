using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTO;
using Domain.QueueMessaging;
using Domain.Repositories;

namespace Application.UseCases
{
    public class RegisterUseCase : IRegisterUseCase
    {
        public readonly IRegisterRepository _repository;
        public readonly IRegisterPublisher _publisher;

        public RegisterUseCase(IRegisterRepository repository, IRegisterPublisher publisher) 
        {
            _repository = repository;
            _publisher = publisher;
        }
        public void Register(RegisterDTO register)
        {
            var domainRegister = new Domain.Models.Register() 
            {
                DocumentNumber = register.DocumentNumber,
                DocumentType = register.DocumentType,
                Name = register.Name,
                SeatsTaken = register.SeatsTaken
            };

            //Case of use if are more than 999 people conected 
            //Send register to queue message
            if (!domainRegister.IsPublisherRequired()) 
            {
                _repository.SaveRegister(domainRegister);
            }
            else
            {
                _publisher.PublishRegister(domainRegister);
            }
        }
    }
}
