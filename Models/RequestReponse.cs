using System;

namespace InterviewExercise.Models
{

    public class SoldierContainer  
    {
        public SoldierList SoldierList {get; set;}
        public EnlistedGradeInformation EnlistedGradeInformation {get; set;}
    }
    public class SoldierUpdateRequest
    {
        public int SoldierId { get; set; }
        public string Grade { get; set; }
        public DateTime NewDateInGrade { get; set; }
    }
}