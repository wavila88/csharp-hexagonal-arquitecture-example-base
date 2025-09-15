using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Domain.QueueMessaging;

namespace Infra.Repository
{
    public class RegisterPublisher : IRegisterPublisher
    {
        /*
        * Adapter Implementation of port output port
        */
        public void PublishRegister(Register register)
        {
            //Add register into Kafka or RabitMQ
            throw new NotImplementedException();
        }
    }
}
