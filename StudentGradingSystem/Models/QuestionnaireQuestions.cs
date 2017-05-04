using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentGradingSystem.Models
{
    public class QuestionnaireQuestions
    {
        public QuestionnaireCategories QuestionnaireCategory { get; set; }
        public int QuestionID { get; set; }
        public string Description { get; set; }
        public string GoodReference { get; set; }
        public string BadReference { get; set; }
        public double Weighting { get; set; }
    }
}
