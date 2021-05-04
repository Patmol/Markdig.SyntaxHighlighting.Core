using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Xunit;

namespace Markdig.SyntaxHighlighting.Core.Tests.Example {
    public class CodeSample {
        [Fact]
        public void CodeSampleWorks() {
            var appPath = Environment.CurrentDirectory;
            var folder = Path.Combine(appPath, "Example");
            var inputMarkdown = Path.Combine(folder, "README.md");
            var referenceFile = Path.Combine(folder, "expected.html");
            var expectedHtml = File.ReadAllText(referenceFile);
            var markdown = File.ReadAllText(inputMarkdown);
            var pipeline = new MarkdownPipelineBuilder()
                .UseAdvancedExtensions()
                .UseSyntaxHighlighting()
                .Build();
            var html = Markdown.ToHtml(markdown, pipeline);
            var actualHtml = File.ReadAllText(Path.Combine(folder, "_template.html"))
                .Replace("{{{this}}}", html);
            actualHtml = actualHtml.Replace("\r\n", "\n").Replace("\n", "\r\n");
            expectedHtml = expectedHtml.Replace("\r\n", "\n").Replace("\n", "\r\n");
            File.WriteAllText(Path.Combine(folder, "actual.html"), actualHtml);
            Assert.Equal(expectedHtml, actualHtml);
        }

        [Fact]
        public void CodeSampleWorksWithoutClasses() {
            var appPath = Environment.CurrentDirectory;
            var folder = Path.Combine(appPath, "Example");
            var inputMarkdown = Path.Combine(folder, "README.md");
            var referenceFile = Path.Combine(folder, "expected.html");
            var expectedHtml = File.ReadAllText(referenceFile);
            var markdown = File.ReadAllText(inputMarkdown);
            var pipeline = new MarkdownPipelineBuilder()
                .UseAdvancedExtensions()
                .UseSyntaxHighlighting(false)
                .Build();
            var html = Markdown.ToHtml(markdown, pipeline);
            var actualHtml = File.ReadAllText(Path.Combine(folder, "_template.html"))
                .Replace("{{{this}}}", html);
            actualHtml = actualHtml.Replace("\r\n", "\n").Replace("\n", "\r\n");
            expectedHtml = expectedHtml.Replace("\r\n", "\n").Replace("\n", "\r\n");
            File.WriteAllText(Path.Combine(folder, "actual.html"), actualHtml);
            Assert.Equal(expectedHtml, actualHtml);
        }

        [Fact]
        public void CodeSampleWorksWithlasses() {
            var appPath = Environment.CurrentDirectory;
            var folder = Path.Combine(appPath, "Example");
            var inputMarkdown = Path.Combine(folder, "README.md");
            var referenceFile = Path.Combine(folder, "expected-classes.html");
            var expectedHtml = File.ReadAllText(referenceFile);
            var markdown = File.ReadAllText(inputMarkdown);
            var pipeline = new MarkdownPipelineBuilder()
                .UseAdvancedExtensions()
                .UseSyntaxHighlighting(true)
                .Build();
            var html = Markdown.ToHtml(markdown, pipeline);
            var actualHtml = File.ReadAllText(Path.Combine(folder, "_template.html"))
                .Replace("{{{this}}}", html);
            actualHtml = actualHtml.Replace("\r\n", "\n").Replace("\n", "\r\n");
            expectedHtml = expectedHtml.Replace("\r\n", "\n").Replace("\n", "\r\n");
            File.WriteAllText(Path.Combine(folder, "actual.html"), actualHtml);
            Assert.Equal(expectedHtml, actualHtml);
        }
    }
}