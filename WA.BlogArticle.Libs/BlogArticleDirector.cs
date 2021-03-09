using System;

namespace WA.BlogArticle.Libs
{
    public class BlogArticleDirector
    {
        private readonly TextConverter _builder;
        
        public BlogArticleDirector(TextConverter builder)
        {
            _builder = builder;
        }
        
        public void ParseBlog(Blog blog)
        {
            foreach (BlogToken token in blog.Tokens)
            {
                switch (token.BlogTokenType)
                {
                    case BlogTokenType.Text:
                        _builder.ConvertText(token.Content);
                        break;
                    case BlogTokenType.Html:
                        _builder.ConvertHtml(token.Content);
                        break;
                    case BlogTokenType.Code:
                        _builder.ConvertCode(token.Content);
                        break;
                    case BlogTokenType.Module:
                        _builder.ConvertModule(token.Content);
                        break;
                    default:
                        throw new Exception("無法解析此型別");
                }
            }            
        }
    }
}