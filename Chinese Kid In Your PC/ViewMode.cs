
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Chinese_Kid_In_Your_PC
{
    public class ViewModel : INotifyPropertyChanged
    {
        private double number1;
        private double number2;
        private string operation;
        private double result;

        public double Number1
        {
            get { return number1; }
            set
            {
                number1 = value;
                OnPropertyChanged();
                Calculate();
            }
        }

        public double Number2
        {
            get { return number2; }
            set
            {
                number2 = value;
                OnPropertyChanged();
                Calculate();
            }
        }

        public string Operation
        {
            get { return operation; }
            set
            {
                operation = value;
                OnPropertyChanged();
                Calculate();
            }
        }

        public double Result
        {
            get { return result; }
            set
            {
                result = value;
                OnPropertyChanged();
            }
        }

        private void Calculate()
        {
            var calculator = new Calculator();
            Result = calculator.Calculate(Number1, Number2, Operation);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}