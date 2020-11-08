using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace Dto
{
    public class listofmosdotDto
    {
        public int codeM { get; set; }
        public string nameM { get; set; }
        public string cityM { get; set; }

        public listofmosdotDto()
        {

        }

        public listofmosdotDto(ListOfMosdot m)
        {
            codeM = m.codeM;
            nameM = m.nameM;
            cityM = m.cityM;

        }

        public static ListOfMosdot Todal(listofmosdotDto m)
        {
            return new ListOfMosdot()
            {
                codeM = m.codeM,
                nameM = m.nameM,
                cityM = m.cityM,
            };
        }



    }
}
