using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentGradingSystem.Models
{
    public class StudentCourse
    {
        public string UserNameStudent { get; set; }
        public ModuleDetails Course { get; set; }

        public Questionnaire SelfEvaluationID { get; set; }
        public Questionnaire AnswerID { get; set; }
        public int GroupGradeOK { get; set; }
        public GroupModule Group { get; set; }
        public double SelfEvaluationGrade { get; set; }
        public double ProfessorGuessGrade { get; set; }
        public double Grade { get; set; }
    }
}
