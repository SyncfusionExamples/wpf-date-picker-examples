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
        private Brush selectedDateBackgroundBrush= Brushes.Gold;
        private Brush selectedDateForegroundBrush= Brushes.Red;
        private Brush dateSelectorForegroundBrush= Brushes.Blue;
        private Brush dateSelectorBackgroundBrush= Brushes.Orchid;

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

        public Brush DateSelectorForegroundBrush
        {
            get
            {
                return dateSelectorForegroundBrush;
            }
            set
            {
                dateSelectorForegroundBrush = value;
                this.RaisePropertyChanged("DateSelectorForegroundBrush");
            }
        }
        public Brush SelectedDateBackgroundBrush
        {
            get
            {
                return selectedDateBackgroundBrush;
            }
            set
            {
                selectedDateBackgroundBrush = value;
                this.RaisePropertyChanged("SelectedDateBackgroundBrush");
            }
        }
        public Brush SelectedDateForegroundBrush
        {
            get
            {
                return selectedDateForegroundBrush;
            }
            set
            {
                selectedDateForegroundBrush = value;
                this.RaisePropertyChanged("SelectedDateForegroundBrush");
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
        public Brush DateSelectorBackgroundBrush
        {
            get
            {
                return dateSelectorBackgroundBrush;
            }
            set
            {
                dateSelectorBackgroundBrush = value;
                this.RaisePropertyChanged("DateSelectorBackgroundBrush");
            }
        }
        public ViewModel()
        {

        }
    }
}
