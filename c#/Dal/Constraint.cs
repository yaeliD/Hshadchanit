//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Constraint
    {
        public int codeConstraintint { get; set; }
        public int codeCandidate { get; set; }
        public string nameSde { get; set; }
        public string valueC { get; set; }
        public bool yesNo { get; set; }
    
        public virtual Candidate Candidate { get; set; }
    }
}