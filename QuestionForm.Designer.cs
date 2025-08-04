namespace Quizcoursework
{
    partial class QuestionForm
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
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.grpMCQ = new System.Windows.Forms.GroupBox();
            this.txtOption4 = new System.Windows.Forms.TextBox();
            this.txtOption3 = new System.Windows.Forms.TextBox();
            this.txtOption2 = new System.Windows.Forms.TextBox();
            this.txtOption1 = new System.Windows.Forms.TextBox();
            this.rbOption4 = new System.Windows.Forms.RadioButton();
            this.rbOption3 = new System.Windows.Forms.RadioButton();
            this.rbOption2 = new System.Windows.Forms.RadioButton();
            this.rbOption1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpTF = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbFalse = new System.Windows.Forms.RadioButton();
            this.rbTrue = new System.Windows.Forms.RadioButton();
            this.grpOpen = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOpenAnswers = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpMCQ.SuspendLayout();
            this.grpTF.SuspendLayout();
            this.grpOpen.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.SystemColors.Control;
            this.lblType.Location = new System.Drawing.Point(37, 30);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(98, 16);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Question Type:\t";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "MCQ",
            "True/False",
            "Open"});
            this.cmbType.Location = new System.Drawing.Point(173, 27);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(156, 24);
            this.cmbType.TabIndex = 1;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(37, 82);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(63, 16);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "Question:\t";
            this.lblQuestion.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(173, 79);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(534, 79);
            this.txtQuestion.TabIndex = 3;
            this.txtQuestion.TextChanged += new System.EventHandler(this.txtQuestion_TextChanged);
            // 
            // grpMCQ
            // 
            this.grpMCQ.Controls.Add(this.txtOption4);
            this.grpMCQ.Controls.Add(this.txtOption3);
            this.grpMCQ.Controls.Add(this.txtOption2);
            this.grpMCQ.Controls.Add(this.txtOption1);
            this.grpMCQ.Controls.Add(this.rbOption4);
            this.grpMCQ.Controls.Add(this.rbOption3);
            this.grpMCQ.Controls.Add(this.rbOption2);
            this.grpMCQ.Controls.Add(this.rbOption1);
            this.grpMCQ.Controls.Add(this.label1);
            this.grpMCQ.Location = new System.Drawing.Point(285, 192);
            this.grpMCQ.Name = "grpMCQ";
            this.grpMCQ.Size = new System.Drawing.Size(234, 145);
            this.grpMCQ.TabIndex = 4;
            this.grpMCQ.TabStop = false;
            this.grpMCQ.Text = "MCQ";
            this.grpMCQ.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtOption4
            // 
            this.txtOption4.Location = new System.Drawing.Point(103, 119);
            this.txtOption4.Name = "txtOption4";
            this.txtOption4.Size = new System.Drawing.Size(100, 22);
            this.txtOption4.TabIndex = 8;
            // 
            // txtOption3
            // 
            this.txtOption3.Location = new System.Drawing.Point(103, 94);
            this.txtOption3.Name = "txtOption3";
            this.txtOption3.Size = new System.Drawing.Size(100, 22);
            this.txtOption3.TabIndex = 7;
            // 
            // txtOption2
            // 
            this.txtOption2.Location = new System.Drawing.Point(103, 66);
            this.txtOption2.Name = "txtOption2";
            this.txtOption2.Size = new System.Drawing.Size(100, 22);
            this.txtOption2.TabIndex = 6;
            // 
            // txtOption1
            // 
            this.txtOption1.Location = new System.Drawing.Point(103, 38);
            this.txtOption1.Name = "txtOption1";
            this.txtOption1.Size = new System.Drawing.Size(100, 22);
            this.txtOption1.TabIndex = 5;
            // 
            // rbOption4
            // 
            this.rbOption4.AutoSize = true;
            this.rbOption4.Location = new System.Drawing.Point(6, 119);
            this.rbOption4.Name = "rbOption4";
            this.rbOption4.Size = new System.Drawing.Size(80, 20);
            this.rbOption4.TabIndex = 4;
            this.rbOption4.TabStop = true;
            this.rbOption4.Text = "Option 4:";
            this.rbOption4.UseVisualStyleBackColor = true;
            // 
            // rbOption3
            // 
            this.rbOption3.AutoSize = true;
            this.rbOption3.Location = new System.Drawing.Point(6, 91);
            this.rbOption3.Name = "rbOption3";
            this.rbOption3.Size = new System.Drawing.Size(80, 20);
            this.rbOption3.TabIndex = 3;
            this.rbOption3.TabStop = true;
            this.rbOption3.Text = "Option 3:";
            this.rbOption3.UseVisualStyleBackColor = true;
            // 
            // rbOption2
            // 
            this.rbOption2.AutoSize = true;
            this.rbOption2.Location = new System.Drawing.Point(6, 65);
            this.rbOption2.Name = "rbOption2";
            this.rbOption2.Size = new System.Drawing.Size(80, 20);
            this.rbOption2.TabIndex = 2;
            this.rbOption2.TabStop = true;
            this.rbOption2.Text = "Option 2:";
            this.rbOption2.UseVisualStyleBackColor = true;
            // 
            // rbOption1
            // 
            this.rbOption1.AutoSize = true;
            this.rbOption1.Location = new System.Drawing.Point(6, 39);
            this.rbOption1.Name = "rbOption1";
            this.rbOption1.Size = new System.Drawing.Size(80, 20);
            this.rbOption1.TabIndex = 1;
            this.rbOption1.TabStop = true;
            this.rbOption1.Text = "Option 1:";
            this.rbOption1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Multiple Choice Options";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(648, 383);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(113, 44);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(40, 383);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 44);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpTF
            // 
            this.grpTF.Controls.Add(this.label3);
            this.grpTF.Controls.Add(this.rbFalse);
            this.grpTF.Controls.Add(this.rbTrue);
            this.grpTF.Location = new System.Drawing.Point(285, 192);
            this.grpTF.Name = "grpTF";
            this.grpTF.Size = new System.Drawing.Size(234, 145);
            this.grpTF.TabIndex = 9;
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
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.grpOpen.Controls.Add(this.txtOpenAnswers);
            this.grpOpen.Controls.Add(this.label2);
            this.grpOpen.Location = new System.Drawing.Point(285, 192);
            this.grpOpen.Name = "grpOpen";
            this.grpOpen.Size = new System.Drawing.Size(234, 145);
            this.grpOpen.TabIndex = 10;
            this.grpOpen.TabStop = false;
            this.grpOpen.Text = "Open";
            this.grpOpen.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Open-ended";
            // 
            // txtOpenAnswers
            // 
            this.txtOpenAnswers.Location = new System.Drawing.Point(97, 38);
            this.txtOpenAnswers.Multiline = true;
            this.txtOpenAnswers.Name = "txtOpenAnswers";
            this.txtOpenAnswers.Size = new System.Drawing.Size(122, 90);
            this.txtOpenAnswers.TabIndex = 1;
            this.txtOpenAnswers.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Your answer:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quizcoursework.Properties.Resources._20250730_1313_Increased_Question_Marks_remix_01k1cz9cr2esbtb0246apm2sdf;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpOpen);
            this.Controls.Add(this.grpTF);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpMCQ);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblType);
            this.Name = "QuestionForm";
            this.grpMCQ.ResumeLayout(false);
            this.grpMCQ.PerformLayout();
            this.grpTF.ResumeLayout(false);
            this.grpTF.PerformLayout();
            this.grpOpen.ResumeLayout(false);
            this.grpOpen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.GroupBox grpMCQ;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbOption4;
        private System.Windows.Forms.RadioButton rbOption3;
        private System.Windows.Forms.RadioButton rbOption2;
        private System.Windows.Forms.RadioButton rbOption1;
        private System.Windows.Forms.TextBox txtOption4;
        private System.Windows.Forms.TextBox txtOption3;
        private System.Windows.Forms.TextBox txtOption2;
        private System.Windows.Forms.TextBox txtOption1;
        private System.Windows.Forms.GroupBox grpTF;
        private System.Windows.Forms.GroupBox grpOpen;
        private System.Windows.Forms.RadioButton rbFalse;
        private System.Windows.Forms.RadioButton rbTrue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOpenAnswers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}