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
        private string selectedDate;

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
        public string SelectedDate
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
            SelectedDate = (parameter as SfDatePicker).Value.ToString();
        }
    }
}
