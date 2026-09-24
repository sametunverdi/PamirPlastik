using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.StatisticsQueries;
using PamirPlastik.Application.Features.Mediator.Results.StatisticsResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetDashboardStatisticsQueryHandler : IRequestHandler<GetDashboardStatisticsQuery, ResultDashboardStatisticsDto>
    {
        private readonly IRepository<Product> _productRepository;
        private readonly IRepository<Category> _categoryRepository;
        private readonly IRepository<Fair> _fairRepository;
        private readonly IRepository<ContactMessage> _contactMessageRepository;
        private readonly IRepository<JobApplication> _jobApplicationRepository;
        private readonly IRepository<Color> _colorRepository;
        private readonly IRepository<SocialMedia> _socialMediaRepository;

        public GetDashboardStatisticsQueryHandler(
            IRepository<Product> productRepository,
            IRepository<Category> categoryRepository,
            IRepository<Fair> fairRepository,
            IRepository<ContactMessage> contactMessageRepository,
            IRepository<JobApplication> jobApplicationRepository,
            IRepository<Color> colorRepository,
            IRepository<SocialMedia> socialMediaRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _fairRepository = fairRepository;
            _contactMessageRepository = contactMessageRepository;
            _jobApplicationRepository = jobApplicationRepository;
            _colorRepository = colorRepository;
            _socialMediaRepository = socialMediaRepository;
        }

        public async Task<ResultDashboardStatisticsDto> Handle(GetDashboardStatisticsQuery request, CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetAllAsync();
            var categories = await _categoryRepository.GetAllAsync();
            var fairs = await _fairRepository.GetAllAsync();
            var contactMessages = await _contactMessageRepository.GetAllAsync();
            var jobApps = await _jobApplicationRepository.GetAllAsync();
            var colors = await _colorRepository.GetAllAsync();
            var socialMedia = await _socialMediaRepository.GetAllAsync();

            var result = new ResultDashboardStatisticsDto
            {
                                TotalProductCount = products.Count,
                ActiveProductCount = products.Count(x => x.Status),
                TotalCategoryCount = categories.Count,
                ActiveCategoryCount = categories.Count(x => x.Status),
                UpcomingFairCount = fairs.Count(x => x.IsFuture),
                UnreadMessageCount = contactMessages.Count(x => x.IsRead == false),
                
                TotalFairCount = fairs.Count,
                TotalJobApplicationCount = jobApps.Count,
                TotalContactMessageCount = contactMessages.Count,
                TotalColorCount = colors.Count,
                TotalSocialMediaCount = socialMedia.Count
            };

            // Kategorilere Göre Ürün Dağılımı Grafiği Verileri (Dinamik)
            foreach (var category in categories)
            {
                var productCount = products.Count(p => p.CategoryID == category.CategoryID);
                if (productCount > 0) // Sadece ürünü olan kategorileri grafikte gösterelim
                {
                    result.CategoryNames.Add(category.Name_TR ?? "Unknown");
                    result.CategoryProductCounts.Add(productCount);
                }
            }

            // Son 7 Günlük Mesaj Aktivitesi Grafiği Verileri (Dinamik)
            for (int i = 6; i >= 0; i--)
            {
                var targetDate = DateTime.Today.AddDays(-i);
                result.Last7Days.Add(targetDate.ToString("dd MMM")); // Örn: 24 Eyl
                
                var msgCount = contactMessages.Count(m => m.SendDate.Date == targetDate);
                result.Last7DaysMessageCounts.Add(msgCount);
            }

            return result;
        }
    }
}