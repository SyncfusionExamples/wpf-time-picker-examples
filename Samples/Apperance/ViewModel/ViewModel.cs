using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Apperance
{
    class ViewModel :NotificationObject
    {
        private FlowDirection flowDirection;
        private Brush foregroundBrush= Brushes.Aqua;
        private Brush backgroundBrush= Brushes.Black;
        private Brush selectedTimeBackgroundBrush = Brushes.Gold;
        private Brush selectedTimeForegroundBrush = Brushes.Red;
        private Brush timeSelectorForegroundBrush= Brushes.Blue;
        private Brush timeSelectorBackgroundBrush= Brushes.Orchid;

        public FlowDirection FlowDirection
        {
            get { return flowDirection; }
            set
            {
                flowDirection = value;
                this.RaisePropertyChanged("FlowDirection");
            }
        }

        public Brush ForegroundBrush
        {
            get
            {
                return foregroundBrush;
            }
            set
            {
                foregroundBrush = value;
                this.RaisePropertyChanged("ForegroundBrush");
            }
        }

        public Brush TimeSelectorForegroundBrush
        {
            get
            {
                return timeSelectorForegroundBrush;
            }
            set
            {
                timeSelectorForegroundBrush = value;
                this.RaisePropertyChanged("TimeSelectorForegroundBrush");
            }
        }
        public Brush SelectedTimeBackgroundBrush
        {
            get
            {
                return selectedTimeBackgroundBrush;
            }
            set
            {
                selectedTimeBackgroundBrush = value;
                this.RaisePropertyChanged("SelectedTimeBackgroundBrush");
            }
        }
        public Brush SelectedTimeForegroundBrush
        {
            get
            {
                return selectedTimeForegroundBrush;
            }
            set
            {
                selectedTimeForegroundBrush = value;
                this.RaisePropertyChanged("SelectedTimeForegroundBrush");
            }
        }

        public Brush BackgroundBrush
        {
            get
            {
                return backgroundBrush;
            }
            set
            {
                backgroundBrush = value;
                this.RaisePropertyChanged("BackgroundBrush");
            }
        }
        public Brush TimeSelectorBackgroundBrush
        {
            get
            {
                return timeSelectorBackgroundBrush;
            }
            set
            {
                timeSelectorBackgroundBrush = value;
                this.RaisePropertyChanged("TimeSelectorBackgroundBrush");
            }
        }
        public ViewModel()
        {

        }
    }
}
