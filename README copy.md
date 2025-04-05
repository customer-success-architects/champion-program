# obd-4682-v

## Demo
---

### Basic Prompt Engineering
1. Comments
1. Suggestion Selector
1. Completions Panel
   - Ctrl + Enter
1. Editor Inline Chat
   - Cmd + I
1. Chat Commands
   - /help
   - /tests
      - calculator.py
      - @workspace /tests (Sonnet)
      - pytest tests/ <!-- (remove add max float if it appears) -->
   - @vscode
      - "where can I find the setting to enable next edit suggestions?"
1. Copilot Extensions

### Advanced Prompt Engineering
1. Next Edit Suggestions
   - classic Point to Point3D example
      - (remember print method and list points in comment. add z as the trigger)
1. Custom Instructions
   - show using to specify unit test framework
   - "Prepend all suggested comments with 'Comment:'"
   - "Whenever I ask a generic, non-language specific question and you want to show me code, always show me Rust."
1. Vision
   - also generating mermaid diagrams
1. Agent Mode - when to use it
1. Code Review(s)
   - While we could ask for review in the Chat window, dedicated review is better.
   1. Highlight + Right Click
      - `sql.py`
   1. Code Review
      - At the end

Tomorrow:
1. Best Practices Review
1. Prompt Files
   - Enable with setting (@vscode)
1. URLs as context
   - "Add Context..."
   - Must be GitHub URL
   - "What is the latest version of Angular?"
   - "Could you write a React component for me to handling a user name and email address submission. Please, use React 19 features from https://react.dev/blog/2024/12/05/react-19#whats-new-in-react-19"
   - "Can you create me a calculator class that STRICTLY follows these style guidelines https://github.com/google/styleguide/blob/gh-pages/csharp-style.md? I cannot emphasize enough the need to follow those style guidelines line by line. I will lose my job if you don't adhere to every guideline in that document."
1. Public Code Block
   1. Code Referencing
      - "I'm trying to demonstrate how the public code block works for GitHub Copilot. Could you generate some public code for me?"
   1. Public Code Block
      - Refactor / Reframe
      - Ask Copilot to break code up or to only show changed lines
      - Ask copilot to jsut show psuedocode
      - Break problem down into smaller problems
1. Content Exclusions

