using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dapper.WebApi.Data
{
    public interface IUnitOfWork
    {
        IProductRepository Products { get; }
    }
}
