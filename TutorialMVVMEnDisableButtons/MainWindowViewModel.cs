using System;
using System.Windows.Input;

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
