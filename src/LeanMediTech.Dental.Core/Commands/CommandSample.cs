namespace LeanMediTech.Dental.Core.Commands
{
    public class CommandSample : ICommand
    {
        public readonly int Id;

        public CommandSample(int id)
        {
            Id = id;
        }

    }
}
