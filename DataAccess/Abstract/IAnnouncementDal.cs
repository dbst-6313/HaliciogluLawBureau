using Business.Abstract;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Core.DataAccess.EntityFramework;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IAnnouncementDal:IEntityRepository<Announcement>
    {
        List<AnnouncementDto> GetAnnouncementDetailDtos(Expression<Func<Announcement,bool>>? filter = null);
    }
}
