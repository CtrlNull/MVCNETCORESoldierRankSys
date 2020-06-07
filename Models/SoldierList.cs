using System;

namespace InterviewExercise.Models
{
    public class SoldierList
    {
        public int SoliderId {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public DateTime DateOfEntry {get; set;}
        public string CurrentGrade {get; set;}
        public string SoldierImage {get; set;}
        public EnlistedGradeInformation EnlistedGradeInformation {get; set;}
    }
}