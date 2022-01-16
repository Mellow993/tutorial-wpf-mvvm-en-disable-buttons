using System;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace TutorialMVVMEnDisableButtons
{
    public class MainWindowViewModel : ViewModelBase
    {
        private DelegateCommand _startCommand;
        private DelegateCommand _pauseCommand;
        private DelegateCommand _endCommand;

        readonly ButtonControl _buttonControl = new ButtonControl();

        public ICommand StartCommand { get => _startCommand; }
        public ICommand PauseCommand { get => _pauseCommand; }
        public ICommand EndCommand { get => _endCommand; }

        public MainWindowViewModel()
        {
            _startCommand = new DelegateCommand(Start, CanStart);
            _pauseCommand = new DelegateCommand(Pause, CanPause);
            _endCommand = new DelegateCommand(End, CanEnd);
            _buttonControl.CurrentState = ButtonControl.State.Start;
        }

        private void Start()
        {
            _buttonControl.CurrentState = ButtonControl.State.Pause;
            RaisePropertyChanged();
        }
            
        private bool CanStart() => _buttonControl.CurrentState == ButtonControl.State.Start ? true : false;
        private void Pause()
        {
            _buttonControl.CurrentState = ButtonControl.State.Finish;
            RaisePropertyChanged();
        }

        private bool CanPause() => _buttonControl.CurrentState == ButtonControl.State.Pause ? true : false;
        private void End()
        {
            System.Windows.Application.Current.Shutdown();
            RaisePropertyChanged();
        }
        private bool CanEnd() => _buttonControl.CurrentState == ButtonControl.State.Finish ? true : false;

        private void RaisePropertyChanged([CallerMemberName] string propname = "")
        {
            ((DelegateCommand)StartCommand).OnExecuteChanged();
            ((DelegateCommand)PauseCommand).OnExecuteChanged();
            ((DelegateCommand)EndCommand).OnExecuteChanged();
        }
    }
}
