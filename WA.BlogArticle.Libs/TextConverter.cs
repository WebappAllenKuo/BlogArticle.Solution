using System.Text;

namespace WA.BlogArticle.Libs
{
    public abstract class TextConverter
    {
        protected StringBuilder sb = new StringBuilder();
        public abstract void ConvertText(string content);
        public abstract void ConvertHtml(string content);
        public abstract void ConvertCode(string content);
        public abstract void ConvertModule(string content);
    }
}