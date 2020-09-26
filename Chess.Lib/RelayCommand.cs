using System;
using System.Windows.Input;

namespace Chess.Lib
{
    public class RelayCommand : ICommand
    {
        private readonly Action execute;
        private readonly Func<bool> canExcute;

        public event EventHandler CanExecuteChanged
        {
          add => CommandManager.RequerySuggested += value;  
          remove => CommandManager.RequerySuggested -= value;
        }

        public RelayCommand(Action execute) : this (execute, null)
        {
            
        }

        public RelayCommand(Action execute, Func<bool> canExcute = null)
        {
            this.execute = execute;
            this.canExcute = canExcute;
        }

        public bool CanExecute(object parameter)
        {
            return canExcute?.Invoke() ?? true;
        }

        public void Execute(object parameter)
        {
            execute.Invoke();
        }
    }

    public class RelayCommand<T> : ICommand
    {
        private readonly Action<T> execute;
        private readonly Func<T, bool> canExcute;

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public RelayCommand(Action<T> execute) : this(execute, null)
        {

        }

        public RelayCommand(Action<T> execute, Func<T, bool> canExcute = null)
        {
            this.execute = execute;
            this.canExcute = canExcute;
        }

        public bool CanExecute(T parameter)
        {
            return canExcute?.Invoke(parameter) ?? true;
        }

        public void Execute(T parameter)
        {
            execute.Invoke(parameter);
        }

        bool ICommand.CanExecute(object parameter)
        {
            return CanExecute((T)parameter);
        }

        void ICommand.Execute(object parameter)
        {
            Execute((T)parameter);
        }
    }
}
