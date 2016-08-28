namespace LeanMediTech.Dental.Core.Commands
{

    public class CommandSampleHandler : ICommandHandler<CommandSample>
    {
        //private readonly IRepository _Repo;

        //public CommandSampleHandler(IRepository  repo)
        //{
        //      _Repo = repo;
        //}


        public void Execute(CommandSample command)
        {
            
            //Compose the command here and call repo.Execute or repo.Save -- whatever 

        }
    }
}
