
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Assignment.ViewModel
{
    public class RelayCommand : ICommand
    {
        Action<object> executeAction;
        Func<object, bool> canExecute;

        public RelayCommand(Action<object> executeAction, Func<object, bool> canExecute)
        {
            this.canExecute = canExecute;
            this.executeAction = executeAction;
        }

        public bool CanExecute(object parameter)
        {
            if (canExecute == null)
            {
                return true;

            }
            else
            {
                return canExecute(parameter);
            }
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            executeAction(parameter);
        }
    }
}