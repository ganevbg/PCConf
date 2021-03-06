namespace PCConf.Domain.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ICrudRepository<T>
        where T: class
    {
        Task<IEnumerable<T>> Search();
        
        Task<T> Get(Guid id);
        
        Task<Guid> Upsert(T model);

        void Delete(Guid id);
    }
}
