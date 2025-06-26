# Cybersecurity Task Assistant — Part 3 POE

### Student: ST10446545 — Wiehan Smit  
### Module: PROG6221  
### Project: Part 3 — Integration and Feature Enhancement

---

## Overview

The **Cybersecurity Task Assistant** is a C# Windows Forms application that integrates task management, chatbot interaction, educational quizzes, and awareness of cybersecurity. This is Part 3 of the Portfolio of Evidence (POE), where features from Parts 1 and 2 have been thoroughly combined and improved with additional functionalities such as sentiment detection, enhanced keyword recognition, and smooth navigation.

---

## Features

### Task Management
- Add, delete, and mark cybersecurity-related tasks as completed.
- Set reminder dates and view tasks dynamically.

### Chatbot Assistant
- Natural language processing using **keyword detection**.
- Users can interact with the chatbot via typed commands like:
  - `"add a task to enable 2FA"`
  - `"remind me about my password"`
  - `"what is phishing?"`

### Educational Responses
- Predefined cybersecurity advice is provided for keywords like:
  - `phishing`, `password`, `privacy`, `scam`, `browse`
- Designed to raise user awareness about common threats.

### Quiz System
- Launches a quiz form with cybersecurity-related questions.
- Helps reinforce user learning in a fun and interactive way.

### Activity Log
- All key chatbot actions, task updates, and detected intents are logged.
- Enables users to trace their past commands and application behavior.

### Sentiment Detection
- Basic sentiment detection detects phrases like:
  - `"I feel unsafe"` → chatbot responds with empathy.
  - `"I'm doing fine"` → chatbot responds positively.

---

## Integration Summary

This final POE combines:
- **Part 1:** Basic task management UI.
- **Part 2:** Chatbot keyword response engine.
- **Part 3:** Adds full integration, activity tracking, quiz launch button, and improved chatbot flexibility.

---

## How to Use

1. **Launch the application.**
2. **Add tasks** manually using the form or via chatbot command.
3. **Enter commands** in the chatbot such as:
   - `“remind me about phishing tomorrow”`
   - `“open quiz”`
   - `“what is a scam?”`
4. View responses and log in the **Activity Log**.
5. Press **Open Quiz** to start the quiz module.

---

## Test Cases / Suggested Commands

| Command | Result |
|--------|--------|
| `add a task to enable 2FA` | Task added to list and logged |
| `remind me about my password` | Reminder created for password change |
| `what is phishing?` | Chatbot returns anti-phishing tips |
| `open quiz` | Launches the QuizForm |
| `I feel unsafe online` | Chatbot responds with reassurance |
| `show activity log` | Displays last 10 actions |
| `when is my next quiz` | Shows next quiz date |

---

## Technologies Used

- C#
- Windows Forms (WinForms)
- Visual Studio
- OOP and Event-driven Programming Principles

---

## Project Structure

- `Form1.cs` – Main form and chatbot processing logic
- `CyberTask.cs` – Task model (Title, Description, Reminder Date)
- `QuizForm.cs` – Form for quiz UI
- `QuizQuestion.cs` – Model for quiz question and answers


---
