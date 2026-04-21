using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Commands.SiteSettingCommands
{
    public class UpdateSiteSettingCommand : IRequest
    {
        public int SiteSettingID { get; set; }

        // Logo & Marka
        public string LogoPath { get; set; }
        public string SiteName_TR { get; set; }
        public string SiteName_EN { get; set; }

        // İletişim
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address_TR { get; set; }
        public string Address_EN { get; set; }

        // Sosyal Medya
        public string Instagram { get; set; }
        public string Facebook { get; set; }
        public string Linkedin { get; set; }
        public string Youtube { get; set; }
    }
}
