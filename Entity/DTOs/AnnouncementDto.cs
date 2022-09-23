using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class AnnouncementDto:IDto
    {
        public int Id { get; set; }
        public string? AttorneyName { get; set; }
        public string? AttorneyLastName { get; set; }
        public string? AttorneyPhone { get; set; }
        public string? AttorneyMail { get; set; }
        public string? AttorneyTitle { get; set; }
        public string? AnnouncementHeader { get; set; }
        public string? AnnouncementTitle { get; set; }
    }
}
