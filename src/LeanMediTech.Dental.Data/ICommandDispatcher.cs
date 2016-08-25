namespace LeanMediTech.Dental.Data
{
    public interface ICommandDispatcher
    {

        void Dispatch<TCommand>(ICommandHandler<TCommand> commandHandler) where TCommand : ICommand;

    }
}
