using MediatR;
using System;
namespace PamirPlastik.Application.Features.Mediator.Commands.JobApplicationCommands
{
    public class CreateJobApplicationCommand : IRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Message { get; set; }
        public string CvPdfUrl { get; set; }
        public DateTime ApplicationDate { get; set; }
    }
}
