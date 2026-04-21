using MediatR;
using PamirPlastik.Dto.AboutDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Queries.AboutPageQueries
{
    public class GetAboutPageQuery : IRequest<ResultAboutPageDto>
    {
        
        public string Language { get; set; }

        public GetAboutPageQuery(string language)
        {
            Language = language;
        }
    }
}
