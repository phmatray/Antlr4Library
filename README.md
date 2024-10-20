# Atypical Antlr4 Library Template

A .NET template for creating Antlr4 projects in C#, including a sample CSV parser. This template provides a starting point for building language parsers or interpreters using Antlr4 in a C# environment.

## Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Project Structure](#project-structure)
- [Customization](#customization)
- [Contributing](#contributing)
- [License](#license)
- [About](#about)

## Overview

This template includes:

- An Antlr4 grammar file (`CSV.g4`) for parsing CSV files.
- Generated lexer and parser classes.
- A service class demonstrating how to use the parser.
- A visitor class implementing the logic to build a CSV model.
- A model class representing the parsed CSV data.
- Pre-configured project files for building and packaging.

## Features

- **Antlr4 Integration**: Seamless integration with Antlr4 for parsing custom languages or data formats.
- **Sample Grammar**: Includes a sample CSV grammar to get you started.
- **Visitor Pattern**: Implements the visitor pattern for traversing the parse tree.
- **Easy Customization**: Modify the grammar and visitor classes to suit your needs.
- **.NET 8 Support**: Built targeting .NET 8.0 for the latest features and performance improvements.

## Installation

Install the template using the `dotnet new` command:

```bash
dotnet new --install Atypical.Antlr4Library.Templates
```

## Usage

Create a new project using the template:

```bash
dotnet new atypical-antlr4 -n YourProjectName
```

This command creates a new directory `YourProjectName` with the template contents.

## Project Structure

- `Grammar/CSV.g4`: The Antlr4 grammar file for CSV parsing.
- `Models/CSV.cs`: The model class representing the CSV data.
- `Services/CSVService.cs`: Service class to parse CSV data using the generated parser.
- `Services/CSVVisitor.cs`: Visitor class to build the CSV model from the parse tree.
- `Antlr4Library.csproj`: Project file with Antlr4 build tasks and runtime dependencies.
- `Program.cs`: Sample program demonstrating how to use the `CSVService`.

## Customization

### Modifying the Grammar

Edit the `Grammar/CSV.g4` file to change the grammar rules or create a new grammar for your specific language or data format.

After modifying the grammar, rebuild the project to regenerate the parser and lexer classes:

```bash
dotnet build
```

### Updating the Visitor

Modify `CSVVisitor.cs` to implement custom logic for traversing the parse tree generated by your grammar.

### Parsing Custom Data

Use `CSVService.cs` as a reference to create your own service classes for parsing different types of data.

## Contributing

Contributions are welcome! If you find any issues or have suggestions for improvements, please open an issue or submit a pull request to the repository.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## About

Developed and maintained by [Philippe Matray](https://www.linkedin.com/in/phmatray), founder of [Atypical Consulting SRL](https://atypical.consulting).

---

## Quick Start Guide

1. **Install the Template**

   ```bash
   dotnet new --install Atypical.Antlr4Library.Templates
   ```

2. **Create a New Project**

   ```bash
   dotnet new atypical-antlr4 -n MyAntlrProject
   ```

3. **Build the Project**

   Navigate to the project directory and build:
    
   ```bash
   cd MyAntlrProject
   dotnet build
   ```

4. **(optional) Create a Console Application with the demo code**

   ```bash
   dotnet new console -n MyAntlrApp
   dotnet add MyAntlrApp reference MyAntlrProject
   ```
    
   Replace the contents of `Program.cs` with the following code:
    
   ```csharp
   const string csvInput =
       """"
       Details,Month,Amount
       Mid Bonus,June,"$2,000"
       ,January,"""zippo"""
       Total Bonuses,"","$5,000"
       """";
   
   var service = new CSVService();
   var csvModel = service.Parse(csvInput);
   
   WriteLine(string.Join(", ", csv.Header));
   WriteLine("---------------------");
   
   foreach (var row in csv.Rows)
   {
       WriteLine(string.Join(", ", row));
   }
   ```
    
   You should see the parsed CSV output in the console.

---

## Contact

For support or inquiries, please contact Philippe Matray at [philippe@atypical.consulting](mailto:philippe@atypical.consulting) or open an issue in the repository.
