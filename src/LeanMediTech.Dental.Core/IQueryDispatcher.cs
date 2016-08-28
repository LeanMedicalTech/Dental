namespace LeanMediTech.Dental.Core
{
    public interface IQueryDispatcher
    {

        void Dispatch<TQuery, T>(IQueryHandler<TQuery, T> queryHandler) where TQuery : IQuery;

    }
}
