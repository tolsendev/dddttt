using System;
using System.Collections.Generic;
using System.Text;

namespace Tycoon
{
    class TimeManager
    {
        public IEnumerable<ITickListener> _listeners;
        public TimeManager(params ITickListener[] listeners)
        {
            _listeners = listeners;
        }
        internal void Tick()
        {
            foreach(var listener in _listeners)
            {
                listener.Tick();
            }
        }
    }
}
