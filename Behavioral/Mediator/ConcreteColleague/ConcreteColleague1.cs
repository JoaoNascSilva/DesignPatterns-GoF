using System;
using Mediator.ColleagueClass;

namespace Mediator.Concrete
{
    public class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(Mediator mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            _mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine($"Colleagues gets message: {message};");
        }
    }
}