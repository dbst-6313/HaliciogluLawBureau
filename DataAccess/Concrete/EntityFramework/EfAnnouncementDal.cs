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
    public class EfAnnouncementDal : EfEntityRepositoryBase<Announcement, HaliciogluContext>, IAnnouncementDal
    {
        public List<AnnouncementDto> GetAnnouncementDetailDtos(Expression<Func<Announcement, bool>>? filter = null)
        {
            using (var context = new HaliciogluContext())
            {
               #pragma warning disable CS8604 // Possible null reference argument.
                var result = from a in filter == null ? context.Announcements : context.Announcements.Where(filter)
                             join at in context.Attorney on a.AttorneyId equals at.Id
                             select new AnnouncementDto
                             {
                                 AnnouncementHeader = a.AnnouncementHeader,
                                 AnnouncementTitle = a.AnnouncementTitle,
                                 AttorneyLastName = at.AttorneyLastName,
                                 AttorneyMail = at.AttorneyMail,
                                 AttorneyName = at.AttorneyName,
                                 AttorneyPhone = at.AttorneyPhone,
                                 AttorneyTitle = at.AttorneyTitle,
                                 Id = a.Id
                             };
                return result.ToList();
            }
        }
    }
}
