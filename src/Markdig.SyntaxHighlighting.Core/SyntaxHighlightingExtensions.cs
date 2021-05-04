using ColorCode;

namespace Markdig.SyntaxHighlighting.Core
{
    public static class SyntaxHighlightingExtensions
    {
        public static MarkdownPipelineBuilder UseSyntaxHighlighting(this MarkdownPipelineBuilder pipeline)
        {
            pipeline.Extensions.Add(new SyntaxHighlightingExtension(false));
            return pipeline;
        }

        public static MarkdownPipelineBuilder UseSyntaxHighlighting(this MarkdownPipelineBuilder pipeline, bool usingCssClasses)
        {
            pipeline.Extensions.Add(new SyntaxHighlightingExtension(usingCssClasses));
            return pipeline;
        }
    }
}
