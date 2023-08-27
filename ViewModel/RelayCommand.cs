using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Mvvm4.ViewModel
{
    public class RelayCommand : ICommand
    {
        public Action<object> m_Execute;
        public Predicate<object> m_CanExecute;

        public RelayCommand( Action<object> C_Execute, Predicate<object> C_CanExecute){
            m_Execute = C_Execute;
            m_CanExecute = C_CanExecute;
       }


        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            m_Execute(parameter);
        }
    }
}
