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
        private object selectedDate;

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
        public object SelectedDate
        {
            get
            {
                return selectedDate;
            }
            set
            {
                selectedDate = value; ;
                this.RaisePropertyChanged("SelectedDate");
            }
        }

        public ViewModel()
        {
        
        }
    }
}
