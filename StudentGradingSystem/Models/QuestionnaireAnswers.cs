﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentGradingSystem.Models
{
    public class QuestionnaireAnswers
    {
        public QuestionnaireQuestions Question { get; set; }
        public int AnswerID { get; set; }
        public double Score { get; set; }
    }
}
