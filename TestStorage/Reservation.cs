using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TestStorage
{
    public class Reservation
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Product { get; set; }

        [DataMember]
        public string ScheduledDate { get; set; }

        [DataMember]
        public string IsInProduction { get; set; }

        [DataMember]
        public string IsDone { get; set; }

        public Reservation()
        {
        }

        public override string ToString()
        {
            return $"Id: {Id}, Product: {Product}, Scheduled Date Needed: {ScheduledDate}, In Production: {IsInProduction}, Done: {IsDone}";
        }
    }
}