using System;

namespace PamirPlastik.Domain.Entities
{
    public class VisitorStatistic
    {
        public int VisitorStatisticID { get; set; }
        public DateTime VisitDate { get; set; }
        public int VisitorCount { get; set; }
    }
}
