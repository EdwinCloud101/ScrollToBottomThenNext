using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public interface ITimeline
    {

    }

    public class Timeline : ITimeline
    {
        private readonly int _miliseconds;

        public Timeline(int miliseconds)
        {
            _miliseconds = miliseconds;
        }


    }
}
