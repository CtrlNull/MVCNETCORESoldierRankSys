-- Create Soldierlist

Use master
Drop Table SoldierList
Go 

Use master
CREATE TABLE SoldierList
(
    Id INT IDENTITY,
    FirstName NVARCHAR(30),
    LastName NVARCHAR(30),
    DateOfEntry DATE,
    EnlistedOrOfficer char,
    CurrentGrade NVARCHAR(3)
)
GO

Use master
INSERT INTO SoldierList (FirstName, LastName, DateOfEntry, EnlistedOrOfficer, CurrentGrade)
Values ('Raphael', 'Fonseca', '20090410' ,'E', 'E6'), ('Jacob', 'Powell', '19990101', 'E', 'E8'), ('David', 'Richard', '19990101', 'E', 'E8')
Go 

Use master
Select * From SoldierList
Go

-- Create PayGrades

Use master
Drop Table PayGrades
Go 


Use master
CREATE TABLE PayGrades 
(
    Id INT IDENTITY,
    Grade NVARCHAR(3),
    Rank NVARCHAR(30),
    Waiverable INT, --bool
    SelectionRequired INT, --bool
    TimeInGradeMin Decimal,
    TimeInServiceMin Decimal
)
GO

Use master
INSERT INTO PayGrades (Grade, Rank, Waiverable, SelectionRequired, TimeInGradeMin, TimeInServiceMin)
Values 
('E1', 'Private' , 0, 0, 0, 0),
('E2', 'Private 2nd Class', 1, 0, 1., 1.),
('E3', 'Private First Class', 1, 0, .4, 1.),
('E4S', 'Specialist', 1, 0, 0, 4.),
('E4C', 'Corporal', 1, 0, .6, 1.),
('E5', 'Sergeant', 1, 0, .8, 3.),
('E6', 'Staff Sergeant', 1, 0, .10, 7.),
('E7', 'Segeant First Class', 1, 0, 0, 15.),
('E8', 'Master Sergeant', 1, 0, 0, 15.),
('E8F', 'First Sergeant', 1, 1, 0, 15.),
('E9', 'Sergeant Major', 1, 1, 0, 15.),
('E9S', 'Sergeant Major of the Army', 1, 1, 0, 15.)
Go

Use master
Select * From PayGrades
Go

-- Create EnlistedGradeInformation

Use Master
Drop Table EnlistedGradeInformation
GO

Use master
CREATE TABLE EnlistedGradeInformation
(
    SoldierId INT UNIQUE,
    EOne DATE,
    ETwo DATE,
    EThree DATE,
    EFour DATE NULL,
    EFourS DATE NULL,
    EFive DATE NULL,
    ESix DATE NULL,
    ESeven DATE NULL,
    EEight DATE NULL,
    EEightF DATE NULL,
    ENine DATE NULL,
    ENineS DATE NULL
)
GO


Use master
INSERT INTO EnlistedGradeInformation (SoldierId, EOne, ETwo, EThree, EFour, EFourS, EFive, ESix, ESeven, EEight, EEightF, ENine, ENineS)
Values 
(1, '20090410', '20090410','20090410','20090410','20090410','20090410','20090410',NULL,NULL,NULL,NULL,NULL),
(2, '19990101', '20010410','20020410','20030410','20040410','20050410','20060410','20100410','20130410',NULL,NULL, NULL),
(3, '19990101', '20010410','20020410','20030410','20040410','20050410','20060410','20100410','20130410',NULL,NULL, NULL)
Go

Use master
Select * From EnlistedGradeInformation
Go