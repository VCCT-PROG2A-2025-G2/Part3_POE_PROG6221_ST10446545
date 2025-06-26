//*************************************************************
// Part3_POE_PROG6221_ST10446545
// ST10446545@vcconnect.edu.za
//*************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-----------------------------------------------------------------------------------------------------------------

namespace CybersecurityTaskAssistantPOE
{
    //-----------------------------------------------------------------------------------------------------------------
    // Represents a multiple-choice quiz question
    public class QuizQuestion
    {
        public string QuestionText { get; set; } // The question being asked
        public string[] Options { get; set; } // Array of four answer options

        public int CorrectOptionIndex { get; set; } // Index of correct option (0–3)

        public QuizQuestion(string question, string[] options, int correctIndex)
        {
            QuestionText = question;
            Options = options;
            CorrectOptionIndex = correctIndex;
        }
    }
}
//------------------------------------------------------------- End of File -----------------------------------------------------------------