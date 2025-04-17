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
### Copilot Code Completions
World's most intelligent autocomplete

1. Copilot Code Completions
   - Create a `point.cs` file and show how you can use comments to have Copilot code completions suggest code
   - Describe how Copilot understands what your intent is via context, like file name, comment contents surrounding code and other open files in your workspace.
1. Interact with Copilot inside a file
   - Suggestion Selector
   - Completions Panel (Ctrl + Enter)
   - Editor Inline Chat (Cmd + I)

### Copilot Chat
No need to context switch! Everything I need, in my IDE.

Endless possibilities: Brainstorm, Translate, Review, Document, Clarify, Understand, Optimize, Generate, Code!

1. Chat Commands
   - /help
   - /tests
      - calculator.py
      - @workspace /tests
      - pytest tests/ <!-- (remove add max float if it appears) -->
   - @vscode
      - "where can I find the setting to enable next edit suggestions?"

### Configuring Copilot

#### Custom Instructions
Used to set "rules" you want Copilot to follow for all suggestions. A system prompt of sorts.

Lives under `.github/copilot-instructions.md`.

Examples:
1. Specify packages or frameworks you want Copilot to suggest
   - "Always write my Python unit tests using `pytest`, not `unittest`."
1. Specify (older) versions of languages or frameworks to use
   - "When suggesting .NET code, only suggest code compatible with .NET 8."
   - Note this will not work for versions beyond the model "cut-off" date.
1. Repo-wide standards or expectatoins for all involved developers
   - "Whenever possible, use recursion."

#### Public Code Block
BofA has Public Code Block enabled. This means, if Copilot generates code that closely matches lisenced code in the public domian, the response will be blocked. However, there are ways of helping Copilot avoid suggesting public code.

- Refactor / Reframe your prompt
- Ask Copilot to break suggested code into different blocks in its response
- Ask Copilot to only show changed lines of code
- Ask Copilot to just show psuedocode
- Ask Copilot to comment out the code it suggests 
- Break your problem into smaller problems

Generally speaking, when we work with our own large, complex, unique codebases, we won't run into this much. This will mostly come into play when we are starting from scratch or asking Copilot for generic examples. The alternative to the Public Code BLock is Code Referencing, where Copilot will show the public code anyway and let you know what type of license applies to the repo it is sourced from.

#### Unused
1. Content Exclusion
1. When to use which "flavor" of Copilot
   - Chat for brainstorming / understanding / generic questions
   - Edits when you want to generate specific, generally small to moderate snippets of code
