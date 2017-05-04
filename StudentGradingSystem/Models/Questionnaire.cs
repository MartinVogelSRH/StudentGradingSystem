using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentGradingSystem.Models
{
    public class Questionnaire
    {
        public int QuestionnaireID { get; set; }
        public ICollection<Module> Module { get; set; }
        public ICollection<ModuleDetails> ModuleDetails { get; set; }
        public ICollection<QuestionnaireCategories> QuestionnaireCategories { get; set; }
        public ICollection<StudentCourse> StudentCourse { get; set; }


    }
}
