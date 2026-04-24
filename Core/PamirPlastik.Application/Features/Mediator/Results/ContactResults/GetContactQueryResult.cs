using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Results.ContactResults
{
    public class GetContactQueryResult
    {
        public int ContactID { get; set; }

        // 1. ÜST BÖLÜM (Genel Merkez Yazısı)
        public string Title_TR { get; set; }
        public string Title_EN { get; set; }
        public string Description_TR { get; set; }
        public string Description_EN { get; set; }

        // 2. TELEFON BÖLÜMÜ DETAYLARI
        public string PhoneTitle_TR { get; set; }
        public string PhoneTitle_EN { get; set; }
        public string Phone { get; set; }
        public string PhoneDescription_TR { get; set; }
        public string PhoneDescription_EN { get; set; }

        // 3. E-POSTA BÖLÜMÜ DETAYLARI
        public string EmailTitle_TR { get; set; }
        public string EmailTitle_EN { get; set; }
        public string Email { get; set; }
        public string EmailDescription_TR { get; set; }
        public string EmailDescription_EN { get; set; }

        // 4. HARİTA BÖLÜMÜ DETAYLARI
        public string MapLocation { get; set; }
        public string MapTitle_TR { get; set; }
        public string MapTitle_EN { get; set; }
        public string Address_TR { get; set; }
        public string Address_EN { get; set; }
    }
}
