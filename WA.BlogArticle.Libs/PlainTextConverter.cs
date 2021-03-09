using System;

namespace WA.BlogArticle.Libs
{
    public class PlainTextConverter : TextConverter
    {
        public override void ConvertText(string content)
        {
            this.sb.AppendLine(content);
        }

        public override void ConvertHtml(string content)
        {
            throw new NotImplementedException();
        }

        public override void ConvertCode(string content)
        {
            throw new NotImplementedException();
        }

        public override void ConvertModule(string content)
        {
            throw new NotImplementedException();
        }
    }
}