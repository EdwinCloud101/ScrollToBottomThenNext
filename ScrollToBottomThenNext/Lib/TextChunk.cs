using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class TextItem
    {
        public bool IsDone { get; set; }
        public bool IsFirst { get; set; }
        public bool IsLast { get; set; }
        public bool IsBetween { get; set; }
    }

    public interface ITextChunk
    {
        void AddText(string text);
        List<TextItem> Texts { get; }
    }

    public class TextChunk : ITextChunk
    {
        public List<TextItem> Texts { get; private set; }

        public void AddText(string text)
        {
            throw new NotImplementedException();
        }
    }
}
