using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Dto.AboutDtos
{
    public class ResultAboutSliderImageDto
    {
        public int AboutSliderImageID { get; set; }
        public string ImagePath { get; set; }
        public string ImageAlt { get; set; }
        public int Order { get; set; }
    }
}