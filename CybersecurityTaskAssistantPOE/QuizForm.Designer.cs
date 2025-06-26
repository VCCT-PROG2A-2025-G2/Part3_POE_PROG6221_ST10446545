namespace CybersecurityTaskAssistantPOE
{
    partial class QuizForm
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.rdoOption1 = new System.Windows.Forms.RadioButton();
            this.rdoOption2 = new System.Windows.Forms.RadioButton();
            this.rdoOption3 = new System.Windows.Forms.RadioButton();
            this.rdoOption4 = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(85, 50);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(59, 13);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "lblQuestion";
            // 
            // rdoOption1
            // 
            this.rdoOption1.AutoSize = true;
            this.rdoOption1.Location = new System.Drawing.Point(88, 100);
            this.rdoOption1.Name = "rdoOption1";
            this.rdoOption1.Size = new System.Drawing.Size(66, 17);
            this.rdoOption1.TabIndex = 1;
            this.rdoOption1.TabStop = true;
            this.rdoOption1.Text = "Option A\n";
            this.rdoOption1.UseVisualStyleBackColor = true;
            this.rdoOption1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdoOption2
            // 
            this.rdoOption2.AutoSize = true;
            this.rdoOption2.Location = new System.Drawing.Point(88, 123);
            this.rdoOption2.Name = "rdoOption2";
            this.rdoOption2.Size = new System.Drawing.Size(66, 17);
            this.rdoOption2.TabIndex = 2;
            this.rdoOption2.TabStop = true;
            this.rdoOption2.Text = "Option B\n";
            this.rdoOption2.UseVisualStyleBackColor = true;
            // 
            // rdoOption3
            // 
            this.rdoOption3.AutoSize = true;
            this.rdoOption3.Location = new System.Drawing.Point(88, 147);
            this.rdoOption3.Name = "rdoOption3";
            this.rdoOption3.Size = new System.Drawing.Size(66, 17);
            this.rdoOption3.TabIndex = 3;
            this.rdoOption3.TabStop = true;
            this.rdoOption3.Text = "Option C\n";
            this.rdoOption3.UseVisualStyleBackColor = true;
            // 
            // rdoOption4
            // 
            this.rdoOption4.AutoSize = true;
            this.rdoOption4.Location = new System.Drawing.Point(88, 171);
            this.rdoOption4.Name = "rdoOption4";
            this.rdoOption4.Size = new System.Drawing.Size(67, 30);
            this.rdoOption4.TabIndex = 4;
            this.rdoOption4.TabStop = true;
            this.rdoOption4.Text = "Option D\n\n";
            this.rdoOption4.UseVisualStyleBackColor = true;
            this.rdoOption4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(88, 239);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(99, 23);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next Question";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(85, 285);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(39, 13);
            this.lblFeedback.TabIndex = 6;
            this.lblFeedback.Text = "Label1";
            this.lblFeedback.Click += new System.EventHandler(this.lblFeedback_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(88, 329);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(58, 13);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "Score: 0/0";
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.rdoOption4);
            this.Controls.Add(this.rdoOption3);
            this.Controls.Add(this.rdoOption2);
            this.Controls.Add(this.rdoOption1);
            this.Controls.Add(this.lblQuestion);
            this.Name = "QuizForm";
            this.Text = "QuizForm";
            this.Load += new System.EventHandler(this.QuizForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton rdoOption1;
        private System.Windows.Forms.RadioButton rdoOption2;
        private System.Windows.Forms.RadioButton rdoOption3;
        private System.Windows.Forms.RadioButton rdoOption4;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Label lblScore;
    }
}