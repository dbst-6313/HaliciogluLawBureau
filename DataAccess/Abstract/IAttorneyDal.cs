using Business.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IAttorneyDal:IEntityRepository<Attorney>
    {
        #pragma warning disable CS8604
        List<AttorneyDetailDto> GetAttorneyWithImage(Expression<Func<Attorney, bool>>? filter = null);
    }
}
