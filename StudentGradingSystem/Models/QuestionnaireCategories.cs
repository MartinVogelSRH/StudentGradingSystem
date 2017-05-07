using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentGradingSystem.Models
{
    public class QuestionnaireCategories
    {
        public int QuestionnaireCategoriesID { get; set; }
        public Questionnaire QuestionnaireID { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public double Weighting { get; set; }
        public ICollection<QuestionnaireQuestions> QuestionnaireQuestions { get; set; }

    }
}
