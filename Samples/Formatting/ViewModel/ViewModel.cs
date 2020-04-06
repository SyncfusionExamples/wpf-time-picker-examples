using Syncfusion.Windows.Controls.Input;
using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace SfDatePicker_Formatting
{
    class ViewModel : NotificationObject
    {
        private ICommand formatselectionChangedCommand;
        private ICommand selectionChangedCommand;
        private string selectorFormatString;
        private string formatString;
        public string SelectorFormatString
        {
            get
            {
               return selectorFormatString;
            }
            set
            {
                 selectorFormatString = value;
                this.RaisePropertyChanged("SelectorFormatString");
            }
        }

        public string FormatString
        {
            get
            {
                return formatString;
            }
            set
            {
                formatString = value; ;
                this.RaisePropertyChanged("FormatString");
            }
        }

        public ICommand SelectionChangedCommand
        {
            get
            {
                return selectionChangedCommand;
            }
        }
       

        public ICommand FormatSelectionChangedCommand
        {
            get
            {
                return formatselectionChangedCommand;
            }
        }
        public ViewModel()
        {
            selectionChangedCommand = new DelegateCommand<object>(selectionChanged);
            formatselectionChangedCommand = new DelegateCommand<object>(selectionChanged);
        }

        public void selectionChanged(object parameter)
        {
            ComboBoxItem comboBoxItem = (parameter as ComboBox).SelectedItem as ComboBoxItem;
            if(comboBoxItem.Content.ToString()== "ShortTimePattern")
            {
                FormatString = "t";
            }
            else if (comboBoxItem.Content.ToString() == "LongTimePattern")
            {
                FormatString = "T";
            }
            else if(comboBoxItem.Content.ToString() == "RFC1123Pattern")
            {
                FormatString = "ddd, dd MMM yyyy HH':'mm':'ss 'GMT' (*)";
            }
            else if(comboBoxItem.Content.ToString() == "SortableDateTimePattern")
            {
                FormatString = "yyyy'-'MM'-'dd'T'HH':'mm':'ss (*)";
            }
            else if(comboBoxItem.Content.ToString() == "TwentyFourHourTimelinePattern")
            {
                FormatString = "yyyy'-'MM'-'dd' 'HH':'mm':'ss ";
            }
            else if(comboBoxItem.Content.ToString() == "UniversalSortableDateTimePattern")
            {
                FormatString = "yyyy'-'MM'-'dd HH':'mm':'ss'Z' (*)";
            }
            else if (comboBoxItem.Content.ToString() == "HourMinutePattern")
            {
                SelectorFormatString = "h/m";
            }
            else if (comboBoxItem.Content.ToString() == "HourMinuteSecondPattern")
            {
                SelectorFormatString = "h/m/s";
            }
            else if (comboBoxItem.Content.ToString() == "TwentyFourHourTimelinePattern")
            {
                SelectorFormatString = "HH/mmm/ss";
            }
            else if (comboBoxItem.Content.ToString() == "HourMeridienPattern")
            {
                SelectorFormatString = "h/t";
            }
            else if (comboBoxItem.Content.ToString() == "MeridianHourPattern")
            {
                SelectorFormatString = "t/h";
            }
            else if (comboBoxItem.Content.ToString() == "MinutePattern")
            {
                SelectorFormatString = "m";
            }
            else if(comboBoxItem.Content.ToString() == "HourPattern")
            {
                SelectorFormatString = "h";
            }
        }
    }


}
