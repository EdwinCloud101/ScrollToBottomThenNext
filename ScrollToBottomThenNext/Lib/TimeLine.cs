using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Lib
{
    public interface ITimeline
    {
        void Start();
        void Stop();
        Action Execution { get; }
        ITextChunk TextChunk { get; set; }
        bool HasEnded { get; }
    }

    public class Timeline : ITimeline
    {
        private readonly int _miliseconds;
        private Timer _timer;
        public Action Execution { get; private set; }
        public ITextChunk TextChunk { get; set; }
        public bool HasEnded { get; private set; }

        public Timeline(int miliseconds, Action execution)
        {
            _miliseconds = miliseconds;
            this.Execution = execution;
        }

        public void Start()
        {
            if (_timer != null)
            {
                _timer.Start();
                return;
            }

            _timer = new System.Timers.Timer();
            _timer.Enabled = true;
            _timer.Interval = _miliseconds;
            _timer.Start();
            _timer.Elapsed += (sender, args) =>
            {
                Execution();
            };
        }

        public void Stop()
        {
            _timer.Stop();
        }


    }
}
