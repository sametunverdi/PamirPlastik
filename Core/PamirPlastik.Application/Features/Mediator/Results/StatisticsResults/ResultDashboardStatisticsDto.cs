using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Results.StatisticsResults
{
    public class ResultDashboardStatisticsDto
    {
        public int TotalProductCount { get; set; }
        public int TotalCategoryCount { get; set; }
        public int UpcomingFairCount { get; set; }
        public int UnreadMessageCount { get; set; }
    }
}
