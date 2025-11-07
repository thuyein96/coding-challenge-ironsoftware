# C# Coding Challenge [Iron Software]

This is a C# implementation of the **Iron Software coding challenge**, simulating typing on an old mobile phone keypad.

## 🧩 Problem Description

Each numeric button on the old phone represents multiple letters.
- Pressing a key multiple times cycles through its letters.
- A **pause (space)** indicates a new character from the same button.
- `*` acts as a **backspace**.
- `#` acts as a **send/submit** button (end of input).

Example:
222 2 22# -> "CAB"

## 🏗️ Project Structure
```
OldPhoneKeypad/
├── OldPhoneKeypad/
│ ├── Program.cs
│ └── Services/
│ └── OldPhoneService.cs
│
├── OldPhoneKeypad.Tests/ 
│ └── OldPhoneServiceTests.cs 
│
├── OldPhoneKeypad.sln 
└── README.md
```
## 🧠 Problem
Simulate text entry on an old mobile phone keypad, supporting:
- Multi-tap letters
- Pause (space)
- Backspace (*)
- Send (#)

## 🤖 AI Prompt
Tool: "I would use GitHub Copilot Chat or ChatGPT (GPT-4)."

The Prompt: 
> Here is my completed C# solution for the OldPhoneKeypad challenge, along with my xUnit test project.
> Please act as a senior software engineer conducting a code review.
> Review my OldPhoneKeypad method for clarity, efficiency, and adherence to C# best practices.
> Suggest any refactorings that would make the code more 'production-ready,' stable, or easier to maintain.
> Review my unit tests. Are there any critical edge cases that I have missed?
> Help me write the XML documentation for my public method."

## 🏗️ Tech Stack
- .NET 10 Console App
- xUnit for testing

## 🧪 Examples
| Input | Output |
|--------|--------|
| `33#` | `E` |
| `227*#` | `B` |
| `4433555 555666#` | `HELLO` |
| `8 88777444666*664#` | `TURING` |

## 🧩 Run the Application
```bash
dotnet run --project OldPhoneKeypad
```
Then enter your sequence, for example:
```
4433555 555666#
```
Output:
```
HELLO
```
## 🧩 Run Tests
```bash
dotnet test
```

## 👷 Author

**Thu Yein**
Candidate submission for Iron Software
📧 turing@ironsoftware.com
