-- Create Soldierlist
Use master
CREATE TABLE SoldierList
(
    Id INT IDENTITY,
    FirstName NVARCHAR(30),
    LastName NVARCHAR(30),
    DateOfEntry DATETIME,
    EnlistedOrOfficer char,
    CurrentGrade NVARCHAR(3)
)
GO

-- Create PayGrades

Use master
CREATE TABLE PayGrades 
(
    Id INT IDENTITY,
    Grade NVARCHAR(3),
    Rank NVARCHAR(15),
    TimeInGradeMin INT,
    TimeInServiceMin INT
)
GO

-- Create EnlistedGradeInformation

Use master
CREATE TABLE EnlistedGradeInformation
(
    SoldierId INT,
    EOne DATETIME,
    ETwo DATETIME,
    EThree DATETIME,
    EFour DATETIME,
    EFive DATETIME,
    ESix DATETIME,
    ESeven DATETIME,
    ENine DATETIME,
    ENineS DATETIME
)
GO
