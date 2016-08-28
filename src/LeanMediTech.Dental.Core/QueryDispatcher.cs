namespace LeanMediTech.Dental.Core
{
    public class QueryDispatcher : IQueryDispatcher
    {
        public void Dispatch<TQuery, T>(IQueryHandler<TQuery, T> queryHandler) where TQuery : IQuery
        {

            //Get the IQueryHandler<TQuery, T> from ninject kernel

            //Call the Execute method of the IQueryHandler<TQuery, T>

        }
    }
}
