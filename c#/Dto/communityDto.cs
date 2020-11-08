using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace Dto
{
    public class communityDto
    {
        public int codeC { get; set; }
        public string nameC { get; set; }

        public communityDto()
        {

        }

        public communityDto(community c)
        {
            codeC = c.codeC;
            nameC = c.nameC;
        }

        public static community Todal(communityDto c)
        {
            return new community()
            {

                codeC = c.codeC,
                nameC = c.nameC,

        };

        }
    }
}
