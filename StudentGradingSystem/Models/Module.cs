using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentGradingSystem.Models
{
    public class Module
    {
        public int ModuleID { get; set; }
        public Questionnaire TemplateQuestionnaireID { get; set; }
        public string Description { get; set; }
        public ICollection<ModuleDetails> Courses { get; set; }
    }
}
