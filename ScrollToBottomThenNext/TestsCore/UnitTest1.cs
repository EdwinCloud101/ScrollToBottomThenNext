using System.Threading;
using Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsCore
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ITimeline timeline = new Timeline(1000);

            ITextChunk textChunk = new TextChunk();
            textChunk.AddText(@"aaa");
            textChunk.AddText(@"bbb");
            textChunk.AddText(@"ccc");

            textChunk.Texts[0].IsDone = true;
            textChunk.Texts[0].IsFirst = true;
            textChunk.Texts[2].IsLast = true;

            timeline.TextChunk = textChunk;
            timeline.Start();
            while (!timeline.HasEnded) { }
            timeline.Stop();
        }
    }
}
