using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Announcement:IEntity
    {
        public int Id { get; set; }
        public string? AnnouncementHeader { get; set; }
        public string? AnnouncementTitle { get; set; }
        public int AttorneyId { get; set; }
        public int IsPriority { get; set; }
    }
}
