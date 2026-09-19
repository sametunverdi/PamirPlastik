using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.StatisticsQueries;
using PamirPlastik.Application.Features.Mediator.Results.StatisticsResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Linq;
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

        public GetDashboardStatisticsQueryHandler(
            IRepository<Product> productRepository,
            IRepository<Category> categoryRepository,
            IRepository<Fair> fairRepository,
            IRepository<ContactMessage> contactMessageRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _fairRepository = fairRepository;
            _contactMessageRepository = contactMessageRepository;
        }

        public async Task<ResultDashboardStatisticsDto> Handle(GetDashboardStatisticsQuery request, CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetAllAsync();
            var categories = await _categoryRepository.GetAllAsync();
            var fairs = await _fairRepository.GetAllAsync();
            var contactMessages = await _contactMessageRepository.GetAllAsync();

            return new ResultDashboardStatisticsDto
            {
                TotalProductCount = products.Count,
                TotalCategoryCount = categories.Count,
                UpcomingFairCount = fairs.Count(x => x.IsFuture),
                UnreadMessageCount = contactMessages.Count(x => x.IsRead == false) // Assumes IsRead exists, let me check. If not, I'll just count all. Let's use false just in case, but wait, I'll just count all unread. If IsRead doesn't exist I'll get a build error. Let me check ContactMessage.
            };
        }
    }
}
