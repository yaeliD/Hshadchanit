using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace Dto
{
   public class TypesOfStepDto
    {
        public int codeTypeStep { get; set; }
        public string nameStep { get; set; }

        public TypesOfStepDto()
        {

        }
        public TypesOfStepDto(TypesOfStep t)
        {
            codeTypeStep = t.codeTypeStep;
            nameStep = t.nameStep;
        }

        public static TypesOfStep Todal(TypesOfStepDto t)
        {
            return new TypesOfStep()
            {
                codeTypeStep = t.codeTypeStep,
                nameStep = t.nameStep,
        };

        }
    }
}
