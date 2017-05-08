using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StudentGradingSystem.Models
{
    public class QuestionnaireCategories
    {
        public int QuestionnaireCategoriesID { get; set; }
        [Required]
        public Questionnaire QuestionnaireID { get; set; }
        [Required]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public double? Weighting { get; set; }
        public ICollection<QuestionnaireQuestions> QuestionnaireQuestions { get; set; }
    }
}
