[![GitHub issues](https://img.shields.io/github/issues/Patmol/Markdig.SyntaxHighlighting.Core.svg?style=flat-square)](https://github.com/Patmol/Markdig.SyntaxHighlighting.Core/issues)
[![GitHub forks](https://img.shields.io/github/forks/Patmol/Markdig.SyntaxHighlighting.Core.svg?style=flat-square)](https://github.com/Patmol/Markdig.SyntaxHighlighting.Core/network)
[![GitHub stars](https://img.shields.io/github/stars/Patmol/Markdig.SyntaxHighlighting.Core.svg?style=flat-square)](https://github.com/Patmol/Markdig.SyntaxHighlighting.Core/stargazers)
[![GitHub license](https://img.shields.io/badge/license-Apache%202-blue.svg?style=flat-square)](https://raw.githubusercontent.com/Patmol/Markdig.SyntaxHighlighting.Core/main/LICENSE.md)

# Syntax Highlighting extension for Markdig

An an extension to add Syntax Highlights for Markdig [Markdig](https://github.com/xoofx/markdig),
 with the help of [ColorCode](https://github.com/windows-toolkit/ColorCode-Universal).

This project is a fork of [Markdig.SyntaxHighlighting](https://github.com/RichardSlater/Markdig.SyntaxHighlighting)
 where the .NET framework has been updated to use .NET Standard 2.1 and make this project available for
 all .NET projects.

## Usage

Simply import the nuget package, add a using statement for `Markdig.SyntaxHighlighting.Core` and add to your pipeline:

```csharp
var pipeline = new MarkdownPipelineBuilder()
    .UseAdvancedExtensions()
    .UseSyntaxHighlighting()
    .Build();
```
