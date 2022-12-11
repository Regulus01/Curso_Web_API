using System.Linq.Expressions;

namespace VemDeZap.Domain.Interfaces.Repositories.Base
{
    public interface IRepositoryBase<TEntidade, TId>
        where  TEntidade : class
        where TId : struct
    {
        IQueryable<TEntidade> ListarPor(Expression<Func<TEntidade, bool>> where, params Expression<Func<TEntidade>>[] includeProperties);
        IQueryable<TEntidade> ListarEOrdenadosPor<TKey>(Expression<Func<TEntidade, bool>> where,
            params Expression<Func<TEntidade>>[] expression);
        IQueryable<TEntidade> ObterPor(Expression<Func<TEntidade, bool>> where, params Expression<Func<TEntidade>>[] includeProperties);
        bool Existe(Func<TEntidade, bool> where);
        IQueryable<TEntidade> Listar(params Expression<Func<TEntidade>>[] includeProperties);
        IQueryable<TEntidade> ListarOrdenadosPor<TKey>(Expression<Func<TEntidade, TKey>> where, bool ascendente);
        IQueryable<TEntidade> ObterPorId(TId id, params Expression<Func<TEntidade, object>>[] includeProperties);
        TEntidade Adicionar(TEntidade entidade);
        TEntidade Adicionar(IEnumerable<TEntidade> entidade);
        TEntidade Editar(TEntidade entidade);
        void Remover(TEntidade entidade);
        void Remover(IEnumerable<TEntidade> entidade);
    }
}
