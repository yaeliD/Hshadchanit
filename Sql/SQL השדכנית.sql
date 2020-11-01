--create database TheMatchmaker
create database The_Matchmaker
use The_Matchmaker
go
create table Candidates(
   codeCandidates int primary key NOT NULL,
   FNameCandidates varchar(50) NOT NULL,
   LNameCandidates varchar(50) NOT NULL,
   maleORfemale bit NOT NULL,
   dateOFbirth date NOT NULL,
   heightCandidates int NOT NULL,
   photoLink varchar(50),
   currentNow varchar(50) ,
   /*foreign key REFERENCES MosdotToCandidate(codeMC) NOT NULL,*/
   occupationAfter varchar(50)NOT NULL,
   wigORhandkerchief bit ,
   addressCandidates varchar(50),
   nameFather varchar(50),
   nameMother varchar(50),
   AdaFather varchar(50) NOT NULL,
   AdaMother varchar(50) NOT NULL,
   occupationFather varchar(50) NOT NULL, 
   occupationMother varchar(50),
   familyStatus varchar(50) NOT NULL,
   numberOFchildren int,
   numberOFmarried int,
   VonTOcontact1 varchar(50) NOT NULL, 
   VonTOcontact2 varchar(50) ,
);
create table ListOfMosdot(
	codeM int primary key NOT NULL,
	nameM varchar(50) NOT NULL,
	cityM varchar(50) NOT NULL,
);
create table MosdotToCandidate(
	codeMC int primary key NOT NULL,
	codeCandidate int foreign key REFERENCES Candidates(codeCandidates)NOT NULL,
	yearOfFinish date,
);
create table ProposalInProcess(
	codeP int primary key NOT NULL,
	codeBT int foreign key REFERENCES Candidates(codeCandidates)NOT NULL,
	codeBN int foreign key REFERENCES Candidates(codeCandidates)NOT NULL,
	dateP date,
);
create table community(
	codeC int primary key NOT NULL,
    nameC varchar(50) NOT NULL,
);
create table Constraints(
	codeConstraintint int primary key NOT NULL,
	codeCandidate int foreign key REFERENCES Candidates(codeCandidates)NOT NULL,
	nameSde varchar(50) NOT NULL,
	valueC  varchar(50) NOT NULL,
	yesNo bit  NOT NULL,

);
create table StepsOfProposal(
	codeStep int primary key NOT NULL, 
	dateStep date, 
	comments varchar(50) NOT NULL,
	results bit NOT NULL,

);
create table TypesOfSteps(
	codeTypeStep int primary key NOT NULL, 
	nameStep varchar(50) NOT NULL,
);
create table Shadchnit(
    password_shadchanit int primary key NOT NULL, 
	username varchar(50) NOT NULL,
);

