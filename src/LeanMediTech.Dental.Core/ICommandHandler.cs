namespace LeanMediTech.Dental.Core
{
    public interface ICommandHandler<in TCommand> where TCommand: ICommand
    {

        void Execute(TCommand command);

    }
}
