using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Mvvm4.Model;

namespace Mvvm4.ViewModel
{
    public class MultiViewModel : INotifyPropertyChanged
    {
        public MultiViewModel()
        {
            MultiInstance = new Multi();
        }
        private Multi _MultiInstance { get; set; }
        public Multi MultiInstance
        {
            get => _MultiInstance;
            set { _MultiInstance = value;
                notifyOnPropertyChanged("MultiInstance");
            }
        }

        public string Number1 { get => MultiInstance.Num1.ToString();
            set
            {
                MultiInstance.Num1 = int.Parse(value);
                notifyOnPropertyChanged("Number1");
                notifyOnPropertyChanged("CalculationResult");
            }
        }

        public string Number2
        {
            get => MultiInstance.Num2.ToString();
            set
            {
                MultiInstance.Num2 = int.Parse(value);
                notifyOnPropertyChanged("Number2");
                notifyOnPropertyChanged("CalculationResult");
            }
        }

        public string CalculationResult
        {
            get => MultiInstance.Result.ToString();
            set
            {
                MultiInstance.Result = int.Parse(Number1)* int.Parse(Number2);
                notifyOnPropertyChanged("CalculationResult");
            }
        }

        private RelayCommand _ShowCommand;
        public RelayCommand ShowCommand {
            get
            {
                if (_ShowCommand == null)
                {
                    _ShowCommand = new RelayCommand(showButton,canShowButton);
                }
                return _ShowCommand;
            }
        }

        public bool canShowButton(object parameter) { return true; }
        public void showButton(object parmeter) {
            MultiInstance.Result = int.Parse(Number1) * int.Parse(Number2); 
            MessageBox.Show(CalculationResult.ToString());
        }
    

        public event PropertyChangedEventHandler PropertyChanged;

        protected void notifyOnPropertyChanged(string PropertyName)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(PropertyName));
        }
    }
}
