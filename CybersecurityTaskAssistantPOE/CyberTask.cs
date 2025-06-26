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
    //Represents a cybersecurity-related task with reminder and completion status
    public class CyberTask
    {
        public string Title { get; set; } //Task title
        public string Description { get; set; } //Detailed task description

        public DateTime ReminderDate { get; set; } //When to remind the user
        public bool IsCompleted { get; set; } //Task completion status
        //-----------------------------------------------------------------------------------------------------------------

        //Custom string display in task list
        public override string ToString()
        {
            string status = IsCompleted ? "[✓]" : "[ ]";
            return $"{status} {Title} - Remind on {ReminderDate.ToShortDateString()}";
        }
    }
}
//------------------------------------------------------------- End of File -----------------------------------------------------------------