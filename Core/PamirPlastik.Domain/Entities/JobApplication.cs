using System;

namespace PamirPlastik.Domain.Entities
{
    public class JobApplication
    {
        public int JobApplicationID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Message { get; set; }
        public string CvPdfUrl { get; set; }
        public DateTime ApplicationDate { get; set; }
    }
}