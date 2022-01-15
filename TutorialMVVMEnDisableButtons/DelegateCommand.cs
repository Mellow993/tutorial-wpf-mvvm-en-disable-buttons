using System;
using System.Windows.Input;

namespace TutorialMVVMEnDisableButtons
{
    internal class DelegateCommand : ICommand
    {
        private Action _execute;
        private Func<bool> _canExecute;
        public event EventHandler? CanExecuteChanged;
        public DelegateCommand(Action? execute) 
        {
            if (execute == null)
                throw new ArgumentNullException();
            _execute = execute; 
        } 

        public DelegateCommand(Action execute, Func<bool> canexecute)
        {
            if (execute == null)
                throw new ArgumentNullException();
            _execute = execute;
            _canExecute = canexecute;
        }

        public bool CanExecute(object? parameter) => _canExecute != null ? _canExecute() : true;


        public void Execute(object? parameter) => _canExecute();   
      
    }
}
