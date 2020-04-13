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
        private bool setValueOnLostFocus = false;
        private object selectedTime;

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
        public object SelectedTime
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

        public ViewModel()
        {
        }
    }
}
