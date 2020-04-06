using Syncfusion.Windows.Controls.Input;
using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SfDatePicker_Value_setting
{
    class ViewModel : NotificationObject
    {
        private ICommand selectionChangedCommand;
        private bool setValueOnLostFocus = false;
        private string selectedTime;

        public bool SetValueOnLostFocus
        {
            get
            {
                return setValueOnLostFocus;
            }
            set
            {
                setValueOnLostFocus = value; ;
                this.RaisePropertyChanged("SetValueOnLostFocus");
            }
        }
        public string SelectedTime
        {
            get
            {
                return selectedTime;
            }
            set
            {
                selectedTime = value; ;
                this.RaisePropertyChanged("SelectedTime");
            }
        }

       
        public ICommand SelectionChangedCommand
        {
            get
            {
                return selectionChangedCommand;
            }
        }

        public ViewModel()
        {
            selectionChangedCommand = new DelegateCommand<object>(selectionChanged);
        }

        public void selectionChanged(object parameter)
        {
            SelectedTime = (parameter as SfTimePicker).Value.ToString();
        }
    }
}
