using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentGradingSystem.Models
{
    public class ModuleDetails
    {
        public int ModuleDetailsID { get; set; }
        public Module ModuleID { get; set; }
        public int CourseNumber { get; set; }
        public Questionnaire QuestionnaireID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string UserNameProfessor { get; set; }
        public ICollection<GroupModule> Group { get; set; }
        public ICollection<StudentCourse> Students { get; set; }

    }
}
