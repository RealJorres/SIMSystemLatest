using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMSystem.Model
{
    public class Announcement
    {
        private string what;
        private string who;
        private string where;
        private DateTime when;
        private string createdBy;

        public Announcement()
        {

        }

        public string What { get => what; set => what = value; }
        public string Who { get => who; set => who = value; }
        public string Where { get => where; set => where = value; }
        public DateTime When { get => when; set => when = value; }
        public string CreatedBy { get => createdBy; set => createdBy = value; }
    }
}
