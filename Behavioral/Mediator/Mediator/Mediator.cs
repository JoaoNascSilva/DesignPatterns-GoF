using Mediator.ColleagueClass;

namespace Mediator
{
    // * Defines an interface for communicating with Colleague objects
    public interface Mediator
    {
        void Send(string message, Colleague collegue);
    }
}