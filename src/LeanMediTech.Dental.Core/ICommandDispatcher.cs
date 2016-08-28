namespace LeanMediTech.Dental.Core
{
    public interface ICommandDispatcher
    {

        void Dispatch<TCommand>(ICommandHandler<TCommand> commandHandler) where TCommand : ICommand;

    }
}
