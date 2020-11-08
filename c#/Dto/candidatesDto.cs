using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace Dto
{
    public class candidatesDto
    {
        public int codeCandidates { get; set; }
        public string FNameCandidates { get; set; }
        public string LNameCandidates { get; set; }
        public bool maleORfemale { get; set; }
        public System.DateTime dateOFbirth { get; set; }
        public int heightCandidates { get; set; }
        public string photoLink { get; set; }
        public string currentNow { get; set; }
        public string occupationAfter { get; set; }
        public Nullable<bool> wigORhandkerchief { get; set; }
        public string addressCandidates { get; set; }
        public string nameFather { get; set; }
        public string nameMother { get; set; }
        public int AdaFather { get; set; }
        public int AdaMother { get; set; }
        public string occupationFather { get; set; }
        public string occupationMother { get; set; }
        public string familyStatus { get; set; }
        public Nullable<int> numberOFchildren { get; set; }
        public Nullable<int> numberOFmarried { get; set; }
        public string VonTOcontact1 { get; set; }
        public string VonTOcontact2 { get; set; }


         public candidatesDto()
        {

        }


        public candidatesDto(Candidate c)
        {
            codeCandidates = c.codeCandidates;
            FNameCandidates = c.FNameCandidates;
            LNameCandidates = c.LNameCandidates;
            maleORfemale = c.maleORfemale;
            dateOFbirth = c.dateOFbirth;
            heightCandidates = c.heightCandidates;
            photoLink = c.photoLink;
            currentNow = c.currentNow;
            occupationAfter = c.occupationAfter;
            wigORhandkerchief = c.wigORhandkerchief;
            addressCandidates = c.addressCandidates;
            nameFather = c.nameFather;
            nameMother = c.nameMother;
            AdaFather = c.AdaFather;
            AdaMother = c.AdaMother;
            occupationFather = c.occupationFather;
            occupationMother = c.occupationMother;
            familyStatus = c.familyStatus;
            numberOFchildren = c.numberOFchildren;
            numberOFmarried = c.numberOFmarried;
            VonTOcontact1 = c.VonTOcontact1;
            VonTOcontact2 = c.VonTOcontact2;

        }
        //convert dto object to dal
        public static Candidate Todal(candidatesDto c)
        {
            return new Candidate()
            {
            codeCandidates = c.codeCandidates,
            FNameCandidates = c.FNameCandidates,
            LNameCandidates = c.LNameCandidates,
            maleORfemale = c.maleORfemale,
            dateOFbirth = c.dateOFbirth,
            heightCandidates = c.heightCandidates,
            photoLink = c.photoLink,
            currentNow = c.currentNow,
            occupationAfter = c.occupationAfter,
            wigORhandkerchief = c.wigORhandkerchief,
            addressCandidates = c.addressCandidates,
            nameFather = c.nameFather,
            nameMother = c.nameMother,
            AdaFather = c.AdaFather,
            AdaMother = c.AdaMother,
            occupationFather = c.occupationFather,
            occupationMother = c.occupationMother,
            familyStatus = c.familyStatus,
            numberOFchildren = c.numberOFchildren,
            numberOFmarried = c.numberOFmarried,
            VonTOcontact1 = c.VonTOcontact1,
            VonTOcontact2 = c.VonTOcontact2,

            };

        }


    }  


}
