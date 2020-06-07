using System;
using System.Collections.Generic;

namespace InterviewExercise.Models
{

    public class SoldierContainer  
    {
        public List<SoldierList> SoldierList {get; set;}
        public List<PayGrades> PayGrades {get; set;}
    }
    public class SoldierUpdateRequest
    {
        public int SoldierId { get; set; }
        public string Grade { get; set; }
        public DateTime NewDateInGrade { get; set; }
    }
}