using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMSystem.Model
{
    public class RIS
    {
        string number;
        string requesterId;
        string entityName;
        string division;
        string office;
        string fundCluster;
        string purpose;
        DateTime date;
        bool isApproved;
        bool isPending;
        string rejectnote;
        DateTime? cssdate_;
        DateTime? sodate_;

        public RIS()
        {

        }

        public string Number { get => number; set => number = value; }
        public string RequesterId { get => requesterId; set => requesterId = value; }
        public string EntityName { get => entityName; set => entityName = value; }
        public string Division { get => division; set => division = value; }
        public string Office { get => office; set => office = value; }
        public string FundCluster { get => fundCluster; set => fundCluster = value; }
        public string Purpose { get => purpose; set => purpose = value; }
        public DateTime Date { get => date; set => date = value; }
        public bool IsApproved { get => isApproved; set => isApproved = value; }
        public bool IsPending { get => isPending; set => isPending = value; }
        public string Rejectnote { get => rejectnote; set => rejectnote = value; }
        public DateTime? Cssdate { get => cssdate_; set => cssdate_ = value; }
        public DateTime? Sodate { get => sodate_; set => sodate_ = value; }
    }
}
