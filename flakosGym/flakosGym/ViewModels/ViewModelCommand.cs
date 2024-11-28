using System;
using System.Windows.Input;

namespace flakosGym.ViewsModels
{
    internal class ViewModelCommand : ICommand
    {
        // Campos
        private readonly Action<object> _executeAction;
        private readonly Predicate<object> _canExecuteAction;

        // Constructores
        public ViewModelCommand(Action<object> executeAction)
        {
            _executeAction = executeAction ?? throw new ArgumentNullException(nameof(executeAction));
            _canExecuteAction = null;
        }

        public ViewModelCommand(Action<object> executeAction, Predicate<object> canExecuteAction)
        {
            _executeAction = executeAction ?? throw new ArgumentNullException(nameof(executeAction));
            _canExecuteAction = canExecuteAction;
        }

        // Evento requerido por ICommand
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        // Métodos
        public bool CanExecute(object parameter)
        {
            return _canExecuteAction == null || _canExecuteAction(parameter);
        }

        public void Execute(object parameter)
        {
            _executeAction(parameter);
        }
    }
}
