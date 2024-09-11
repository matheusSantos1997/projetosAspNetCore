using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotNet6.Infra.Data.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        Task BeginTransaction();

        Task Commit();

        Task RollBack();
    }
}
