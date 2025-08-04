# Geography Quiz Game

A Windows Forms desktop quiz application built in C# for COMP1551 coursework, designed to test users' knowledge of world geography through multiple-choice, true/false, and open-ended questions.

## Features

- Create, edit, and delete questions
- Play quiz games with three question types:
  - Multiple Choice
  - Open-ended
  - True/False
- Instant feedback with result summary
- Questions stored in an external `questions.txt` file
- User-friendly WinForms interface with intuitive navigation

## Technologies Used

- Language: **C#**
- Framework: **.NET Framework / WinForms**
- IDE: **Visual Studio**
- Version Control: **Git + GitHub**

## Folder Structure
```
Quizcoursework/
├── MainMenuform.cs
├── QuestionForm.cs
├── QuestionEditorForm.cs
├── QuizForm.cs
├── Question.cs
├── Program.cs
├── questions.txt
├── App.config
└── Resources/
```


## 🚀 How to Run

1. Clone the repository:
git clone https://github.com/K4yTee369/GeographyQuizGame.git

2. Open the solution in **Visual Studio**

3. Make sure `questions.txt` is located in the **same directory as the executable (Debug folder)** or adjust its path using:
```csharp
string filePath = Path.Combine(Application.StartupPath, "questions.txt");
```

4. Press Start (F5) to build and run.


Author
Khang Tran – 2025 COMP1551 Coursework Submission

