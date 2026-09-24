using System;
using System.Collections.Generic;

namespace PamirPlastik.Application.Features.Mediator.Results.StatisticsResults
{
    public class ResultDashboardStatisticsDto
    {
                public int TotalProductCount { get; set; }
        public int ActiveProductCount { get; set; }
        public int TotalCategoryCount { get; set; }
        public int ActiveCategoryCount { get; set; }
        public int UpcomingFairCount { get; set; }
        public int UnreadMessageCount { get; set; }
        
        public int TotalFairCount { get; set; }
        public int TotalJobApplicationCount { get; set; }
        public int TotalContactMessageCount { get; set; }
        public int TotalColorCount { get; set; }
        public int TotalSocialMediaCount { get; set; }

        // Grafik Verileri (Dinamik)
        public List<string> CategoryNames { get; set; } = new List<string>();
        public List<int> CategoryProductCounts { get; set; } = new List<int>();

        public List<string> Last7Days { get; set; } = new List<string>();
        public List<int> Last7DaysMessageCounts { get; set; } = new List<int>();
    }
}