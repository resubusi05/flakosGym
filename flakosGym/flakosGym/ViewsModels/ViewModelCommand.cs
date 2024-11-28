﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace flakosGym.ViewsModels
{
    internal class ViewModelCommand : ICommand
    {
        //Campos
        private readonly Action<object> _executeAction;
        private readonly Predicate<object> _canExecuteAction;

        //Constructores
        public ViewModelCommand(Action<object> executeAction) 
        {
            _executeAction = executeAction;
            _canExecuteAction = null;
        }

        public ViewModelCommand(Action<object> executeAction, Predicate<object> canExecuteAction)
        {
            _executeAction = executeAction;
            _canExecuteAction = canExecuteAction;
        }

        //Eventos
        public bool CanExecute(object parameter) 
        {
            return _canExecuteAction == null ? true : _canExecuteAction(parameter);
        }
        public void Execute(object parameter) 
        {
            _executeAction(parameter);
        }

    }
}
