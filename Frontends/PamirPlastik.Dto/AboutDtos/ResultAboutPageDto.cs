using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Dto.AboutDtos
{
    public class ResultAboutPageDto
    {
        
        public ResultAboutDto AboutDetail { get; set; }
        public List<ResultAboutFeatureDto> Features { get; set; }
        public List<ResultAboutSliderImageDto> SliderImages { get; set; }
    }
}