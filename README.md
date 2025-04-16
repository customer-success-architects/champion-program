# bofa-ambassador-program

This is a repo containing materials that can be used for future Copilot demos.

### Versions
This is intended to be a reference to known versions of these tools that work for this demo.
Update this section (and the demo as needed) as BofA approves newer versions of these tools.

Tool | Version
--- | ---
.NET | 8.0.408
VS Code | 1.97.1
Copilot Extension | 1.270.0
Copilot Chat Extension | 0.23.0

## Demo
1. Copilot Code Completions
   - Create a `point.cs` file and show how you can use comments to have Copilot code completions suggest code
   - Describe how Copilot understands what your intent is via context, like file name, comment contents surrounding code and other open files in your workspace.
1. Interact with Copilot inside a file
   - Suggestion Selector
   - Completions Panel (Ctrl + Enter)
   - Editor Inline Chat (Cmd + I)
1. Chat Commands
   - /help
   - /tests
      - calculator.py
      - @workspace /tests
      - pytest tests/ <!-- (remove add max float if it appears) -->
   - @vscode
      - "where can I find the setting to enable next edit suggestions?"

1. Custom Instructions
   - show using to specify unit test framework
   - "Prepend all suggested comments with 'Comment:'"
   - "Whenever I ask a generic, non-language specific question and you want to show me code, always show me Rust."
1. When to use which "flavor" of Copilot
   - Chat for brainstorming / understanding / generic questions
   - Edits when you want to generate specific, generally small to moderate snippets of code
1. Public Code Block
   1. Code Referencing
      - "I'm trying to demonstrate how the public code block works for GitHub Copilot. Could you generate some public code for me?"
   1. Public Code Block
      - Refactor / Reframe
      - Ask Copilot to break code up or to only show changed lines
      - Ask copilot to just show psuedocode
      - Break problem down into smaller problems
1. Content Exclusion

