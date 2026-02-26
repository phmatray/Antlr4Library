# Contributing to Antlr4Library

Thank you for your interest in contributing to Antlr4Library! This guide will help you get started.

## Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later
- A C# IDE such as [JetBrains Rider](https://www.jetbrains.com/rider/), [Visual Studio](https://visualstudio.microsoft.com/), or [VS Code](https://code.visualstudio.com/)

## Development Setup

1. **Fork and clone** the repository:
   ```bash
   git clone https://github.com/<your-username>/Antlr4Library.git
   cd Antlr4Library
   ```

2. **Restore dependencies and build** using the Nuke build system:
   ```bash
   ./build.sh Compile        # Linux / macOS
   ./build.cmd Compile       # Windows (cmd)
   ./build.ps1 Compile       # Windows (PowerShell)
   ```

   Or use the standard .NET CLI:
   ```bash
   dotnet build src/Atypical.Antlr4Library.Templates.sln
   ```

3. **Create a branch** for your changes:
   ```bash
   git checkout -b feature/your-feature-name
   ```

## Build Targets (Nuke)

This project uses [Nuke](https://nuke.build/) as its build automation tool. Key targets:

| Target | Description |
|--------|-------------|
| `Clean` | Deletes bin/obj and artifacts directories |
| `Restore` | Restores NuGet packages |
| `VerifyFormat` | Checks code formatting (whitespace and style) |
| `Compile` | Builds the solution (depends on Restore and VerifyFormat) |
| `Pack` | Creates NuGet packages in `artifacts/packages` |

Run a target with:
```bash
./build.sh <Target>
```

## Code Style

This project enforces formatting via `dotnet format`. Before committing, verify your changes pass the format check:

```bash
dotnet format whitespace src/Atypical.Antlr4Library.Templates.sln --verify-no-changes
dotnet format style src/Atypical.Antlr4Library.Templates.sln --verify-no-changes
```

Or simply run the `VerifyFormat` build target, which does the same thing:
```bash
./build.sh VerifyFormat
```

To auto-fix formatting issues:
```bash
dotnet format src/Atypical.Antlr4Library.Templates.sln
```

## Making Changes

1. Make your changes in a feature branch off `main`.
2. Write or update tests as needed.
3. Ensure the project compiles and formatting checks pass:
   ```bash
   ./build.sh Compile
   ```
4. Commit your changes with a clear, descriptive message.

## Pull Request Process

1. Push your branch to your fork and open a pull request against `main`.
2. Provide a clear description of your changes and the motivation behind them.
3. Ensure CI passes on your PR.
4. Address any review feedback from the maintainers.

## Reporting Issues

- Use the [GitHub issue tracker](https://github.com/phmatray/Antlr4Library/issues) to report bugs or request features.
- Check existing issues before creating a new one to avoid duplicates.
- Include steps to reproduce the issue and your environment details (.NET version, OS, etc.).

## License

By contributing, you agree that your contributions will be licensed under the [MIT License](LICENSE).
