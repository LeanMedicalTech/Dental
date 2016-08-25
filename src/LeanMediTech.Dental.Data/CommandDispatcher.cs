using System;

namespace LeanMediTech.Dental.Data
{
    public class CommandDispatcher : ICommandDispatcher
    {
        public void Dispatch<TCommand>(ICommandHandler<TCommand> commandHandler) where TCommand : ICommand
        {

            //Get the ICommandHandler<TCommand> from ninject kernel

            //Call the Execute method of the ICommandHandler<TCommand>

        }
    }
}
