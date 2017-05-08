using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace StudentGradingSystem.Models
{
    public class StudentCourse
    {
        public int StudentCourseID { get; set; }
        public string UserNameStudent { get; set; }
        public ModuleDetails Course { get; set; }
        public int SelfEvaluationID { get; set; }
        public int AnswerID { get; set; }
        public bool? GroupGradeOK { get; set; }
        public GroupModule Group { get; set; }
        public double? SelfEvaluationGrade { get; set; }
        public double? GroupGrade { get; set; }
        public double? ProfessorGuessGrade { get; set; }
        public double? Grade { get; set; }
    }
}