# Security Policy

## Supported Versions

| Version | Supported          |
|---------|--------------------|
| latest  | :white_check_mark: |

## Reporting a Vulnerability

If you discover a security vulnerability in Antlr4Library, please report it responsibly.

**Please do NOT open a public GitHub issue for security vulnerabilities.**

Instead, please use [GitHub Private Vulnerability Reporting](https://github.com/phmatray/Antlr4Library/security/advisories/new) or send an email to the maintainer with:

- A description of the vulnerability
- Steps to reproduce the issue
- The affected .NET version(s) and NuGet package version(s)
- Potential impact assessment
- Suggested fix (if any)

You can expect an initial response within 48 hours. We will work with you to understand and address the issue before any public disclosure.

## Security Updates

Security updates will be released as patch versions on NuGet. We recommend always using the latest version of the package.

To update to the latest version:

```bash
dotnet add package Antlr4Library
```

Dependency updates (including security patches for transitive dependencies) are managed via Renovate and reviewed regularly.
