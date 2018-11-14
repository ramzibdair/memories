using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRepository
{
    public interface IUnitOfWork : IDisposable
    {
       IGenericCommendRepository CommendRepository { get; }
       IGenericCommendRepository QueryRepository { get; }

        int Commit();
    }
}
