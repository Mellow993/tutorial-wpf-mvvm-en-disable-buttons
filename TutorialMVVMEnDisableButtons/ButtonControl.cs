using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialMVVMEnDisableButtons
{
    public class ButtonControl
    {
        public enum State
        {
            Start,
            Pause,
            Finish
        }
        public State CurrentState { get; set; }
    }
}
