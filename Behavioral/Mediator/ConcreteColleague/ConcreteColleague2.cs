using System;
using Mediator.ColleagueClass;

namespace Mediator.Concrete
{
    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator mediator) : base(mediator)
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