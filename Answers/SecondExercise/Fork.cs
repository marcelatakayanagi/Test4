using System;
using System.Collections.Generic;
using System.Text;

namespace Answers.SecondExercise
{
    public class Fork
    {
        private bool _isSharped;
        public bool isSharped
        {
            get
            {
                return _isSharped;
            }
        }

        public void Sharpen(bool sharpen)
        {
            _isSharped = false;

        }
    }
}
