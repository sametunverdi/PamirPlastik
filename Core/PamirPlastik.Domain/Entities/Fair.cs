using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace PamirPlastik.Domain.Entities

{

    public class Fair

    {

        public int FairID { get; set; }

        public string? Name { get; set; }

        public string? Location { get; set; }

        public string? Date { get; set; }

        public string? Stand { get; set; }

        public string? Img1 { get; set; }

        public string? Img2 { get; set; }

        public bool IsFuture { get; set; }

    }

}

