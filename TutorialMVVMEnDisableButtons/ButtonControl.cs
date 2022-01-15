using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialMVVMEnDisableButtons
{
    internal class ButtonControl
    {
        public enum State
        {
            start,
            pause,
            finish
        }
        public State CurrentState { get; set; }
    }
}
