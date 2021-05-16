namespace PCConf.Domain.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ICrudService<T>
        where T : class
    {
        Task<IEnumerable<T>> Search();

        Task<T> Get(Guid id);

        Task<Guid> Upsert(T model);

        void Delete(Guid id);
    }
}
