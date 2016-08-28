namespace LeanMediTech.Dental.Core
{
    public interface IQueryHandler<in TQuery, out T> where TQuery : IQuery
    {
        T Execute(TQuery query);
    }
}
