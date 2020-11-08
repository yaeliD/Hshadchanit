using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace Dto
{
    public class ConstraintDto
    {
        public int codeConstraintint { get; set; }
        public int codeCandidate { get; set; }
        public string nameSde { get; set; }
        public string valueC { get; set; }
        public bool yesNo { get; set; }

        public ConstraintDto()
        {

        }
        public ConstraintDto(Constraint c)
        {
            codeConstraintint = c.codeConstraintint;
            codeCandidate = c.codeCandidate;
            nameSde = c.nameSde;
            valueC = c.valueC;
            yesNo = c.yesNo;

        }

        public static Constraint Todal(ConstraintDto c)
        {
            return new Constraint()
            {
                codeConstraintint = c.codeConstraintint,
                codeCandidate = c.codeCandidate,
                nameSde = c.nameSde,
                valueC = c.valueC,
                yesNo = c.yesNo


        };

        }
    }
}
