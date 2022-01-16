using System;
using System.Windows.Input;

namespace TutorialMVVMEnDisableButtons
{
    internal class DelegateCommand : ICommand
    {
        private Action _execute;
        private Func<bool> _canExecute;
        public event EventHandler? CanExecuteChanged;

        public DelegateCommand(Action execute, Func<bool> canexecute)
        {
            if (execute == null)
                throw new ArgumentNullException();
            _execute = execute;
            _canExecute = canexecute;
        }

        public void OnExecuteChanged() => CanExecuteChanged?.Invoke(this, new EventArgs());
        public bool CanExecute(object parameter) => _canExecute != null ? _canExecute() : true;
        public void Execute(object parameter) => _execute();   
      
    }
}
