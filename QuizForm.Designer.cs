namespace Quizcoursework
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
            this.components = new System.ComponentModel.Container();
            this.grpTF = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbFalse = new System.Windows.Forms.RadioButton();
            this.rbTrue = new System.Windows.Forms.RadioButton();
            this.grpOpen = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOpenAnswer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbMCQ1 = new System.Windows.Forms.RadioButton();
            this.rbMCQ2 = new System.Windows.Forms.RadioButton();
            this.rbMCQ3 = new System.Windows.Forms.RadioButton();
            this.rbMCQ4 = new System.Windows.Forms.RadioButton();
            this.grpMCQ = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.grpTF.SuspendLayout();
            this.grpOpen.SuspendLayout();
            this.grpMCQ.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTF
            // 
            this.grpTF.Controls.Add(this.label3);
            this.grpTF.Controls.Add(this.rbFalse);
            this.grpTF.Controls.Add(this.rbTrue);
            this.grpTF.Location = new System.Drawing.Point(291, 229);
            this.grpTF.Name = "grpTF";
            this.grpTF.Size = new System.Drawing.Size(234, 145);
            this.grpTF.TabIndex = 10;
            this.grpTF.TabStop = false;
            this.grpTF.Text = "TF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "True/False";
            // 
            // rbFalse
            // 
            this.rbFalse.AutoSize = true;
            this.rbFalse.Location = new System.Drawing.Point(24, 91);
            this.rbFalse.Name = "rbFalse";
            this.rbFalse.Size = new System.Drawing.Size(62, 20);
            this.rbFalse.TabIndex = 10;
            this.rbFalse.TabStop = true;
            this.rbFalse.Text = "False";
            this.rbFalse.UseVisualStyleBackColor = true;
            // 
            // rbTrue
            // 
            this.rbTrue.AutoSize = true;
            this.rbTrue.Location = new System.Drawing.Point(24, 39);
            this.rbTrue.Name = "rbTrue";
            this.rbTrue.Size = new System.Drawing.Size(56, 20);
            this.rbTrue.TabIndex = 9;
            this.rbTrue.TabStop = true;
            this.rbTrue.Text = "True";
            this.rbTrue.UseVisualStyleBackColor = true;
            // 
            // grpOpen
            // 
            this.grpOpen.Controls.Add(this.label4);
            this.grpOpen.Controls.Add(this.txtOpenAnswer);
            this.grpOpen.Controls.Add(this.label2);
            this.grpOpen.Location = new System.Drawing.Point(291, 230);
            this.grpOpen.Name = "grpOpen";
            this.grpOpen.Size = new System.Drawing.Size(234, 145);
            this.grpOpen.TabIndex = 12;
            this.grpOpen.TabStop = false;
            this.grpOpen.Text = "Open";
            this.grpOpen.Enter += new System.EventHandler(this.grpOpen_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Open";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtOpenAnswer
            // 
            this.txtOpenAnswer.Location = new System.Drawing.Point(97, 38);
            this.txtOpenAnswer.Multiline = true;
            this.txtOpenAnswer.Name = "txtOpenAnswer";
            this.txtOpenAnswer.Size = new System.Drawing.Size(122, 90);
            this.txtOpenAnswer.TabIndex = 1;
            this.txtOpenAnswer.TextChanged += new System.EventHandler(this.txtOpenAnswers_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Your answer:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(288, 73);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(237, 76);
            this.lblQuestion.TabIndex = 13;
            this.lblQuestion.Text = "question";
            this.lblQuestion.Click += new System.EventHandler(this.lblQuestion_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(651, 394);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(122, 35);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Multiple Choice Options";
            // 
            // rbMCQ1
            // 
            this.rbMCQ1.AutoSize = true;
            this.rbMCQ1.Location = new System.Drawing.Point(6, 39);
            this.rbMCQ1.Name = "rbMCQ1";
            this.rbMCQ1.Size = new System.Drawing.Size(80, 20);
            this.rbMCQ1.TabIndex = 1;
            this.rbMCQ1.TabStop = true;
            this.rbMCQ1.Text = "Option 1:";
            this.rbMCQ1.UseVisualStyleBackColor = true;
            // 
            // rbMCQ2
            // 
            this.rbMCQ2.AutoSize = true;
            this.rbMCQ2.Location = new System.Drawing.Point(6, 65);
            this.rbMCQ2.Name = "rbMCQ2";
            this.rbMCQ2.Size = new System.Drawing.Size(80, 20);
            this.rbMCQ2.TabIndex = 2;
            this.rbMCQ2.TabStop = true;
            this.rbMCQ2.Text = "Option 2:";
            this.rbMCQ2.UseVisualStyleBackColor = true;
            // 
            // rbMCQ3
            // 
            this.rbMCQ3.AutoSize = true;
            this.rbMCQ3.Location = new System.Drawing.Point(6, 91);
            this.rbMCQ3.Name = "rbMCQ3";
            this.rbMCQ3.Size = new System.Drawing.Size(80, 20);
            this.rbMCQ3.TabIndex = 3;
            this.rbMCQ3.TabStop = true;
            this.rbMCQ3.Text = "Option 3:";
            this.rbMCQ3.UseVisualStyleBackColor = true;
            // 
            // rbMCQ4
            // 
            this.rbMCQ4.AutoSize = true;
            this.rbMCQ4.Location = new System.Drawing.Point(6, 119);
            this.rbMCQ4.Name = "rbMCQ4";
            this.rbMCQ4.Size = new System.Drawing.Size(80, 20);
            this.rbMCQ4.TabIndex = 4;
            this.rbMCQ4.TabStop = true;
            this.rbMCQ4.Text = "Option 4:";
            this.rbMCQ4.UseVisualStyleBackColor = true;
            this.rbMCQ4.CheckedChanged += new System.EventHandler(this.rbOption4_CheckedChanged);
            // 
            // grpMCQ
            // 
            this.grpMCQ.Controls.Add(this.rbMCQ4);
            this.grpMCQ.Controls.Add(this.rbMCQ3);
            this.grpMCQ.Controls.Add(this.rbMCQ2);
            this.grpMCQ.Controls.Add(this.rbMCQ1);
            this.grpMCQ.Controls.Add(this.label1);
            this.grpMCQ.Location = new System.Drawing.Point(291, 230);
            this.grpMCQ.Name = "grpMCQ";
            this.grpMCQ.Size = new System.Drawing.Size(234, 145);
            this.grpMCQ.TabIndex = 11;
            this.grpMCQ.TabStop = false;
            this.grpMCQ.Text = "MCQ";
            this.grpMCQ.Enter += new System.EventHandler(this.grpMCQ_Enter);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(536, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 30);
            this.label5.TabIndex = 15;
            this.label5.Text = "Timer:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(618, 29);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(170, 30);
            this.lblTimer.TabIndex = 16;
            this.lblTimer.Text = "Time Started!!";
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quizcoursework.Properties.Resources._20250730_1313_Increased_Question_Marks_remix_01k1cz9cr2esbtb0246apm2sdf;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.grpOpen);
            this.Controls.Add(this.grpMCQ);
            this.Controls.Add(this.grpTF);
            this.Name = "QuizForm";
            this.Text = "QuizForm";
            this.grpTF.ResumeLayout(false);
            this.grpTF.PerformLayout();
            this.grpOpen.ResumeLayout(false);
            this.grpOpen.PerformLayout();
            this.grpMCQ.ResumeLayout(false);
            this.grpMCQ.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbFalse;
        private System.Windows.Forms.RadioButton rbTrue;
        private System.Windows.Forms.GroupBox grpOpen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOpenAnswer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbMCQ1;
        private System.Windows.Forms.RadioButton rbMCQ2;
        private System.Windows.Forms.RadioButton rbMCQ3;
        private System.Windows.Forms.RadioButton rbMCQ4;
        private System.Windows.Forms.GroupBox grpMCQ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimer;
    }
}