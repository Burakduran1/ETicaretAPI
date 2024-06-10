using ETicaretAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntitiy //generic olarak hangi entity de çalışılıyorsa onu T'ye bildirsin.
    {
        DbSet<T> Table { get; }
    }
}
