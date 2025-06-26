namespace CybersecurityTaskAssistantPOE
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpReminder = new System.Windows.Forms.DateTimePicker();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lstTasks = new System.Windows.Forms.ListBox();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.lblChatResponse = new System.Windows.Forms.Label();
            this.lstActivityLog = new System.Windows.Forms.ListBox();
            this.btnOpenQuiz = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(137, 42);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(137, 80);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 88);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Reminder Date";
            // 
            // dtpReminder
            // 
            this.dtpReminder.Location = new System.Drawing.Point(137, 197);
            this.dtpReminder.Name = "dtpReminder";
            this.dtpReminder.Size = new System.Drawing.Size(200, 20);
            this.dtpReminder.TabIndex = 5;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(56, 245);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(75, 23);
            this.btnAddTask.TabIndex = 6;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(155, 245);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(116, 23);
            this.btnComplete.TabIndex = 7;
            this.btnComplete.Text = "Mark as Completed";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(309, 245);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete Task";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lstTasks
            // 
            this.lstTasks.FormattingEnabled = true;
            this.lstTasks.Location = new System.Drawing.Point(56, 291);
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.Size = new System.Drawing.Size(267, 290);
            this.lstTasks.TabIndex = 9;
            this.lstTasks.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(601, 238);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(329, 20);
            this.txtCommand.TabIndex = 10;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(785, 264);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(145, 23);
            this.btnProcess.TabIndex = 11;
            this.btnProcess.Text = "Process Command";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // lblChatResponse
            // 
            this.lblChatResponse.AutoSize = true;
            this.lblChatResponse.Location = new System.Drawing.Point(384, 408);
            this.lblChatResponse.Name = "lblChatResponse";
            this.lblChatResponse.Size = new System.Drawing.Size(0, 13);
            this.lblChatResponse.TabIndex = 12;
            // 
            // lstActivityLog
            // 
            this.lstActivityLog.FormattingEnabled = true;
            this.lstActivityLog.Location = new System.Drawing.Point(697, 37);
            this.lstActivityLog.Name = "lstActivityLog";
            this.lstActivityLog.Size = new System.Drawing.Size(233, 173);
            this.lstActivityLog.TabIndex = 13;
            // 
            // btnOpenQuiz
            // 
            this.btnOpenQuiz.Location = new System.Drawing.Point(855, 549);
            this.btnOpenQuiz.Name = "btnOpenQuiz";
            this.btnOpenQuiz.Size = new System.Drawing.Size(75, 23);
            this.btnOpenQuiz.TabIndex = 14;
            this.btnOpenQuiz.Text = "Open Quiz";
            this.btnOpenQuiz.UseVisualStyleBackColor = true;
            this.btnOpenQuiz.Click += new System.EventHandler(this.btnOpenQuiz_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(697, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Activity Log";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(598, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Enter Commands";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 584);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOpenQuiz);
            this.Controls.Add(this.lstActivityLog);
            this.Controls.Add(this.lblChatResponse);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.lstTasks);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.dtpReminder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpReminder;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lstTasks;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label lblChatResponse;
        private System.Windows.Forms.ListBox lstActivityLog;
        private System.Windows.Forms.Button btnOpenQuiz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

