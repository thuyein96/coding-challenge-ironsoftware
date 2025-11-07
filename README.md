# C# Coding Challenge [Iron Software]

A C# solution for Iron Software's coding challenge.

## 🧠 Problem
Simulate text entry on an old mobile phone keypad, supporting:
- Multi-tap letters
- Pause (space)
- Backspace (*)
- Send (#)

## 🏗️ Tech Stack
- .NET 8 Console App
- xUnit for testing

## 🧪 Examples
| Input | Output |
|--------|--------|
| `33#` | `E` |
| `227*#` | `B` |
| `4433555 555666#` | `HELLO` |
| `8 88777444666*664#` | `TURING` |

## 🧩 Run Tests
```bash
dotnet test
