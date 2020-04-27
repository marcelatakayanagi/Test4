using Answers.SecondExercise;
using System;
using System.Collections.Generic;

namespace Answers
{

    public class Drawer
    {
        private Dictionary<string, Drawer> _data;
        public Drawer this[string key]
        {
            get
            {
                Drawer drawer = _data.ContainsKey(key) ? _data[key] : null;
                if (drawer.Stuck)
                    throw new StuckDrawerExceptions();

                return drawer;
            }
            set
            {
                if (value! is ICut)
                    _data[key] = value;
            }

        }
        public class StuckDrawerExceptions : Exception { }



        private bool _stuck;
        public bool Stuck
        {
            get
            {
                return _stuck;
            }
        }
    }
}
