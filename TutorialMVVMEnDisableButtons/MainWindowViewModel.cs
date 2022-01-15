using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Form = System.Windows.Forms;

namespace TutorialMVVMEnDisableButtons
{
    public class MainWindowViewModel : ViewModelBase
    {
        private DelegateCommand _startCommand;
        private DelegateCommand _pauseCommand;
        private DelegateCommand _finishCommand;

        public ICommand StartCommand { get => _startCommand; }
        public ICommand PauseCommand { get => _pauseCommand; }
        public ICommand FinishCommand { get => _finishCommand; }

        //_startCommand = new DelegateCommand(Start, CanStart);
        //_pauseCommand = new DelegateCommand(Pause, CanPause);
        //_finishCommand = new DelegateCommand(Finish, CanFinish);


        private void Start()
        {

        }   
        
        private void Pause()
        {

        }   
        
        private void Finish()
        {

        }

        private bool CanStart()
        {
            return true;
        }

        private bool CanPause()
        {
            return true;
        }

        private bool CanFinish()
        {
            return true;
        }


        
    }
}
