using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAttorneyDal : EfEntityRepositoryBase<Attorney, HaliciogluContext>, IAttorneyDal
    {
        public List<AttorneyDetailDto> GetAttorneyWithImage(Expression<Func<Attorney, bool>>? filter = null)
        {
            using (var context = new HaliciogluContext()) 
            {
                var result =
                    from at in filter == null ? context.Attorney : context.Attorney.Where(filter)
                    select new AttorneyDetailDto
                    {
                        AttorneyAdvertorial = at.AttorneyAdvertorial,
                        AttorneyLastName = at.AttorneyLastName,
                        AttorneyMail=at.AttorneyMail,
                        AttorneyName = at.AttorneyName,
                        AttorneyPhone = at.AttorneyPhone,
                        AttorneyTitle = at.AttorneyTitle,
                        Id = at.Id,
                        ImagePath = (from image in context.AttorneyImages where image.AttorneyId ==at.Id select image.ImagePath).ToList(),

                    };
                return result.ToList();
            }
        }
    }
}
