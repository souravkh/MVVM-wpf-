using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvvm4.Model
{
    public class Multi :INotifyPropertyChanged
    {
        private int _Num1 { get; set; }
        public int Num1 { get => _Num1;set { _Num1 = value; onPropertyChanged("Num1"); } }

        private int _Num2 { get; set; }
        public int Num2 { get => _Num2; set { _Num2 = value; onPropertyChanged("Num2"); } }

        private int _Result { get; set;}
        public int Result { get => _Result; set { _Result = Num1 * Num2; onPropertyChanged("Result"); } }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void onPropertyChanged(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
