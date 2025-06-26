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
    //Main form for the Cybersecurity Task Assistant application
    //Handles task management, chatbot commands, reminders, and activity log
    public partial class Form1 : Form
    {
        //Stores the list of cybersecurity tasks
        private List<CyberTask> taskList = new List<CyberTask>();

        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //-----------------------------------------------------------------------------------------------------------------
        //Stores quiz names and their scheduled dates
        private Dictionary<string, DateTime> upcomingQuizzes = new Dictionary<string, DateTime>
        {
             { "Cybersecurity", new DateTime(2025, 6, 26) }, 
             { "Networks", new DateTime(2025, 7, 10) }
        };
        //-----------------------------------------------------------------------------------------------------------------
        //Marks a selected task as completed
        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex >= 0)
            {
                CyberTask selectedTask = taskList[lstTasks.SelectedIndex];
                selectedTask.IsCompleted = true;
                AddToActivityLog($"Task marked as completed: '{selectedTask.Title}'");
                RefreshTaskList();
            }
            else
            {
                MessageBox.Show("Please select a task to mark as completed.");
            }
        }
        //-----------------------------------------------------------------------------------------------------------------
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //-----------------------------------------------------------------------------------------------------------------
        //Adds a new task to the task list from input fields
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string description = txtDescription.Text.Trim();
            DateTime reminder = dtpReminder.Value;

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Please enter a task title.");
                return;
            }

            CyberTask newTask = new CyberTask
            {
                Title = title,
                Description = description,
                ReminderDate = reminder,
                IsCompleted = false
            };

            taskList.Add(newTask);
            RefreshTaskList();
            ClearInputs();
        }
        //-----------------------------------------------------------------------------------------------------------------
        //Deletes the selected task
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex >= 0)
            {
                taskList.RemoveAt(lstTasks.SelectedIndex);
                RefreshTaskList();
            }
            else
            {
                MessageBox.Show("Please select a task to delete.");
            }
        }
        //-----------------------------------------------------------------------------------------------------------------
        //Refreshes the list of tasks displayed in the UI
        private void RefreshTaskList()
        {
            lstTasks.Items.Clear();
            foreach (CyberTask task in taskList)
            {
                lstTasks.Items.Add(task);
            }
        }
        //-----------------------------------------------------------------------------------------------------------------
        //Clears input fields after adding a task
        private void ClearInputs()
        {
            txtTitle.Clear();
            txtDescription.Clear();
            dtpReminder.Value = DateTime.Now;
        }
        //-----------------------------------------------------------------------------------------------------------------
        //Main chatbot input processing logic — detects keywords & responds
        private void btnProcess_Click(object sender, EventArgs e)
        {
            string input = txtCommand.Text.ToLower();

            if (DetectSentiment(input)) //detect emotional tone
                return;

            //Keyword detection
            bool isTask = input.Contains("task") || input.Contains("add") || input.Contains("create");
            bool isReminder = input.Contains("remind") || input.Contains("reminder");
            bool mentionsPassword = input.Contains("password");
            bool mentions2FA = input.Contains("2fa") || input.Contains("two factor");
            bool mentionsPhishing = input.Contains("phishing");
            bool mentionsPrivacy = input.Contains("privacy") || input.Contains("update");
            bool mentionsLeak = input.Contains("leak") || input.Contains("breach");
            bool mentionsBrowse = input.Contains("browse") || input.Contains("browsing") || input.Contains("internet safety");
            bool mentionsScam = input.Contains("scam") || input.Contains("scams") || input.Contains("fraud");
            bool mentionsQuiz = input.Contains("quiz");

            string detectedIntent = "";

            
            if (input.Contains("open quiz") || input.Contains("start quiz"))
            {
                detectedIntent = "Opening quiz form.";
                AddToActivityLog("Quiz form launch intent detected.");
                QuizForm quizForm = new QuizForm();
                quizForm.Show();
                lblChatResponse.Text = detectedIntent;
                return;
            }

            
            if (isReminder && mentionsPhishing)
            {
                detectedIntent = "Set a reminder about phishing.";
                AddToActivityLog("Reminder intent detected for phishing.");

                CyberTask task = new CyberTask
                {
                    Title = "Learn about phishing",
                    Description = "Review phishing prevention techniques.",
                    ReminderDate = DateTime.Now.AddDays(1), 
                    IsCompleted = false
                };
                taskList.Add(task);
                AddToActivityLog("Task added via command: 'Learn about phishing'");
                RefreshTaskList();
            }
            else if (isReminder && mentionsPassword)
            {
                detectedIntent = "Set a reminder to update your password.";
                AddToActivityLog("Reminder intent detected and processed.");
            }
            else if (isTask && mentions2FA)
            {
                detectedIntent = "Add a task to enable two-factor authentication.";

                CyberTask newTask = new CyberTask
                {
                    Title = "Enable 2FA",
                    Description = "Enable two-factor authentication for added security.",
                    ReminderDate = DateTime.Now.AddDays(7),
                    IsCompleted = false
                };

                taskList.Add(newTask);
                AddToActivityLog("Task added via command: 'Enable two-factor authentication'");
                RefreshTaskList();
            }
            else if (input.Contains("quiz") || input.Contains("quizzes"))
            {
                var nextQuiz = upcomingQuizzes.OrderBy(q => q.Value).FirstOrDefault();
                detectedIntent = $"Your next quiz is {nextQuiz.Key} on {nextQuiz.Value.ToString("yyyy/MM/dd")}.";
                AddToActivityLog("Quiz lookup intent processed.");
            }
            else if (input.Contains("show activity log") || input.Contains("what have you done"))
            {
                detectedIntent = string.Join("\n", activityLog.Skip(Math.Max(0, activityLog.Count - 10))); // Display last 10 actions
            }
            else if (mentionsPhishing)
            {
                detectedIntent = "Be cautious! If you suspect a phishing attempt, do not click any links.";
                AddToActivityLog("User asked about phishing.");
            }
            else if (mentionsPrivacy)
            {
                detectedIntent = "Remember to review your privacy settings and keep your software up to date.";
                AddToActivityLog("Privacy or update concern detected.");
            }
            else if (mentionsLeak)
            {
                detectedIntent = "If you suspect a data leak, change your passwords and enable 2FA.";
                AddToActivityLog("Possible breach or leak concern raised.");
            }
            else if (mentionsBrowse)
            {
                detectedIntent = "To browse safely, always use HTTPS, update your browser, and avoid sketchy links.";
                AddToActivityLog("User asked about safe browsing.");
            }
            else if (mentionsScam)
            {
                detectedIntent = "Scams can be tricky. Never click suspicious links or share personal info via SMS, email, or unknown callers.";
                AddToActivityLog("User asked about scams.");
            }
            else
            {
                detectedIntent = "Sorry, I couldn't understand that. Try using keywords like 'task', 'remind', or '2FA'.";
                AddToActivityLog("Unrecognized input processed.");
            }

            lblChatResponse.Text = detectedIntent;
        }
        //-----------------------------------------------------------------------------------------------------------------
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        //-----------------------------------------------------------------------------------------------------------------
        //Stores recent chatbot activity logs
        List<string> activityLog = new List<string>();

        //Adds a message to the chatbot activity log and updates the ListBox
        private void AddToActivityLog(string logEntry)
        {
            activityLog.Add(logEntry);

            // Keep list trimmed to 10 entries max
            if (activityLog.Count > 10)
                activityLog.RemoveAt(0);

            // Update the ListBox visually
            lstActivityLog.Items.Clear();
            foreach (var entry in activityLog)
            {
                lstActivityLog.Items.Add(entry);
            }
        }
        //-----------------------------------------------------------------------------------------------------------------
        //Opens the Quiz Form manually from button
        private void btnOpenQuiz_Click(object sender, EventArgs e)
        {
            QuizForm quizForm = new QuizForm();
            quizForm.Show();
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }
        //-----------------------------------------------------------------------------------------------------------------
        //Detects emotional tone in user's message and responds accordingly
        private bool DetectSentiment(string input)
        {
            input = input.ToLower();

            if (input.Contains("worried") || input.Contains("concerned"))
            {
                lblChatResponse.Text = "It's completely understandable to feel that way. Cybersecurity can be tricky, but I'm here to help.";
                AddToActivityLog("User expressed concern.");
                return true;
            }
            else if (input.Contains("confused") || input.Contains("don’t get it") || input.Contains("unclear"))
            {
                lblChatResponse.Text = "No worries — let's break it down. Which part can I explain better?";
                AddToActivityLog("User expressed confusion.");
                return true;
            }
            else if (input.Contains("frustrated") || input.Contains("frustrating") || input.Contains("annoyed"))
            {
                lblChatResponse.Text = "I'm here to help — take your time, and we’ll figure this out together.";
                AddToActivityLog("User expressed frustration.");
                return true;
            }

            return false;
        }
    }
}
//------------------------------------------------------------- End of File -----------------------------------------------------------------
//References
//https://chatgpt.com/share/685dadba-9364-8008-ba40-52f3ec33ed98, (Ln251) was unsure about how to implament an Activity Log method, used Chat for clarity on how to go about it