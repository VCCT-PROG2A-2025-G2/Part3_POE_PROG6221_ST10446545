//*************************************************************
// Part3_POE_PROG6221_ST10446545
// ST10446545@vcconnect.edu.za
//*************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//-----------------------------------------------------------------------------------------------------------------

namespace CybersecurityTaskAssistantPOE
{
    //-----------------------------------------------------------------------------------------------------------------
    // Form to present a multiple-choice cybersecurity quiz
    public partial class QuizForm: Form
    {
        private List<QuizQuestion> questions; // List of quiz questions
        private int currentQuestionIndex = 0; // Current question number
        private int score = 0; // User's score
        //-----------------------------------------------------------------------------------------------------------------
        public QuizForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
        //-----------------------------------------------------------------------------------------------------------------
        // Loads quiz questions and shows the first one
        private void QuizForm_Load(object sender, EventArgs e)
        {
            questions = new List<QuizQuestion>
    {
        new QuizQuestion("What does 2FA stand for?", new string[] { "Two-Factor Authentication", "Two-Faced Access", "Fast Access", "File Authorization" }, 0),
        new QuizQuestion("Is it safe to reuse passwords?", new string[] { "Yes", "Only for email", "No", "Only if you write them down" }, 2),
        new QuizQuestion("Which of these is a phishing method?", new string[] { "Fake email login page", "USB charger", "Secure website", "Antivirus software" }, 0),
        new QuizQuestion("What should you check before clicking a link?", new string[] { "URL", "Font color", "Text size", "Who sent it" }, 0),
        new QuizQuestion("What is a strong password?", new string[] { "123456", "Your birthday", "Password123", "T&8m!gZ#pV" }, 3),
        new QuizQuestion("Should you update your software regularly?", new string[] { "No", "Only games", "Yes", "Once a year" }, 2),
        new QuizQuestion("Public Wi-Fi is safe for banking?", new string[] { "Yes", "No", "If it’s fast", "Only at home" }, 1),
        new QuizQuestion("Which one protects your account?", new string[] { "Pop-ups", "2FA", "Dark mode", "Cookies" }, 1),
        new QuizQuestion("What’s the best way to spot a scam?", new string[] { "Who sent it", "Urgency", "Too good to be true", "All of the above" }, 3),
        new QuizQuestion("Where should you store passwords?", new string[] { "Notebook", "Sticky note", "Password manager", "Browser bar" }, 2),
    };

            DisplayQuestion();
        }
        //-----------------------------------------------------------------------------------------------------------------
        // Displays the current quiz question and options
        private void DisplayQuestion()
        {
            if (currentQuestionIndex >= questions.Count)
            {
                lblQuestion.Text = "Quiz Complete!";
                lblFeedback.Text = $"Final Score: {score} / {questions.Count}";
                lblScore.Text = "";
                btnNext.Enabled = false;
                return;
            }

            QuizQuestion q = questions[currentQuestionIndex];
            lblQuestion.Text = q.QuestionText;
            rdoOption1.Text = q.Options[0];
            rdoOption2.Text = q.Options[1];
            rdoOption3.Text = q.Options[2];
            rdoOption4.Text = q.Options[3];

            // Clear selections & feedback
            rdoOption1.Checked = false;
            rdoOption2.Checked = false;
            rdoOption3.Checked = false;
            rdoOption4.Checked = false;
            lblFeedback.Text = "";
            lblScore.Text = $"Score: {score} / {questions.Count}";
        }
        //-----------------------------------------------------------------------------------------------------------------
        private void lblFeedback_Click(object sender, EventArgs e)
        {

        }
        //-----------------------------------------------------------------------------------------------------------------
        // Handles answer checking and moves to next question after delay
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex >= questions.Count)
                return;

            QuizQuestion currentQuestion = questions[currentQuestionIndex];
            int selectedIndex = -1;

            if (rdoOption1.Checked) selectedIndex = 0;
            else if (rdoOption2.Checked) selectedIndex = 1;
            else if (rdoOption3.Checked) selectedIndex = 2;
            else if (rdoOption4.Checked) selectedIndex = 3;

            if (selectedIndex == -1)
            {
                MessageBox.Show("Please select an answer before continuing.");
                return;
            }

            if (selectedIndex == currentQuestion.CorrectOptionIndex)
            {
                score++;
                lblFeedback.ForeColor = System.Drawing.Color.Green;
                lblFeedback.Text = "Correct!";
            }
            else
            {
                lblFeedback.ForeColor = System.Drawing.Color.Red;
                lblFeedback.Text = $"Incorrect. Correct answer: {currentQuestion.Options[currentQuestion.CorrectOptionIndex]}";
            }

            currentQuestionIndex++;

            
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += (s, args) =>
            {
                timer.Stop();
                DisplayQuestion();
            };
            timer.Start();
        }
    }
}
//------------------------------------------------------------- End of File -----------------------------------------------------------------